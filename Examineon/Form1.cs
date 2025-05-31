using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using System.IO;
using System.Drawing.Imaging;
using System.Security.Cryptography;


namespace Examineon
{
    public partial class Form1 : Form
    {
        private List<Question> questions = new List<Question>();

        public Form1()
        {
            InitializeComponent();
            btnAdd.Click += btnAdd_Click;
            btnClear.Click += btnClear_Click;
            btnDisplay.Click += btnDisplay_Click;
            OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

        }

        private void SaveQuestionToExcel(Question q)
        {
            var file = new FileInfo("DATABASE.xlsx");

            using (var package = new ExcelPackage(file))
            {
                ExcelWorksheet ws = package.Workbook.Worksheets.FirstOrDefault(w => w.Name == "Questions");

                if (ws == null)
                {
                    ws = package.Workbook.Worksheets.Add("Questions");

                    ws.Cells[1, 1].Value = "QuestionText";
                    ws.Cells[1, 2].Value = "AnswerA";
                    ws.Cells[1, 3].Value = "AnswerB";
                    ws.Cells[1, 4].Value = "AnswerC";
                    ws.Cells[1, 5].Value = "AnswerD";
                    ws.Cells[1, 6].Value = "CorrectAnswer";
                    ws.Cells[1, 7].Value = "Category";
                    ws.Cells[1, 8].Value = "Difficulty";
                    ws.Cells[1, 9].Value = "Type";

                    ws.Row(1).Style.Font.Bold = true;
                }

                int newRow = ws.Dimension?.End.Row + 1 ?? 2;

                ws.Cells[newRow, 1].Value = q.QuestionText;
                ws.Cells[newRow, 2].Value = q.AnswerA;
                ws.Cells[newRow, 3].Value = q.AnswerB;
                ws.Cells[newRow, 4].Value = q.AnswerC;
                ws.Cells[newRow, 5].Value = q.AnswerD;
                ws.Cells[newRow, 6].Value = q.CorrectAnswer;
                ws.Cells[newRow, 7].Value = q.Category;
                ws.Cells[newRow, 8].Value = q.Difficulty;
                ws.Cells[newRow, 9].Value = q.Type;

                package.Save();
            }

            MessageBox.Show("Question saved successfully!", "Saved", MessageBoxButtons.OK);
        }
        public static List<Question> LoadQuestionsFromDatabase()
        {
            var questions = new List<Question>();
            var file = new FileInfo("DATABASE.xlsx");

            using (var package = new ExcelPackage(file))
            {
                var ws = package.Workbook.Worksheets.FirstOrDefault(w => w.Name == "Questions");
                if (ws == null) return questions;

                int rowCount = ws.Dimension.End.Row;
                for (int row = 2; row <= rowCount; row++)
                {
                    questions.Add(new Question
                    {
                        QuestionText = ws.Cells[row, 1].Text,
                        AnswerA = ws.Cells[row, 2].Text,
                        AnswerB = ws.Cells[row, 3].Text,
                        AnswerC = ws.Cells[row, 4].Text,
                        AnswerD = ws.Cells[row, 5].Text,
                        CorrectAnswer = ws.Cells[row, 6].Text,
                        Category = ws.Cells[row, 7].Text,
                        Difficulty = ws.Cells[row, 8].Text,
                        Type = ws.Cells[row, 9].Text
                    });
                }
            }

            return questions;
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            cmbType.Items.AddRange(new string[]
            {
                "Multiple Choice",
                "True/False",
                "Fill-in-the-Blank",
                "Multiple Answers",
                "Short Answer"
            });

            cmbCategory.Items.AddRange(new string[]
            {
                "English", "Math", "Hebrew"
            });

            cmbDifficulty.Items.AddRange(new string[]
            {
                "Easy", "Medium", "Hard"
            });

            cmbType.SelectedIndex = 0;
            cmbCategory.SelectedIndex = 0;
            cmbDifficulty.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtQuestion.Text) ||
                string.IsNullOrWhiteSpace(txtAnswerA.Text) ||
                string.IsNullOrWhiteSpace(txtAnswerB.Text) ||
                string.IsNullOrWhiteSpace(txtAnswerC.Text) ||
                string.IsNullOrWhiteSpace(txtAnswerD.Text))
            {
                MessageBox.Show("Please fill in all question and answer fields.");
                return;
            }

            string correctAnswer = "";
            if (rbA.Checked) correctAnswer = "A";
            else if (rbB.Checked) correctAnswer = "B";
            else if (rbC.Checked) correctAnswer = "C";
            else if (rbD.Checked) correctAnswer = "D";
            else
            {
                MessageBox.Show("Please select the correct answer.");
                return;
            }

            Question q = new Question
            {
                QuestionText = txtQuestion.Text,
                AnswerA = txtAnswerA.Text,
                AnswerB = txtAnswerB.Text,
                AnswerC = txtAnswerC.Text,
                AnswerD = txtAnswerD.Text,
                CorrectAnswer = correctAnswer,
                Category = cmbCategory.Text,
                Difficulty = cmbDifficulty.Text,
                Type = cmbType.Text
            };
            SaveQuestionToExcel(q);
            questions.Add(q);

            ClearForm();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            if (questions.Count == 0)
            {
                MessageBox.Show("No questions have been added yet.");
                return;
            }

            string output = "";
            foreach (var q in questions)
            {
                output += $"Question: {q.QuestionText}\n" +
                          $"A: {q.AnswerA}\nB: {q.AnswerB}\nC: {q.AnswerC}\nD: {q.AnswerD}\n" +
                          $"Correct: {q.CorrectAnswer}\n" +
                          $"Type: {q.Type}, Category: {q.Category}, Difficulty: {q.Difficulty}\n\n";
            }

            MessageBox.Show(output, "Questions List");
        }

        private void ClearForm()
        {
            txtQuestion.Clear();
            txtAnswerA.Clear();
            txtAnswerB.Clear();
            txtAnswerC.Clear();
            txtAnswerD.Clear();
            rbA.Checked = rbB.Checked = rbC.Checked = rbD.Checked = false;
            cmbType.SelectedIndex = 0;
            cmbCategory.SelectedIndex = 0;
            cmbDifficulty.SelectedIndex = 0;
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cmbDifficulty_SelectedIndexChanged(object sender, EventArgs e) { }
        private void txtQuestion_TextChanged(object sender, EventArgs e) { }
        private void txtAnswerA_TextChanged(object sender, EventArgs e) { }
        private void txtAnswerB_TextChanged(object sender, EventArgs e) { }
        private void txtAnswerC_TextChanged(object sender, EventArgs e) { }
        private void txtAnswerD_TextChanged(object sender, EventArgs e) { }
        private void rbA_CheckedChanged(object sender, EventArgs e) { }
        private void rbB_CheckedChanged(object sender, EventArgs e) { }
        private void rbC_CheckedChanged(object sender, EventArgs e) { }
        private void rbD_CheckedChanged(object sender, EventArgs e) { }

        // 👇 Class inside the same file
        public class Question
        {
            public string QuestionText { get; set; }
            public string AnswerA { get; set; }
            public string AnswerB { get; set; }
            public string AnswerC { get; set; }
            public string AnswerD { get; set; }
            public string CorrectAnswer { get; set; }
            public string Category { get; set; }
            public string Difficulty { get; set; }
            public string Type { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LecturerAnalysisForm analysisForm = new LecturerAnalysisForm();
            analysisForm.Show();
            this.Hide();
        }
    }
}