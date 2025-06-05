using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using OfficeOpenXml;
using static Examineon.Form1;

namespace Examineon
{
    public partial class TestForm : Form
    {
        private List<Question> questions = new List<Question>();
        private int currentQuestionIndex = 0;
        private int correctCount = 0;

        private string studentId;
        private string examId;
        private Dictionary<int, string> selectedAnswers = new Dictionary<int, string>();

        public TestForm(string studentId, string examId)
        {
            InitializeComponent();
            this.studentId = studentId;
            this.examId = examId;

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            questions = LoadExamFromDatabase(examId);
            MessageBox.Show($"Loaded {questions.Count} questions for exam {examId}");


            if (questions.Count == 0)
            {
                MessageBox.Show("❌ This exam is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            ShowQuestion();
        }

        private List<Question> LoadExamFromDatabase(string examId)
        {
            List<Question> list = new List<Question>();
            var file = new FileInfo("DATABASE.xlsx");

            using (var package = new ExcelPackage(file))
            {
                var ws = package.Workbook.Worksheets["Exam"];
                if (ws == null || ws.Dimension == null)
                    return list;

                int rowCount = ws.Dimension.End.Row;
                string currentExamId = "";

                for (int row = 2; row <= rowCount; row++)
                {
                    string cellExamId = ws.Cells[row, 1].Text.Trim();

                    // Update current exam ID if cell is not empty
                    if (!string.IsNullOrEmpty(cellExamId))
                        currentExamId = cellExamId;

                    // If this row belongs to the selected exam, load it
                    if (currentExamId == examId)
                    {
                        list.Add(new Question
                        {
                            QuestionText = ws.Cells[row, 4].Text.Trim(),
                            AnswerA = ws.Cells[row, 5].Text.Trim(),
                            AnswerB = ws.Cells[row, 6].Text.Trim(),
                            AnswerC = ws.Cells[row, 7].Text.Trim(),
                            AnswerD = ws.Cells[row, 8].Text.Trim(),
                            CorrectAnswer = ws.Cells[row, 9].Text.Trim(),
                            Category = ws.Cells[row, 10].Text.Trim(),
                            Difficulty = ws.Cells[row, 11].Text.Trim(),
                            Type = ws.Cells[row, 12].Text.Trim()
                        });
                    }
                }
            }

            return list;
        }


        private void ShowQuestion()
        {
            if (currentQuestionIndex >= questions.Count)
            {
                FinishExam();
                return;
            }

            var q = questions[currentQuestionIndex];
            lblQuestion.Text = q.QuestionText;
            rbA.Text = q.AnswerA;
            rbB.Text = q.AnswerB;
            rbC.Text = q.AnswerC;
            rbD.Text = q.AnswerD;

            lblProgress.Text = $"Question {currentQuestionIndex + 1} of {questions.Count}";

            if (q.Type?.ToLower() == "true/false")
            {
                rbA.Text = "True";
                rbB.Text = "False";
                rbC.Visible = false;
                rbD.Visible = false;
            }
            else
            {
                rbC.Visible = true;
                rbD.Visible = true;
            }

            rbA.Checked = rbB.Checked = rbC.Checked = rbD.Checked = false;
        }

        private string GetSelectedAnswer()
        {
            return rbA.Checked ? "A" :
                   rbB.Checked ? "B" :
                   rbC.Checked ? "C" :
                   rbD.Checked ? "D" : "";
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            if (currentQuestionIndex >= questions.Count - 1)
            {
                MessageBox.Show("You’ve reached the last question. Click Submit to finish.");
                return;
            }

            string selected = GetSelectedAnswer();
            if (string.IsNullOrEmpty(selected))
            {
                MessageBox.Show("Please select an answer before continuing.");
                return;
            }

            selectedAnswers[currentQuestionIndex] = selected;

            if (selected == questions[currentQuestionIndex].CorrectAnswer)
                correctCount++;

            currentQuestionIndex++;
            ShowQuestion();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string selected = GetSelectedAnswer();
            if (string.IsNullOrEmpty(selected))
            {
                MessageBox.Show("Please select an answer before submitting.");
                return;
            }

            // ✅ Avoid counting again if already stored
            if (!selectedAnswers.ContainsKey(currentQuestionIndex))
            {
                selectedAnswers[currentQuestionIndex] = selected;

                if (selected == questions[currentQuestionIndex].CorrectAnswer)
                    correctCount++;
            }


            // Ensure all unanswered questions are filled with "-"
            for (int i = 0; i < questions.Count; i++)
            {
                if (!selectedAnswers.ContainsKey(i))
                    selectedAnswers[i] = "-";
            }

            double percentage = ((double)correctCount / questions.Count) * 100;
            MessageBox.Show($"Exam finished!\nScore: {percentage:F2}% ({correctCount}/{questions.Count})");

            SaveResultToExcel(percentage);
            this.Close();
        }

        private void SaveResultToExcel(double score)
        {
            var file = new FileInfo("DATABASE.xlsx");

            using (var package = new ExcelPackage(file))
            {
                var ws = package.Workbook.Worksheets["StudentEH"];
                if (ws == null)
                    ws = package.Workbook.Worksheets.Add("StudentEH");

                int row = ws.Dimension?.End.Row + 1 ?? 2;
                DateTime now = DateTime.Now;

                string subject = questions[0].Category;
                string difficulty = questions[0].Difficulty;

                string studentAnswers = "";
                for (int i = 0; i < questions.Count; i++)
                {
                    string answer = selectedAnswers.ContainsKey(i) ? selectedAnswers[i] : "-";
                    studentAnswers += $"Q{i + 1}:{answer}, ";
                }

                ws.Cells[row, 1].Value = examId;
                ws.Cells[row, 2].Value = now.ToShortDateString();
                ws.Cells[row, 3].Value = questions.Count;
                ws.Cells[row, 4].Value = questions[0].QuestionText;
                ws.Cells[row, 5].Value = "";
                ws.Cells[row, 6].Value = "";
                ws.Cells[row, 7].Value = "";
                ws.Cells[row, 8].Value = "";
                ws.Cells[row, 9].Value = "";
                ws.Cells[row, 10].Value = subject;
                ws.Cells[row, 11].Value = difficulty;
                ws.Cells[row, 12].Value = "exam";
                ws.Cells[row, 13].Value = studentId;
                ws.Cells[row, 14].Value = studentAnswers.TrimEnd(',', ' ');
                ws.Cells[row, 15].Value = score;

                package.Save();
                MessageBox.Show("studentId = " + studentId); // ✅

            }
        }

        private void FinishExam()
        {
            MessageBox.Show($"Exam finished!\nCorrect: {correctCount} out of {questions.Count}");
            this.Close();
        }

        private void rbA_CheckedChanged(object sender, EventArgs e) { }

        private void TestForm_Load(object sender, EventArgs e)
        {

        }
    }
}