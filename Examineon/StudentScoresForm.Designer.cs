using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Examineon
{
    partial class StudentScoresForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvHistory;
        private Label lblAverage;
        private Chart chartScores;
        private Button btnExport;
        private ComboBox cmbFilterSubject;
        private Label lblFilter;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            ChartArea chartArea2 = new ChartArea();
            Title title2 = new Title();
            dgvHistory = new DataGridView();
            lblAverage = new Label();
            chartScores = new Chart();
            btnExport = new Button();
            cmbFilterSubject = new ComboBox();
            lblFilter = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartScores).BeginInit();
            SuspendLayout();
            // 
            // dgvHistory
            // 
            dgvHistory.AllowUserToAddRows = false;
            dgvHistory.AllowUserToDeleteRows = false;
            dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistory.Location = new Point(30, 100);
            dgvHistory.Name = "dgvHistory";
            dgvHistory.ReadOnly = true;
            dgvHistory.RowHeadersWidth = 82;
            dgvHistory.Size = new Size(900, 300);
            dgvHistory.TabIndex = 0;
            // 
            // lblAverage
            // 
            lblAverage.AutoSize = true;
            lblAverage.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAverage.Location = new Point(30, 420);
            lblAverage.Name = "lblAverage";
            lblAverage.Size = new Size(279, 45);
            lblAverage.TabIndex = 1;
            lblAverage.Text = "Average Score: --";
            // 
            // chartScores
            // 
            chartArea2.Name = "ChartArea1";
            chartScores.ChartAreas.Add(chartArea2);
            chartScores.Location = new Point(30, 480);
            chartScores.Name = "chartScores";
            chartScores.Size = new Size(900, 250);
            chartScores.TabIndex = 2;
            title2.Name = "Title1";
            title2.Text = "Progress Over Time";
            chartScores.Titles.Add(title2);
            // 
            // btnExport
            // 
            btnExport.Location = new Point(780, 30);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(150, 40);
            btnExport.TabIndex = 3;
            btnExport.Text = "Export to Excel";
            btnExport.UseVisualStyleBackColor = true;
            // 
            // cmbFilterSubject
            // 
            cmbFilterSubject.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilterSubject.FormattingEnabled = true;
            cmbFilterSubject.Items.AddRange(new object[] { "All", "Math", "English", "Hebrew" });
            cmbFilterSubject.Location = new Point(130, 35);
            cmbFilterSubject.Name = "cmbFilterSubject";
            cmbFilterSubject.Size = new Size(200, 40);
            cmbFilterSubject.TabIndex = 4;
            // 
            // lblFilter
            // 
            lblFilter.AutoSize = true;
            lblFilter.Location = new Point(30, 40);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(98, 32);
            lblFilter.TabIndex = 5;
            lblFilter.Text = "Subject:";
            // 
            // StudentScoresForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 760);
            Controls.Add(dgvHistory);
            Controls.Add(lblAverage);
            Controls.Add(chartScores);
            Controls.Add(btnExport);
            Controls.Add(cmbFilterSubject);
            Controls.Add(lblFilter);
            Name = "StudentScoresForm";
            Text = "Student Score History";
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartScores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
