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

        public StudentScoresForm(string studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            LoadStudentScores();
        }

        private void LoadStudentScores()
        {
            var file = new FileInfo("DATABASE.xlsx");
            var scores = new List<(DateTime Date, double Score)>();

            using (var package = new ExcelPackage(file))
            {
                var ws = package.Workbook.Worksheets["StudentEH"];
                if (ws == null || ws.Dimension == null) return;

                var table = new DataTable();
                table.Columns.Add("Date");
                table.Columns.Add("Exam ID");
                table.Columns.Add("Score");

                int rowCount = ws.Dimension.End.Row;
                for (int row = 2; row <= rowCount; row++)
                {
                    string sid = ws.Cells[row, 13].Text;
                    if (sid != studentId) continue;

                    string date = ws.Cells[row, 2].Text;
                    string examId = ws.Cells[row, 1].Text;
                    string scoreStr = ws.Cells[row, 15].Text;

                    if (double.TryParse(scoreStr, out double score) && DateTime.TryParse(date, out DateTime dt))
                    {
                        scores.Add((dt, score));
                        table.Rows.Add(dt.ToShortDateString(), examId, score.ToString("F2"));
                    }
                }

                dgvHistory.DataSource = table;

                if (scores.Any())
                {
                    double avg = scores.Average(s => s.Score);
                    lblAverage.Text = $"Average Score: {avg:F2}%";

                    chartScores.Series.Clear();
                    var series = new Series("Progress")
                    {
                        ChartType = SeriesChartType.Line,
                        BorderWidth = 3,
                        Color = Color.SteelBlue
                    };
                    foreach (var s in scores.OrderBy(s => s.Date))
                    {
                        series.Points.AddXY(s.Date.ToShortDateString(), s.Score);
                    }
                    chartScores.Series.Add(series);
                }
                else
                {
                    lblAverage.Text = "No scores available.";
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel Files|*.xlsx",
                Title = "Save Score History"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var filePath = saveFileDialog.FileName;

                using (var package = new ExcelPackage())
                {
                    var ws = package.Workbook.Worksheets.Add("ExportedScores");
                    ws.Cells[1, 1].Value = "Date";
                    ws.Cells[1, 2].Value = "Exam ID";
                    ws.Cells[1, 3].Value = "Score";

                    for (int i = 0; i < dgvHistory.Rows.Count; i++)
                    {
                        ws.Cells[i + 2, 1].Value = dgvHistory.Rows[i].Cells[0].Value?.ToString();
                        ws.Cells[i + 2, 2].Value = dgvHistory.Rows[i].Cells[1].Value?.ToString();
                        ws.Cells[i + 2, 3].Value = dgvHistory.Rows[i].Cells[2].Value?.ToString();
                    }

                    File.WriteAllBytes(filePath, package.GetAsByteArray());
                    MessageBox.Show("Export successful!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
