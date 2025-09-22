using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using OfficeOpenXml;
using System.Windows.Forms.DataVisualization.Charting;

namespace Examineon
{
    public partial class StudentScoresForm : Form
    {

        private string studentId;
        private string role;

        private List<(DateTime Date, double Score, string Subject, string ExamId)> allScores =
            new List<(DateTime, double, string, string)>();

        public StudentScoresForm(string studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            cmbFilterSubject.SelectedIndexChanged += (s, e) =>
            {
                ApplySubjectFilter(cmbFilterSubject.SelectedItem?.ToString() ?? "All");
            };
            LoadStudentScores();
        }

        private void LoadStudentScores()
        {
            var file = new FileInfo("DATABASE.xlsx");

            using (var package = new ExcelPackage(file))
            {
                var ws = package.Workbook.Worksheets["StudentEH"];
                if (ws == null || ws.Dimension == null) return;

                allScores.Clear();
                int rowCount = ws.Dimension.End.Row;

                for (int row = 2; row <= rowCount; row++)
                {
                    string sid = ws.Cells[row, 13].Text;
                    if (sid != studentId) continue;

                    string dateStr = ws.Cells[row, 2].Text;
                    string scoreStr = ws.Cells[row, 15].Text;
                    string subject = ws.Cells[row, 10].Text;
                    string examId = ws.Cells[row, 1].Text;

                    if (double.TryParse(scoreStr, out double score) && DateTime.TryParse(dateStr, out DateTime dt))
                    {
                        allScores.Add((dt, score, subject, examId));
                    }
                }
            }

            ApplySubjectFilter("All");
        }

        private void ApplySubjectFilter(string selectedSubject)
        {
            var filtered = selectedSubject == "All"
                ? allScores
                : allScores.Where(s => s.Subject.Equals(selectedSubject, StringComparison.OrdinalIgnoreCase)).ToList();

            // Update DataGridView
            var table = new DataTable();
            table.Columns.Add("Date");
            table.Columns.Add("Exam ID");
            table.Columns.Add("Score");

            foreach (var s in filtered)
            {
                table.Rows.Add(s.Date.ToShortDateString(), s.ExamId, s.Score.ToString("F2"));
            }

            dgvHistory.DataSource = table;

            // Update Chart
            chartScores.Series.Clear();
            chartScores.ChartAreas.Clear();
            chartScores.Titles.Clear();

            if (filtered.Any())
            {
                double avg = filtered.Average(s => s.Score);
                lblAverage.Text = $"Average Score: {avg:F2}%";

                var chartArea = new ChartArea("MainArea");
                chartArea.AxisX.Title = "Date";
                chartArea.AxisX.LabelStyle.Format = "dd/MM";
                chartArea.AxisX.LabelStyle.Angle = -45;
                chartArea.AxisX.MajorGrid.LineColor = Color.LightGray;
                chartArea.AxisY.Title = "Score (%)";
                chartArea.AxisY.Minimum = 0;
                chartArea.AxisY.Maximum = 100;
                chartArea.AxisY.Interval = 10;
                chartArea.AxisY.MajorGrid.LineColor = Color.LightGray;

                chartScores.ChartAreas.Add(chartArea);

                var series = new Series("Progress")
                {
                    ChartType = SeriesChartType.Line,
                    BorderWidth = 3,
                    Color = Color.MediumSeaGreen,
                    XValueType = ChartValueType.DateTime,
                    MarkerStyle = MarkerStyle.Circle,
                    MarkerSize = 8,
                    MarkerColor = Color.DarkGreen
                };

                foreach (var s in filtered.OrderBy(s => s.Date))
                {
                    series.Points.AddXY(s.Date, s.Score);
                }

                chartScores.Series.Add(series);
                chartScores.Titles.Add("Exam Score Progress");
            }
            else
            {
                lblAverage.Text = "No scores available.";
            }
        }

        private void StudentScoresForm_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SecondaryForm secondaryForm = new SecondaryForm(role, studentId);
            secondaryForm.Show();
            this.Show(); this.Hide();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
