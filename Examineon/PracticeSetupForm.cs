using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;

namespace Examineon
{
    public partial class PracticeSetupForm : Form
    {
        private string studentId; private string role;
        public PracticeSetupForm()
        {
            
            InitializeComponent();
            cmbPracticeSubject.Items.AddRange(new string[] { "English", "Math", "Hebrew" });
            cmbPracticeDifficulty.Items.AddRange(new string[] { "Easy", "Medium", "Hard" });

            cmbPracticeSubject.SelectedIndex = 0;
            cmbPracticeDifficulty.SelectedIndex = 0;


            btnExit.Click += btnExit_Click;

            CreateDummyExamSheet();
            LoadStudentScores();
        }
        private void CreateDummyExamSheet()
        {
            // ... your full method body here ...
        }

        private void LoadStudentScores()
        {
            // ... your full method body here ...
        }
        private void PracticeSetupForm_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e) { }

        private void cmbPracticeSubject_SelectedIndexChanged(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }

        private void cmbPracticeDifficulty_SelectedIndexChanged(object sender, EventArgs e) { }


        private void btnStartPractice_Click(object sender, EventArgs e)
        {
            string subject = cmbPracticeSubject.Text.Trim();
            string difficulty = cmbPracticeDifficulty.Text.Trim();

            List<Question> questions = LoadQuestionsFromExcel(subject, difficulty);

            if (questions.Count == 0)
            {
                MessageBox.Show("No questions found for this selection.");
                return;
            }

            // ✅ Only construct if questions are found
            PracticeExamForm examForm = new PracticeExamForm(subject, difficulty, questions);
            examForm.Show();
            this.Hide();
        }


        private List<Question> LoadQuestionsFromExcel(string subject, string difficulty)
        {
            List<Question> result = new List<Question>();
            string filePath = "DATABASE.xlsx";

            FileInfo file = new FileInfo(filePath);
            if (!file.Exists)
            {
                MessageBox.Show("Database file not found.");
                return result;
            }

            using (var package = new ExcelPackage(file))
            {
                var worksheet = package.Workbook.Worksheets["Questions"];
                if (worksheet == null || worksheet.Dimension == null)
                {
                    MessageBox.Show("Questions sheet not found.");
                    return result;
                }

                int rowCount = worksheet.Dimension.End.Row;

                for (int row = 2; row <= rowCount; row++)
                {
                    string fileSubject = worksheet.Cells[row, 7].Text.Trim();       // Category
                    string fileDifficulty = worksheet.Cells[row, 8].Text.Trim();    // Difficulty

                    if (fileSubject.Equals(subject, StringComparison.OrdinalIgnoreCase) &&
                        fileDifficulty.Equals(difficulty, StringComparison.OrdinalIgnoreCase))
                    {
                        Question q = new Question
                        {
                            QuestionText = worksheet.Cells[row, 1].Text.Trim(),
                            AnswerA = worksheet.Cells[row, 2].Text.Trim(),
                            AnswerB = worksheet.Cells[row, 3].Text.Trim(),
                            AnswerC = worksheet.Cells[row, 4].Text.Trim(),
                            AnswerD = worksheet.Cells[row, 5].Text.Trim(),
                            CorrectAnswer = worksheet.Cells[row, 6].Text.Trim(),
                            Category = fileSubject,
                            Difficulty = fileDifficulty,
                            Type = worksheet.Cells[row, 9].Text.Trim()
                        };

                        result.Add(q);
                    }
                }
            }

            return result;
        }

        private void btnGenerateDummy_Click(object sender, EventArgs e)
        {
            CreateDummyExamSheet();
            LoadStudentScores();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SecondaryForm secondaryForm = new SecondaryForm(role, studentId);
            secondaryForm.Show();
            this.Show();
            this.Hide();

            
        }
    }
}
