using Microsoft.VisualStudio.TestTools.UnitTesting;
using Examineon;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using OfficeOpenXml;

namespace Examineon.Tests
{
    [TestClass]
    public class PracticeExamFormTests
    {
        FileInfo db;
        PracticeExamForm form;

        [TestInitialize]
        public void Init()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            db = new FileInfo("DATABASE.xlsx");
            if (db.Exists) db.Delete();
        }

        [TestCleanup]
        public void Cleanup()
        {
            form?.Dispose();
            if (db.Exists) db.Delete();
        }

        void RunSta(Action act)
        {
            Exception ex = null;
            var t = new Thread(() =>
            {
                try { act(); }
                catch (Exception err) { ex = err; }
            });
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();
            if (ex != null) throw ex;
        }

        [TestMethod]
        public void PracticeExam_SavesResultsToExcel()
        {
            RunSta(() =>
            {
                var questions = new List<Question>
                {
                    new Question
                    {
                        QuestionText = "What is 2+2?",
                        AnswerA = "3",
                        AnswerB = "4",
                        AnswerC = "5",
                        AnswerD = "6",
                        CorrectAnswer = "B",
                        Category = "Math",
                        Difficulty = "Easy",
                        Type = "Multiple Choice"
                    },
                    new Question
                    {
                        QuestionText = "True is...",
                        AnswerA = "True",
                        AnswerB = "False",
                        AnswerC = "",
                        AnswerD = "",
                        CorrectAnswer = "A",
                        Category = "TrueFalse",
                        Difficulty = "Easy",
                        Type = "TrueFalse"
                    }
                };

                form = new PracticeExamForm("Math", "Easy", questions);
                form.Show();

                var rbB = Find<RadioButton>(form, "rbB");
                var btnNext = Find<Button>(form, "btnNext");

                rbB.Checked = true;
                btnNext.PerformClick();

                var rbA = Find<RadioButton>(form, "rbA");
                rbA.Checked = true;

                var btnSubmit = Find<Button>(form, "btnSubmit");
                btnSubmit.PerformClick();

                using var pkg = new ExcelPackage(db);
                var ws = pkg.Workbook.Worksheets["StudentEH"];
                Assert.IsNotNull(ws);
                Assert.AreEqual("What is 2+2?", ws.Cells[2, 4].Text);
                Assert.AreEqual("True is...", ws.Cells[3, 4].Text);
                Assert.AreEqual("practice", ws.Cells[2, 12].Text);
                Assert.AreEqual("214568953", ws.Cells[2, 13].Text);
                Assert.AreEqual("Q1:B", ws.Cells[2, 14].Text);
                Assert.AreEqual("Q2:A", ws.Cells[3, 14].Text);
            });
        }

        T Find<T>(Control parent, string name) where T : Control
        {
            foreach (Control c in parent.Controls)
            {
                if (c.Name == name && c is T t) return t;
                var child = Find<T>(c, name);
                if (child != null) return child;
            }
            return null;
        }
    }
}