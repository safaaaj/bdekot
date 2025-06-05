using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using System.IO;


namespace Examineon
{
    public partial class Form1 : Form
    {
        private List<Question> questions = new List<Question>();

        [Obsolete]
        public Form1()
        {
            InitializeComponent();
            btnAdd.Click += btnAdd_Click;
            btnClear.Click += btnClear_Click;
            btnDisplay.Click += btnDisplay_Click;
            btnEdit.Click += btnEdit_Click;
            btnDelete.Click += btnDelete_Click;
            btnExit.Click += btnExit_Click;
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;


        }

        private void SaveQuestionToExcel(Question q)
        {
            var file = new FileInfo("DATABASE.xlsx");


            using (var package = new ExcelPackage(file))
            {
                var sheet = package.Workbook.Worksheets.FirstOrDefault(ws => ws.Name == "Questions");
                if (sheet == null)
                {
                    sheet = package.Workbook.Worksheets.Add("Questions");

                    sheet.Cells[1, 1].Value = "QuestionText";
                    sheet.Cells[1, 2].Value = "AnswerA";
                    sheet.Cells[1, 3].Value = "AnswerB";
                    sheet.Cells[1, 4].Value = "AnswerC";
                    sheet.Cells[1, 5].Value = "AnswerD";
                    sheet.Cells[1, 6].Value = "CorrectAnswer";
                    sheet.Cells[1, 7].Value = "Category";
                    sheet.Cells[1, 8].Value = "Difficulty";
                    sheet.Cells[1, 9].Value = "Type";

                    sheet.Row(1).Style.Font.Bold = true;
                }

                int newRow = sheet.Dimension?.End.Row + 1 ?? 2;

                sheet.Cells[newRow, 1].Value = q.QuestionText;
                sheet.Cells[newRow, 2].Value = q.AnswerA;
                sheet.Cells[newRow, 3].Value = q.AnswerB;
                sheet.Cells[newRow, 4].Value = q.AnswerC;
                sheet.Cells[newRow, 5].Value = q.AnswerD;
                sheet.Cells[newRow, 6].Value = q.CorrectAnswer;
                sheet.Cells[newRow, 7].Value = q.Category;
                sheet.Cells[newRow, 8].Value = q.Difficulty;
                sheet.Cells[newRow, 9].Value = q.Type;

                package.Save();
            }

            MessageBox.Show("Question saved successfully!");
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

            string questionType = cmbType.SelectedItem?.ToString().ToLower();

            if (string.IsNullOrWhiteSpace(txtQuestion.Text) ||
                string.IsNullOrWhiteSpace(txtAnswerA.Text) ||
                string.IsNullOrWhiteSpace(txtAnswerB.Text))
            {
                MessageBox.Show("Please fill in all question and answer fields.");
                return;
            }
            if (lstQuestions.Items.Contains(txtQuestion.Text.Trim()))
            {
                MessageBox.Show("This question already exists in the list!");
                return;
            }


            if (questionType != "true/false" && (string.IsNullOrWhiteSpace(txtAnswerC.Text) || string.IsNullOrWhiteSpace(txtAnswerD.Text)))
            {
                MessageBox.Show("Please fill in all question and answer fields.");
                return;
            }

            // Get the correct answer
            string correctAnswer = "";
            if (rbA.Checked) correctAnswer = "A";
            else if (rbB.Checked) correctAnswer = "B";
            else if (rbC.Checked && questionType != "true/false") correctAnswer = "C";
            else if (rbD.Checked && questionType != "true/false") correctAnswer = "D";
            else
            {
                MessageBox.Show("Please select the correct answer.");
                return;
            }

            // Create the question
            Question q = new Question
            {
                QuestionText = txtQuestion.Text.Trim(),
                AnswerA = txtAnswerA.Text.Trim(),
                AnswerB = txtAnswerB.Text.Trim(),
                AnswerC = (questionType != "true/false") ? txtAnswerC.Text.Trim() : "",
                AnswerD = (questionType != "true/false") ? txtAnswerD.Text.Trim() : "",
                CorrectAnswer = correctAnswer.Trim(),
                Category = cmbCategory.Text.Trim(),
                Difficulty = cmbDifficulty.Text.Trim(),
                Type = cmbType.Text.Trim()
            };

            questions.Add(q);
            SaveQuestionToExcel(q);  // 📝 Save to Excel!
            MessageBox.Show("Question added successfully!");

            ClearForm();
        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            lstQuestions.Items.Clear();

            var file = new FileInfo("DATABASE.xlsx");
            if (!file.Exists)
            {
                MessageBox.Show("No data found.");
                return;
            }

            using (var package = new ExcelPackage(file))
            {
                var sheet = package.Workbook.Worksheets["Questions"];
                if (sheet == null || sheet.Dimension == null)
                {
                    MessageBox.Show("No data found.");
                    return;
                }

                for (int row = 2; row <= sheet.Dimension.End.Row; row++)
                {
                    lstQuestions.Items.Add(sheet.Cells[row, 1].Text); // QuestionText
                }
            }
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

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedType = cmbType.SelectedItem.ToString().ToLower();

            if (selectedType == "true/false")
            {
                // Auto-fill True/False answers
                txtAnswerA.Text = "True";
                txtAnswerB.Text = "False";
                txtAnswerA.ReadOnly = true;
                txtAnswerB.ReadOnly = true;

                // Disable C and D
                txtAnswerC.Text = "";
                txtAnswerD.Text = "";
                txtAnswerC.Enabled = false;
                txtAnswerD.Enabled = false;

                // Disable C and D radio buttons
                rbC.Enabled = false;
                rbD.Enabled = false;
            }
            else
            {
                // Enable all fields
                txtAnswerA.Text = "";
                txtAnswerB.Text = "";
                txtAnswerA.ReadOnly = false;
                txtAnswerB.ReadOnly = false;

                txtAnswerC.Enabled = true;
                txtAnswerD.Enabled = true;

                rbC.Enabled = true;
                rbD.Enabled = true;
            }
        }


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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstQuestions.SelectedItem == null)
            {
                MessageBox.Show("Please select a question from the list to edit.");
                return;
            }

