using Microsoft.VisualStudio.TestTools.UnitTesting;
using OfficeOpenXml;
using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Linq;
using System.Reflection;
using Examineon;

namespace Examineon.Tests
{
    [TestClass]
    public class StudentScoresFormTests
    {
        FileInfo db;
        StudentScoresForm form;

        [TestInitialize]
        public void Init()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            db = new FileInfo("DATABASE.xlsx");
            if (db.Exists) db.Delete();
            CreateSampleData("214568953"); // studentId
        }

        [TestCleanup]
        public void Cleanup()
        {
            form?.Dispose();
            if (db.Exists) db.Delete();
        }

        [TestMethod]
        public void StudentScores_LoadsScoresCorrectly()
        {
            RunSta(() =>
            {
                form = new StudentScoresForm("214568953");
                form.Show();

                var dgv = GetField<DataGridView>("dgvHistory");
                var lbl = GetField<Label>("lblAverage");

                Assert.IsTrue(dgv.Rows.Count > 0, "No rows loaded into DataGridView");
                Assert.IsTrue(lbl.Text.Contains("Average"), "Average label not updated correctly");
            });
        }

        void RunSta(Action act)
        {
            Exception ex = null;
            var t = new Thread(() =>
            {
                try { act(); }
                catch (Exception e) { ex = e; }
            });
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();
            if (ex != null) throw ex;
        }

        void CreateSampleData(string studentId)
        {
            using var package = new ExcelPackage(db);
            var ws = package.Workbook.Worksheets.Add("StudentEH");

            ws.Cells[1, 1].Value = "ExamID";
            ws.Cells[1, 2].Value = "CreatedAt";
            ws.Cells[1, 10].Value = "Category";
            ws.Cells[1, 13].Value = "StudentID";
            ws.Cells[1, 15].Value = "Score";

            ws.Cells[2, 1].Value = "EXAM001";
            ws.Cells[2, 2].Value = DateTime.Now.AddDays(-3).ToShortDateString();
            ws.Cells[2, 10].Value = "Math";
            ws.Cells[2, 13].Value = studentId;
            ws.Cells[2, 15].Value = 85;

            ws.Cells[3, 1].Value = "EXAM002";
            ws.Cells[3, 2].Value = DateTime.Now.AddDays(-1).ToShortDateString();
            ws.Cells[3, 10].Value = "Math";
            ws.Cells[3, 13].Value = studentId;
            ws.Cells[3, 15].Value = 95;

            package.Save();
        }

        T GetField<T>(string name) where T : Control
        {
            var control = form.Controls.Find(name, true).FirstOrDefault();
            return control as T ?? throw new Exception($"Control '{name}' of type {typeof(T).Name} not found.");
        }
    }
}