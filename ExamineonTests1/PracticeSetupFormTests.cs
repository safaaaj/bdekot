using Microsoft.VisualStudio.TestTools.UnitTesting;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Examineon.Tests
{
    [TestClass]
    public class PracticeSetupFormTests
    {
        private FileInfo db;

        [TestInitialize]
        public void Init()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            db = new FileInfo("DATABASE.xlsx");
            if (db.Exists) db.Delete();
            CreateSampleQuestions();
        }

        [TestCleanup]
        public void Cleanup()
        {
            if (db.Exists) db.Delete();
        }

        [TestMethod]
        public void PracticeSetupForm_LoadsQuestionsSuccessfully()
        {
            RunSta(() =>
            {
                var form = new PracticeSetupForm();
                form.Show();

                var cmbSubject = Find<ComboBox>(form, "cmbPracticeSubject");
                var cmbDiff = Find<ComboBox>(form, "cmbPracticeDifficulty");
                var btnStart = Find<Button>(form, "btnStartPractice");

                cmbSubject.SelectedItem = "Math";
                cmbDiff.SelectedItem = "Easy";
                btnStart.PerformClick();

                // אם אין חריגות, הבדיקה עוברת
                Assert.IsTrue(true);
            });
        }

        private void CreateSampleQuestions()
        {
            using var package = new ExcelPackage(db);
            var ws = package.Workbook.Worksheets.Add("Questions");

            ws.Cells[1, 1].Value = "QuestionText";
            ws.Cells[1, 2].Value = "AnswerA";
            ws.Cells[1, 3].Value = "AnswerB";
            ws.Cells[1, 4].Value = "AnswerC";
            ws.Cells[1, 5].Value = "AnswerD";
            ws.Cells[1, 6].Value = "CorrectAnswer";
            ws.Cells[1, 7].Value = "Category";
            ws.Cells[1, 8].Value = "Difficulty";
            ws.Cells[1, 9].Value = "Type";

            ws.Cells[2, 1].Value = "What is 10 + 5?";
            ws.Cells[2, 2].Value = "12";
            ws.Cells[2, 3].Value = "13";
            ws.Cells[2, 4].Value = "14";
            ws.Cells[2, 5].Value = "15";
            ws.Cells[2, 6].Value = "D";
            ws.Cells[2, 7].Value = "Math";
            ws.Cells[2, 8].Value = "Easy";
            ws.Cells[2, 9].Value = "Multiple Choice";

            package.Save();
        }

        private void RunSta(Action body)
        {
            Exception ex = null;
            var t = new Thread(() =>
            {
                try { body(); }
                catch (Exception e) { ex = e; }
            });
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();
            if (ex != null) throw ex;
        }

        private T Find<T>(Form form, string name) where T : Control
        {
            var ctrl = form.Controls.Find(name, true).FirstOrDefault();
            return ctrl as T ?? throw new Exception($"Control '{name}' not found.");
        }
    }
}