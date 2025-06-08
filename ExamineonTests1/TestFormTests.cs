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
    public class TestFormTests
    {
        private FileInfo db;
        private string examId = "EXAM123";
        private string studentId = "999999999";

        [TestInitialize]
        public void Init()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            db = new FileInfo("DATABASE.xlsx");
            if (db.Exists) db.Delete();
            CreateSampleExam();
        }

        [TestCleanup]
        public void Cleanup()
        {
            if (db.Exists) db.Delete();
        }

        [TestMethod]
        public void TestForm_Submits_And_SavesResults()
        {
            RunSta(() =>
            {
                var form = new TestForm(studentId, examId);
                form.Show();

                var rbA = Find<RadioButton>(form, "rbA");
                var btnNext = Find<Button>(form, "btnNext");
                var btnSubmit = Find<Button>(form, "btnSubmit");

                for (int i = 0; i < 2; i++)
                {
                    rbA.Checked = true;
                    btnNext.PerformClick();
                }

                btnSubmit.PerformClick();

                using var package = new ExcelPackage(db);
                var ws = package.Workbook.Worksheets["StudentEH"];
                Assert.IsNotNull(ws, "StudentEH sheet not found");
                Assert.AreEqual(examId, ws.Cells[2, 1].Text, "ExamID mismatch");
                Assert.AreEqual(studentId, ws.Cells[2, 13].Text, "StudentID mismatch");
                Assert.AreEqual("Q1:A", ws.Cells[2, 14].Text, "Answer not saved properly");
            });
        }

        private void CreateSampleExam()
        {
            using var package = new ExcelPackage(db);
            var ws = package.Workbook.Worksheets.Add("Exam");

            ws.Cells[1, 1].Value = "ExamID";
            ws.Cells[1, 4].Value = "QuestionText";
            ws.Cells[1, 5].Value = "AnswerA";
            ws.Cells[1, 6].Value = "AnswerB";
            ws.Cells[1, 7].Value = "AnswerC";
            ws.Cells[1, 8].Value = "AnswerD";
            ws.Cells[1, 9].Value = "CorrectAnswer";
            ws.Cells[1, 10].Value = "Category";
            ws.Cells[1, 11].Value = "Difficulty";
            ws.Cells[1, 12].Value = "Type";

            ws.Cells[2, 1].Value = examId;
            ws.Cells[2, 4].Value = "What is 2+2?";
            ws.Cells[2, 5].Value = "4";
            ws.Cells[2, 6].Value = "3";
            ws.Cells[2, 7].Value = "2";
            ws.Cells[2, 8].Value = "1";
            ws.Cells[2, 9].Value = "A";
            ws.Cells[2, 10].Value = "Math";
            ws.Cells[2, 11].Value = "Easy";
            ws.Cells[2, 12].Value = "Multiple Choice";

            ws.Cells[3, 4].Value = "What is 3+1?";
            ws.Cells[3, 5].Value = "4";
            ws.Cells[3, 6].Value = "5";
            ws.Cells[3, 7].Value = "6";
            ws.Cells[3, 8].Value = "7";
            ws.Cells[3, 9].Value = "A";
            ws.Cells[3, 10].Value = "Math";
            ws.Cells[3, 11].Value = "Easy";
            ws.Cells[3, 12].Value = "Multiple Choice";

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