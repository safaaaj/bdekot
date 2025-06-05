using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Examineon
{
    public partial class ExamSetup : Form
    {
        private string studentId;

        public ExamSetup(string studentId)
        {
            InitializeComponent();
            this.studentId = studentId;

            cmbPracticeSubject.Items.AddRange(new string[] { "English", "Math", "Hebrew" });
            cmbPracticeDifficulty.Items.AddRange(new string[] { "Easy", "Medium", "Hard" });

            cmbPracticeSubject.SelectedIndex = 0;
            cmbPracticeDifficulty.SelectedIndex = 0;

            btnStartPractice.Click += btnStartPractice_Click;
            btnExit.Click += btnExit_Click;
        }

        private void ExamSetup_Load(object sender, EventArgs e)
        {
            // your initialization code
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStartPractice_Click(object sender, EventArgs e)
        {
            string subject = cmbPracticeSubject.Text.Trim();
            string difficulty = cmbPracticeDifficulty.Text.Trim();

            string selectedExamId = FindMatchingExamId(subject, difficulty);

            if (string.IsNullOrEmpty(selectedExamId))
            {
                MessageBox.Show("No exam found for this subject and difficulty.");
                return;
            }

            TestForm test = new TestForm(studentId, selectedExamId);
            test.Show();
            this.Hide();
        }

        private string FindMatchingExamId(string subject, string difficulty)
        {
            var file = new FileInfo("DATABASE.xlsx");

            using (var package = new ExcelPackage(file))
            {
                var ws = package.Workbook.Worksheets["Exam"];
                if (ws == null || ws.Dimension == null)
                    return null;

                int rowCount = ws.Dimension.End.Row;
                for (int row = 2; row <= rowCount; row++)
                {
                    string cat = ws.Cells[row, 10].Text.Trim(); // Category
                    string diff = ws.Cells[row, 11].Text.Trim(); // Difficulty
                    string examId = ws.Cells[row, 1].Text.Trim(); // ExamID

                    if (cat.Equals(subject, StringComparison.OrdinalIgnoreCase) &&
                        diff.Equals(difficulty, StringComparison.OrdinalIgnoreCase))
                    {
                        return examId;
                    }
                }
            }

            return null;
        }
    }
}
