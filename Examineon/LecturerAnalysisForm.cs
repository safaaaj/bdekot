using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using OfficeOpenXml;
using ScottPlot;
using ScottPlot.WinForms;

namespace Examineon
{
    public partial class LecturerAnalysisForm : Form
    {
        private List<StudentRecord> students;

        public LecturerAnalysisForm()
        {
            InitializeComponent();
            OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            btnFilterAboveAverage.Click += BtnFilterAboveAverage_Click;
            btnReset.Click += BtnReset_Click;
            dataGridView1.CellClick += DataGridView1_CellClick; // ✅ row click handler
        }

        private void LecturerAnalysisForm_Load(object sender, EventArgs e)
        {
            students = LoadStudentData();
            DisplayStudents(students);
            UpdateStatistics(students);
            ShowStudentScottPlot(students); // ✅ show full graph at startup
        }

        private List<StudentRecord> LoadStudentData()
        {
            var list = new List<StudentRecord>();
            var file = new FileInfo("DATABASE.xlsx");

            if (file.Exists)
            {
                using (var package = new ExcelPackage(file))
                {
                    var ws = package.Workbook.Worksheets["Users"];
                    if (ws != null)
                    {
                        int rowCount = ws.Dimension.End.Row;
                        int colCount = ws.Dimension.End.Column;

                        for (int row = 2; row <= rowCount; row++)
                        {
                            string role = ws.Cells[row, 5].Text.Trim().ToLower();
                            if (role == "student")
                            {
                                string name = ws.Cells[row, 1].Text.Trim();
                                var grades = new List<double>();

                                for (int col = 6; col <= colCount; col++)
                                {
                                    if (double.TryParse(ws.Cells[row, col].Text.Trim(), out double grade))
                                    {
                                        grades.Add(grade);
                                    }
                                }

                                list.Add(new StudentRecord { Name = name, Grades = grades });
                            }
                        }
                    }
                }
            }

            // If no students found, inject example data
            if (list.Count == 0)
            {
                list = new List<StudentRecord>
                {
                    new StudentRecord { Name = "Alice Johnson", Grades = new List<double>{85, 90, 88} },
                    new StudentRecord { Name = "Mohammed Saleh", Grades = new List<double>{92, 95, 93} },
                    new StudentRecord { Name = "Sara Cohen", Grades = new List<double>{76, 80, 78} },
                    new StudentRecord { Name = "Liam Smith", Grades = new List<double>{88, 85, 90} },
                    new StudentRecord { Name = "Chen Wei", Grades = new List<double>{95, 97, 96} }
                };
            }

            return list;
        }

        private void DisplayStudents(List<StudentRecord> list)
        {
            var displayList = list.Select(s => new
            {
                Name = s.Name,
                Grades = string.Join(", ", s.Grades),
                Average = s.Grades.Count > 0 ? s.Grades.Average().ToString("F2") : "N/A"
            }).ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = displayList;
        }

        private void UpdateStatistics(List<StudentRecord> list)
        {
            var allGrades = list.SelectMany(s => s.Grades).ToList();

            if (allGrades.Count == 0)
            {
                lblStats.Text = "No student data available.";
                return;
            }

            double average = allGrades.Average();
            double maxGrade = allGrades.Max();
            double minGrade = allGrades.Min();
            int totalGrades = allGrades.Count;

            lblStats.Text =
                $"Total Exams: {totalGrades}\n" +
                $"Global Average: {average:F2}\n" +
                $"Max Grade: {maxGrade}\n" +
                $"Min Grade: {minGrade}";
        }

        private void BtnFilterAboveAverage_Click(object sender, EventArgs e)
        {
            var allGrades = students.SelectMany(s => s.Grades).ToList();

            if (allGrades.Count == 0)
            {
                MessageBox.Show("No grades available to filter.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double globalAverage = allGrades.Average();

            var filtered = students
                .Where(s => s.Grades.Count > 0 && s.Grades.Average() >= globalAverage)
                .ToList();

            DisplayStudents(filtered);
            UpdateStatistics(filtered);
            ShowStudentScottPlot(filtered);
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            DisplayStudents(students);
            UpdateStatistics(students);
            ShowStudentScottPlot(students);
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string studentName = dataGridView1.Rows[e.RowIndex].Cells["Name"].Value.ToString();

                var student = students.FirstOrDefault(s => s.Name == studentName);

                if (student != null)
                {
                    ShowSingleStudentPlot(student);
                }
                else
                {
                    MessageBox.Show($"Student '{studentName}' not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void ShowSingleStudentPlot(StudentRecord student)
        {
            var plt = formsPlot1.Plot;
            plt.Clear();

            if (student.Grades.Count > 0)
            {
                double[] xs = Enumerable.Range(1, student.Grades.Count).Select(x => (double)x).ToArray();
                double[] ys = student.Grades.ToArray();

                var scatter = plt.Add.Scatter(xs, ys);
                scatter.Label = student.Name;
            }

            plt.Legend.IsVisible = true;
            plt.Title("Student Grades Over Exams");
            plt.XLabel("Exam Number");
            plt.YLabel("Grade");

            formsPlot1.Refresh();
        }

        private void ShowStudentScottPlot(List<StudentRecord> list)
        {
            var plt = formsPlot1.Plot;
            plt.Clear();

            foreach (var student in list)
            {
                if (student.Grades.Count == 0)
                    continue;

                double[] xs = Enumerable.Range(1, student.Grades.Count).Select(x => (double)x).ToArray();
                double[] ys = student.Grades.ToArray();

                var scatter = plt.Add.Scatter(xs, ys);
                scatter.Label = student.Name;
            }

            plt.Legend.IsVisible = true;
            plt.Title("Student Grades Over Exams");
            plt.XLabel("Exam Number");
            plt.YLabel("Grade");

            formsPlot1.Refresh();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm("lecturer");
            mainForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No forward action set. Returning to Main Page.");
            MainForm mainForm = new MainForm("lecturer");
            mainForm.Show();
            this.Hide();
        }


        public class StudentRecord
        {
            public string Name { get; set; }
            public List<double> Grades { get; set; } = new List<double>();
        }
    }
}
