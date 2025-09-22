using Microsoft.VisualStudio.TestTools.UnitTesting;
using Examineon;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using OfficeOpenXml;

namespace Examineon.Tests
{
    [TestClass]
    public class LecturerAnalysisFormTests
    {
        FileInfo db;
        LecturerAnalysisForm form;

        [TestInitialize]
        public void Init()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            db = new FileInfo("DATABASE.xlsx");
            if (db.Exists) db.Delete();

            using (var package = new ExcelPackage(db))
            {
                var ws = package.Workbook.Worksheets.Add("StudentEH");
                ws.Cells[1, 13].Value = "StudentID";
                ws.Cells[1, 15].Value = "Score";

                ws.Cells[2, 13].Value = "S1";
                ws.Cells[2, 15].Value = 90;

                ws.Cells[3, 13].Value = "S2";
                ws.Cells[3, 15].Value = 80;

                ws.Cells[4, 13].Value = "S1";
                ws.Cells[4, 15].Value = 85;

                package.Save();
            }

            form = null;
        }

        void RunSta(Action action)
        {
            Exception error = null;
            var t = new Thread(() =>
            {
                try { action(); }
                catch (Exception ex) { error = ex; }
            });
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();
            if (error != null) throw error;
        }

        [TestCleanup]
        public void Cleanup()
        {
            if (db.Exists) db.Delete();
            form?.Dispose();
        }

        [TestMethod]
        public void LoadStudentData_ReturnsCorrectNumberOfStudents()
        {
            RunSta(() =>
            {
                form = new LecturerAnalysisForm();
                var method = typeof(LecturerAnalysisForm)
                    .GetMethod("LoadStudentData", BindingFlags.NonPublic | BindingFlags.Instance);

                var result = method.Invoke(form, null) as System.Collections.Generic.List<LecturerAnalysisForm.StudentRecord>;
                Assert.IsNotNull(result);
                Assert.AreEqual(2, result.Count);
            });
        }

        [TestMethod]
        public void BtnFilterAboveAverage_FiltersCorrectly()
        {
            RunSta(() =>
            {
                form = new LecturerAnalysisForm();
                var loadMethod = typeof(LecturerAnalysisForm)
                    .GetMethod("LecturerAnalysisForm_Load", BindingFlags.NonPublic | BindingFlags.Instance);

                loadMethod.Invoke(form, new object[] { null, EventArgs.Empty });

                var btnFilter = form.Controls.Find("btnFilterAboveAverage", true).FirstOrDefault();
                Assert.IsNotNull(btnFilter);

                var clickMethod = btnFilter.GetType().GetMethod("OnClick", BindingFlags.NonPublic | BindingFlags.Instance);
                clickMethod.Invoke(btnFilter, new object[] { EventArgs.Empty });

                var dgv = form.Controls.Find("dataGridView1", true).FirstOrDefault() as DataGridView;
                Assert.IsNotNull(dgv);
                Assert.IsTrue(dgv.RowCount >= 1);
            });
        }
    }
}