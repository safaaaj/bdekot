using Microsoft.VisualStudio.TestTools.UnitTesting;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Examineon;

namespace Examineon.Tests
{

    [TestClass, DoNotParallelize]
    public class CreateExamTests
    {
        private FileInfo _dbFile;
        private CreateExam _form;

        #region Test Setup / Teardown
        [TestInitialize]
        public void Setup()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            _dbFile = new FileInfo("DATABASE.xlsx");
            if (_dbFile.Exists) _dbFile.Delete();

            using (var pkg = new ExcelPackage(_dbFile))
            {

                var q = pkg.Workbook.Worksheets.Add("Questions");
                q.Cells[1, 1].Value = "QuestionText";
                q.Cells[1, 2].Value = "AnswerA";
                q.Cells[1, 3].Value = "AnswerB";
                q.Cells[1, 4].Value = "AnswerC";
                q.Cells[1, 5].Value = "AnswerD";
                q.Cells[1, 6].Value = "CorrectAnswer";
                q.Cells[1, 7].Value = "Category";
                q.Cells[1, 8].Value = "Difficulty";
                q.Cells[1, 9].Value = "Type";

                q.Cells[2, 1].Value = "What is 2+2?";
                q.Cells[2, 2].Value = "3";
                q.Cells[2, 3].Value = "4";
                q.Cells[2, 4].Value = "5";
                q.Cells[2, 5].Value = "6";
                q.Cells[2, 6].Value = "4";
                q.Cells[2, 7].Value = "Math";
                q.Cells[2, 8].Value = "Easy";
                q.Cells[2, 9].Value = "MC";

                q.Cells[3, 1].Value = "Capital of France?";
                q.Cells[3, 2].Value = "Berlin";
                q.Cells[3, 3].Value = "Paris";
                q.Cells[3, 4].Value = "Rome";
                q.Cells[3, 5].Value = "Madrid";
                q.Cells[3, 6].Value = "Paris";
                q.Cells[3, 7].Value = "Geo";
                q.Cells[3, 8].Value = "Medium";
                q.Cells[3, 9].Value = "MC";

                pkg.Save();
            }

            _form = new CreateExam();
        }

        [TestCleanup]
        public void Cleanup()
        {
            _form?.Dispose();
            if (_dbFile.Exists) _dbFile.Delete();
        }
        #endregion


        [TestMethod]
        public void LoadQuestionsFromDatabase_LoadsAllRows()
        {
            var questionsField = typeof(CreateExam)
                .GetField("availableQuestions", BindingFlags.NonPublic | BindingFlags.Instance);
            var list = (List<CreateExam.Question>)questionsField.GetValue(_form);

            Assert.AreEqual(2, list.Count,
                $"Expected 2 questions, got {list.Count}");
        }


        [TestMethod]
        public void SaveExamToDatabase_WritesExamRows()
        {
            var saveMethod = typeof(CreateExam)
                .GetMethod("SaveExamToDatabase",
                           BindingFlags.NonPublic | BindingFlags.Instance);

            var sampleQs = new List<CreateExam.Question>
            {
                new CreateExam.Question
                {
                    QuestionText = "What is 2+2?",
                    AnswerA = "3", AnswerB = "4", AnswerC = "5", AnswerD = "6",
                    CorrectAnswer = "4", Category = "Math", Difficulty = "Easy", Type = "MC"
                },
                new CreateExam.Question
                {
                    QuestionText = "Capital of France?",
                    AnswerA = "Berlin", AnswerB = "Paris", AnswerC = "Rome", AnswerD = "Madrid",
                    CorrectAnswer = "Paris", Category = "Geo", Difficulty = "Medium", Type = "MC"
                }
            };

            saveMethod.Invoke(_form, new object[] { sampleQs });

            using (var pkg = new ExcelPackage(_dbFile))
            {
                var ws = pkg.Workbook.Worksheets["Exam"];
                Assert.IsNotNull(ws, "Exam sheet should exist after saving.");

                Assert.AreEqual(3, ws.Dimension.End.Row,
                    $"Expected 3 rows (1 header + 2 data). Actual: {ws.Dimension.End.Row}");
            }
        }


        [TestMethod]
        public void LoadExistingExams_LoadsDistinctQuestionTexts()
        {
            SaveExamToDatabase_WritesExamRows();

            var loadExams = typeof(CreateExam)
                .GetMethod("LoadExistingExams",
                           BindingFlags.NonPublic | BindingFlags.Instance);
            loadExams.Invoke(_form, null);

            var existingField = typeof(CreateExam)
                .GetField("existingExamQuestions",
                          BindingFlags.NonPublic | BindingFlags.Instance);
            var list = (List<string>)existingField.GetValue(_form);

            CollectionAssert.AreEquivalent(
                new[] { "What is 2+2?", "Capital of France?" }, list,
                "existingExamQuestions should contain distinct QuestionText values from Exam sheet.");
        }


        [TestMethod]
        public void CompareQuestionsWithExams_FindsDuplicates()
        {
            SaveExamToDatabase_WritesExamRows();

            var loadExams = typeof(CreateExam)
                .GetMethod("LoadExistingExams",
                           BindingFlags.NonPublic | BindingFlags.Instance);
            loadExams.Invoke(_form, null);

            var compare = typeof(CreateExam)
                .GetMethod("CompareQuestionsWithExams",
                           BindingFlags.NonPublic | BindingFlags.Instance);
            compare.Invoke(_form, null);

            var available = (List<CreateExam.Question>)typeof(CreateExam)
                .GetField("availableQuestions",
                          BindingFlags.NonPublic | BindingFlags.Instance)
                .GetValue(_form);
            var existing = (List<string>)typeof(CreateExam)
                .GetField("existingExamQuestions",
                          BindingFlags.NonPublic | BindingFlags.Instance)
                .GetValue(_form);

            var dupes = available.Where(q => existing.Contains(q.QuestionText)).ToList();
            Assert.AreEqual(2, dupes.Count,
                "Both questions should be detected as duplicates.");
        }
    }
}