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
        private System.Windows.Forms.DataVisualization.Charting.Chart chartScores;
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            ChartArea chartArea1 = new ChartArea();
            Title title1 = new Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentScoresForm));
            dgvHistory = new DataGridView();
            lblAverage = new Label();
            chartScores = new Chart();
            cmbFilterSubject = new ComboBox();
            lblFilter = new Label();
            btnBack = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartScores).BeginInit();
            SuspendLayout();
            // 
            // dgvHistory
            // 
            dgvHistory.AllowUserToAddRows = false;
            dgvHistory.AllowUserToDeleteRows = false;
            dgvHistory.BackgroundColor = Color.White;
            dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Honeydew;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvHistory.DefaultCellStyle = dataGridViewCellStyle1;
            dgvHistory.EnableHeadersVisualStyles = false;
            dgvHistory.GridColor = Color.DarkSeaGreen;
            dgvHistory.Location = new Point(101, 110);
            dgvHistory.Name = "dgvHistory";
            dgvHistory.ReadOnly = true;
            dgvHistory.RowHeadersWidth = 82;
            dgvHistory.Size = new Size(849, 263);
            dgvHistory.TabIndex = 0;
            // 
            // lblAverage
            // 
            lblAverage.AutoSize = true;
            lblAverage.BackColor = Color.Transparent;
            lblAverage.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            lblAverage.ForeColor = Color.DarkOliveGreen;
            lblAverage.Location = new Point(50, 440);
            lblAverage.Name = "lblAverage";
            lblAverage.Size = new Size(265, 42);
            lblAverage.TabIndex = 1;
            lblAverage.Text = "Average Score: --";
            // 
            // chartScores
            // 
            chartScores.BackColor = Color.Transparent;
            chartArea1.Name = "ChartArea1";
            chartScores.ChartAreas.Add(chartArea1);
            chartScores.Location = new Point(50, 500);
            chartScores.Name = "chartScores";
            chartScores.Palette = ChartColorPalette.Pastel;
            chartScores.Size = new Size(900, 250);
            chartScores.TabIndex = 2;
            title1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            title1.ForeColor = Color.DarkGreen;
            title1.Name = "Title1";
            title1.Text = "📊 Progress Over Time";
            chartScores.Titles.Add(title1);
            // 
            // cmbFilterSubject
            // 
            cmbFilterSubject.BackColor = Color.White;
            cmbFilterSubject.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilterSubject.Font = new Font("Sylfaen", 10F);
            cmbFilterSubject.ForeColor = Color.DarkGreen;
            cmbFilterSubject.FormattingEnabled = true;
            cmbFilterSubject.Items.AddRange(new object[] { "All", "Math", "English", "Hebrew" });
            cmbFilterSubject.Location = new Point(175, 37);
            cmbFilterSubject.Name = "cmbFilterSubject";
            cmbFilterSubject.Size = new Size(200, 43);
            cmbFilterSubject.TabIndex = 3;
            // 
            // lblFilter
            // 
            lblFilter.AutoSize = true;
            lblFilter.BackColor = Color.Transparent;
            lblFilter.Font = new Font("Sylfaen", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFilter.ForeColor = Color.DarkGreen;
            lblFilter.Location = new Point(50, 45);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(111, 35);
            lblFilter.TabIndex = 5;
            lblFilter.Text = "Subject:";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Sylfaen", 15F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.DarkGreen;
            btnBack.Location = new Point(12, 766);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(194, 101);
            btnBack.TabIndex = 11;
            btnBack.Text = "🔙 ";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.FlatAppearance.BorderColor = Color.DarkOliveGreen;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.Brown;
            btnExit.Location = new Point(839, 35);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 45);
            btnExit.TabIndex = 12;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // StudentScoresForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ChatGPT_Image_Jun_7__2025__02_04_37_AM;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1000, 1014);
            Controls.Add(btnExit);
            Controls.Add(btnBack);
            Controls.Add(dgvHistory);
            Controls.Add(lblAverage);
            Controls.Add(chartScores);
            Controls.Add(cmbFilterSubject);
            Controls.Add(lblFilter);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "StudentScoresForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "📈 Student Score History";
            Load += StudentScoresForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartScores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Button btnExit;
    }
}