            string selectedQuestion = lstQuestions.SelectedItem.ToString();
            var file = new FileInfo("DATABASE.xlsx");

            if (!file.Exists)
            {
                MessageBox.Show("Excel file not found.");
                return;
            }

            using (var package = new ExcelPackage(file))
            {
                var sheet = package.Workbook.Worksheets["Questions"];
                if (sheet == null)
                {
                    MessageBox.Show("No questions found in Excel.");
                    return;
                }

                bool found = false;
                for (int row = 2; row <= sheet.Dimension.End.Row; row++)
                {
                    string existingQuestion = sheet.Cells[row, 1].Text.Trim();
                    if (existingQuestion.Equals(selectedQuestion, StringComparison.OrdinalIgnoreCase))
                    {
                        sheet.Cells[row, 1].Value = txtQuestion.Text;
                        sheet.Cells[row, 2].Value = txtAnswerA.Text;
                        sheet.Cells[row, 3].Value = txtAnswerB.Text;
                        sheet.Cells[row, 4].Value = txtAnswerC.Text;
                        sheet.Cells[row, 5].Value = txtAnswerD.Text;
                        sheet.Cells[row, 6].Value = (rbA.Checked ? "A" : rbB.Checked ? "B" : rbC.Checked ? "C" : rbD.Checked ? "D" : "");
                        sheet.Cells[row, 7].Value = cmbCategory.Text;
                        sheet.Cells[row, 8].Value = cmbDifficulty.Text;
                        sheet.Cells[row, 9].Value = cmbType.Text;

                        found = true;
                        break;
                    }
                }

                if (found)
                {
                    package.Save();

                    // Update ListBox text
                    int index = lstQuestions.SelectedIndex;
                    lstQuestions.Items[index] = txtQuestion.Text;

                    MessageBox.Show("✅ Question updated successfully!");
                }
                else
                {
                    MessageBox.Show("❌ Question not found in Excel.");
                }
            }
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstQuestions.SelectedItem == null)
            {
                MessageBox.Show("Please select a question from the list to delete.");
                return;
            }

            string selectedQuestion = lstQuestions.SelectedItem.ToString();
            var file = new FileInfo("DATABASE.xlsx");

            if (!file.Exists)
            {
                MessageBox.Show("Excel file not found.");
                return;
            }

            using (var package = new ExcelPackage(file))
            {
                var sheet = package.Workbook.Worksheets["Questions"];
                if (sheet == null || sheet.Dimension == null)
                {
                    MessageBox.Show("No questions found in Excel.");
                    return;
                }

                bool found = false;
                for (int row = 2; row <= sheet.Dimension.End.Row; row++)
                {
                    if (sheet.Cells[row, 1].Text.Trim().Equals(selectedQuestion, StringComparison.OrdinalIgnoreCase))
                    {
                        sheet.DeleteRow(row);
                        found = true;
                        break;
                    }
                }

                if (found)
                {
                    package.Save();
                    lstQuestions.Items.Remove(selectedQuestion); // Remove from the ListBox
                    ClearForm(); // Clear form fields
                    MessageBox.Show("✅ Question deleted successfully!");
                }
                else
                {
                    MessageBox.Show("❌ Question not found in Excel.");
                }
            }
        }



        private void lstQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstQuestions.SelectedItem == null) return;

            string selectedQuestion = lstQuestions.SelectedItem.ToString();
            var file = new FileInfo("DATABASE.xlsx");

            using (var package = new ExcelPackage(file))
            {
                var sheet = package.Workbook.Worksheets["Questions"];
                if (sheet == null) return;

                for (int row = 2; row <= sheet.Dimension.End.Row; row++)
                {
                    if (sheet.Cells[row, 1].Text.Trim().Equals(selectedQuestion, StringComparison.OrdinalIgnoreCase))
                    {
                        txtQuestion.Text = sheet.Cells[row, 1].Text;
                        txtAnswerA.Text = sheet.Cells[row, 2].Text;
                        txtAnswerB.Text = sheet.Cells[row, 3].Text;
                        txtAnswerC.Text = sheet.Cells[row, 4].Text;
                        txtAnswerD.Text = sheet.Cells[row, 5].Text;

                        string correct = sheet.Cells[row, 6].Text.Trim();
                        rbA.Checked = correct == "A";
                        rbB.Checked = correct == "B";
                        rbC.Checked = correct == "C";
                        rbD.Checked = correct == "D";

                        cmbCategory.Text = sheet.Cells[row, 7].Text;
                        cmbDifficulty.Text = sheet.Cells[row, 8].Text;
                        cmbType.Text = sheet.Cells[row, 9].Text;

                        break;
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
          //  LecturerAnalysisForm analysisForm = new LecturerAnalysisForm();
            //analysisForm.Show();
            //this.Hide();
  //      }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
