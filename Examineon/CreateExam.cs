// ✅ FULL UPDATED BACKEND FOR CREATEEXAM FORM

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using OfficeOpenXml;

namespace Examineon
{
    public partial class CreateExam : Form
    {
        private List<Question> availableQuestions = new List<Question>();
        private List<string> existingExamQuestions = new List<string>();

        public CreateExam()
        {
            InitializeComponent();
            OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            LoadQuestionsFromDatabase();
            LoadExistingExams();
        }

        private void LoadQuestionsFromDatabase()
        {
            availableQuestions.Clear();
            var file = new FileInfo("DATABASE.xlsx");

            using (var package = new ExcelPackage(file))
            {
                var ws = package.Workbook.Worksheets.FirstOrDefault(w => w.Name == "Questions");
                if (ws == null)
                {
                    MessageBox.Show("No Questions sheet found.");
                    return;
                }

                int rowCount = ws.Dimension.End.Row;
                for (int row = 2; row <= rowCount; row++)
                {
                    availableQuestions.Add(new Question
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

            dgvAvailableQuestions.DataSource = null;
            dgvAvailableQuestions.DataSource = availableQuestions;
        }
        private void CreateExam_Load(object sender, EventArgs e)
        {
           
            CompareQuestionsWithExams();
        }


        private void LoadExistingExams()
        {
            existingExamQuestions.Clear();
            var file = new FileInfo("DATABASE.xlsx");

            using (var package = new ExcelPackage(file))
            {
                var ws = package.Workbook.Worksheets.FirstOrDefault(w => w.Name == "Exam");
                if (ws != null)
                {
                    int rowCount = ws.Dimension.End.Row;
                    for (int row = 2; row <= rowCount; row++)
                    {
                        string qText = ws.Cells[row, 4].Text;
                        if (!existingExamQuestions.Contains(qText))
                        {
                            existingExamQuestions.Add(qText);
                        }
                    }
                }
            }
        }

        private void btnCreateExam_Click(object sender, EventArgs e)
        {
            int requestedCount = (int)nudNumQuestions.Value;
            string selectedDifficulty = cmbDifficulty.SelectedItem?.ToString();
            var selectedCategories = clbTopics.CheckedItems.Cast<string>().ToList();

            List<Question> filteredQuestions;

            if (chkRandomTopics.Checked)
            {
                // ✅ Random topics, but still filter by difficulty
                filteredQuestions = availableQuestions
                    .Where(q => string.IsNullOrEmpty(selectedDifficulty) || q.Difficulty == selectedDifficulty)
                    .ToList();
            }
            else
            {
                // ✅ Filter by both category and difficulty
                filteredQuestions = availableQuestions
                    .Where(q =>
                        (selectedCategories.Count == 0 || selectedCategories.Contains(q.Category)) &&
                        (string.IsNullOrEmpty(selectedDifficulty) || q.Difficulty == selectedDifficulty))
                    .ToList();
            }

            if (filteredQuestions.Count < requestedCount)
            {
                MessageBox.Show(
                    $"Not enough questions found matching the selected filters.\n" +
                    $"Requested: {requestedCount}, Available: {filteredQuestions.Count}",
                    "Insufficient Questions",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            var selectedQuestions = filteredQuestions
                .OrderBy(q => Guid.NewGuid()) // shuffle
                .Take(requestedCount)
                .ToList();

            // Save to database
            SaveExamToDatabase(selectedQuestions);
            LoadExistingExams();
            DisplayExamInGrid(selectedQuestions);

        }

        private void DisplayExamInGrid(List<Question> questions)
        {
            var displayList = questions.Select((q, index) => new
            {
                Number = index + 1,
                Question = q.QuestionText,
                AnswerA = q.AnswerA,
                AnswerB = q.AnswerB,
                AnswerC = q.AnswerC,
                AnswerD = q.AnswerD
            }).ToList();

            dgvExams.DataSource = null;
            dgvExams.DataSource = displayList;

            dgvExams.Columns["Number"].HeaderText = "Question #";
            dgvExams.Columns["Question"].HeaderText = "Question Text";
            dgvExams.Columns["AnswerA"].HeaderText = "A";
            dgvExams.Columns["AnswerB"].HeaderText = "B";
            dgvExams.Columns["AnswerC"].HeaderText = "C";
            dgvExams.Columns["AnswerD"].HeaderText = "D";
        }



        private void SaveExamToDatabase(List<Question> selectedQuestions)
        {
            var file = new FileInfo("DATABASE.xlsx");

            using (var package = new ExcelPackage(file))
            {
                var ws = package.Workbook.Worksheets.FirstOrDefault(w => w.Name == "Exam")
                         ?? package.Workbook.Worksheets.Add("Exam");

                if (ws.Dimension == null)
                {
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
                }

                string examId = Guid.NewGuid().ToString();
                string createdAt = DateTime.Now.ToString("g");
                int numberOfQuestions = selectedQuestions.Count;
                int rowStart = ws.Dimension.End.Row + 1;

                for (int i = 0; i < selectedQuestions.Count; i++)
                {
                    var q = selectedQuestions[i];

                    // Only put ExamID, CreatedAt, NumberOfQuestions in the first row
                    ws.Cells[rowStart, 1].Value = (i == 0) ? examId : "";
                    ws.Cells[rowStart, 2].Value = (i == 0) ? createdAt : "";
                    ws.Cells[rowStart, 3].Value = (i == 0) ? numberOfQuestions : "";

                    ws.Cells[rowStart, 4].Value = q.QuestionText;
                    ws.Cells[rowStart, 5].Value = q.AnswerA;
                    ws.Cells[rowStart, 6].Value = q.AnswerB;
                    ws.Cells[rowStart, 7].Value = q.AnswerC;
                    ws.Cells[rowStart, 8].Value = q.AnswerD;
                    ws.Cells[rowStart, 9].Value = q.CorrectAnswer;
                    ws.Cells[rowStart, 10].Value = q.Category;
                    ws.Cells[rowStart, 11].Value = q.Difficulty;
                    ws.Cells[rowStart, 12].Value = q.Type;

                    rowStart++;
                }

                package.Save();
            }

            MessageBox.Show($"Exam saved with {selectedQuestions.Count} questions!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void CompareQuestionsWithExams()
        {
            var duplicateQuestions = availableQuestions
                .Where(q => existingExamQuestions.Contains(q.QuestionText))
                .ToList();

            if (duplicateQuestions.Any())
            {
                string duplicates = string.Join("\n", duplicateQuestions.Select(q => q.QuestionText));
                MessageBox.Show($"These questions already exist in previous exams:\n{duplicates}", "Duplicates", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No duplicate questions found.", "Check Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm("lecturer");
            mainForm.Show();
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 createQuestion = new Form1();
            createQuestion.Show();
            this.Hide();
        }

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
    }
}
