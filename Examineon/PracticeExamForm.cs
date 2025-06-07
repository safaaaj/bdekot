using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;




namespace Examineon
    {
    public partial class PracticeExamForm : Form
    {
        private string studentId; private string role;
        private List<Question> questions;
        private int currentIndex = 0;
        private int score = 0;
        private string selectedSubject;
        private string selectedDifficulty;

        public PracticeExamForm(string subject, string difficulty, List<Question> questions)
        {
            InitializeComponent();
            this.selectedSubject = subject;
            this.selectedDifficulty = difficulty;
            this.questions = questions;

            // ❌ Don’t show message here. Questions are already validated before calling this.
            if (questions.Count > 0)
                ShowQuestion(0);
        }


        private void ShowQuestion(int index)
        {
            var q = questions[index];
            label1.Text = q.QuestionText;
            lblQuestionNumber.Text = $"Question {index + 1} of {questions.Count}";

            // Reset selection
            rbA.Checked = rbB.Checked = rbC.Checked = rbD.Checked = false;

            // Always keep all buttons visible
            rbA.Visible = rbB.Visible = rbC.Visible = rbD.Visible = true;

            // Enable all by default
            rbA.Enabled = rbB.Enabled = rbC.Enabled = rbD.Enabled = true;

            string category = q.Category?.Trim().ToLower();
            string type = q.Type?.Trim().ToLower();

            if (category == "truefalse" || type == "truefalse" || q.AnswerC == null || q.AnswerD == null)
            {
                // Show only A and B for True/False, disable C and D
                rbA.Text = "True";
                rbB.Text = "False";

                rbC.Text = "";
                rbD.Text = "";

                rbC.Enabled = false;
                rbD.Enabled = false;
            }
            else
            {
                // Show full answers for multiple choice
                rbA.Text = q.AnswerA;
                rbB.Text = q.AnswerB;
                rbC.Text = q.AnswerC;
                rbD.Text = q.AnswerD;

                rbC.Enabled = true;
                rbD.Enabled = true;
            }
        }




        private void CheckAnswer()
        {
            string selected = "";
            if (rbA.Checked) selected = "A";
            else if (rbB.Checked) selected = "B";
            else if (rbC.Checked) selected = "C";
            else if (rbD.Checked) selected = "D";

            if (selected == questions[currentIndex].CorrectAnswer)
                score++;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentIndex < questions.Count)
            {
                CheckAnswer();

                string selected = GetCurrentAnswer();
                studentAnswers.Add(selected);

                currentIndex++;
            }

            if (currentIndex < questions.Count)
            {
                ShowQuestion(currentIndex);
            }
            else
            {
                btnNext.Enabled = false;
                btnSubmit.Visible = true;
                MessageBox.Show("You finished all questions. Click Submit!");
            }
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (currentIndex < questions.Count)
            {
                CheckAnswer();
                string selected = GetCurrentAnswer();
                studentAnswers.Add(selected);
            }

            double percentage = ((double)score / questions.Count) * 100;
            MessageBox.Show($"Your score: {percentage:F2}%");

            SavePracticeResultToExcel();

            var setupForm = new PracticeSetupForm();
            setupForm.Show();
            this.Close();
        }

        private string GetCurrentAnswer()
        {
            if (rbA.Checked) return "A";
            if (rbB.Checked) return "B";
            if (rbC.Checked) return "C";
            if (rbD.Checked) return "D";
            return "";
        }

        private List<string> studentAnswers = new List<string>();

        private void SavePracticeResultToExcel()
        {
            string filePath = "DATABASE.xlsx";
            FileInfo file = new FileInfo(filePath);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var package = new ExcelPackage(file) // always bind to the actual file path
)
            {
                var ws = package.Workbook.Worksheets.FirstOrDefault(s => s.Name == "StudentEH");
                if (ws == null)
                {
                    ws = package.Workbook.Worksheets.Add("StudentEH");

                    // Header
                    ws.Cells[1, 1].Value = "ExamID";
                    ws.Cells[1, 2].Value = "CreatedAt";
                    ws.Cells[1, 3].Value = "NumberOfQuestions";
                    ws.Cells[1, 4].Value = "QuestionText";
                    ws.Cells[1, 5].Value = "AnswerA";
                    ws.Cells[1, 6].Value = "AnswerB";
                    ws.Cells[1, 7].Value = "AnswerC";
                    ws.Cells[1, 8].Value = "AnswerD";
                    ws.Cells[1, 9].Value = "CorrectAnswer";
                    ws.Cells[1, 10].Value = "Category";
                    ws.Cells[1, 11].Value = "Difficulty";
                    ws.Cells[1, 12].Value = "Type";
                    ws.Cells[1, 13].Value = "StudentID";
                    ws.Cells[1, 14].Value = "StudentAnswers";
                    ws.Cells[1, 15].Value = "Score";
                }

                int nextRow = ws.Dimension?.End.Row + 1 ?? 2;

                string examId = Guid.NewGuid().ToString().Substring(0, 8);
                string createdAt = DateTime.Now.ToString("dd/MM/yyyy");
                string studentId = "214568953"; // ← replace this if you track login
                string allAnswers = "";
                int index = 1;

                double percentage = ((double)score / questions.Count) * 100;
                for (int i = 0; i < questions.Count; i++)
                {
                    var q = questions[i];
                    string studentAnswer = i < studentAnswers.Count ? studentAnswers[i] : "";


                    ws.Cells[nextRow, 1].Value = examId;
                    ws.Cells[nextRow, 2].Value = createdAt;
                    ws.Cells[nextRow, 3].Value = questions.Count;
                    ws.Cells[nextRow, 4].Value = q.QuestionText;
                    ws.Cells[nextRow, 5].Value = q.AnswerA;
                    ws.Cells[nextRow, 6].Value = q.AnswerB;
                    ws.Cells[nextRow, 7].Value = q.AnswerC;
                    ws.Cells[nextRow, 8].Value = q.AnswerD;
                    ws.Cells[nextRow, 9].Value = q.CorrectAnswer;
                    ws.Cells[nextRow, 10].Value = q.Category;
                    ws.Cells[nextRow, 11].Value = q.Difficulty;
                    ws.Cells[nextRow, 12].Value = "practice"; // 👈 This marks it as a PRACTICE test
                    ws.Cells[nextRow, 13].Value = studentId;
                    ws.Cells[nextRow, 14].Value = $"Q{i + 1}:{studentAnswer}";
                    ws.Cells[nextRow, 15].Value = percentage;

                    index++;
                    nextRow++;
                }

                if (!file.Exists)
                    package.SaveAs(file); // create the file
                else
                    package.Save();
                string fullPath = Path.GetFullPath(file.FullName);
                MessageBox.Show($"✅ Practice data saved to:\n{fullPath}", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PracticeExamForm_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SecondaryForm secondaryForm = new SecondaryForm(role, studentId);
            secondaryForm.Show();
            this.Hide();
            this.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

