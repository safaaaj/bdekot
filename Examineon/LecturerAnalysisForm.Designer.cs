

namespace Examineon
{
    partial class LecturerAnalysisForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.Button btnFilterAboveAverage;
        private System.Windows.Forms.Button btnReset;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LecturerAnalysisForm));
            dataGridView1 = new DataGridView();
            lblStats = new Label();
            btnFilterAboveAverage = new Button();
            btnReset = new Button();
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            button1 = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.DarkSeaGreen;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Honeydew;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightGreen;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.GridColor = Color.DarkSeaGreen;
            dataGridView1.Location = new Point(96, 65);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.Size = new Size(600, 500);
            dataGridView1.TabIndex = 0;
            // 
            // lblStats
            // 
            lblStats.AutoSize = true;
            lblStats.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStats.ForeColor = Color.DarkGreen;
            lblStats.Location = new Point(37, 598);
            lblStats.Name = "lblStats";
            lblStats.Size = new Size(391, 37);
            lblStats.TabIndex = 1;
            lblStats.Text = "📈 Statistics will appear here";
            // 
            // btnFilterAboveAverage
            // 
            btnFilterAboveAverage.BackColor = Color.MediumSeaGreen;
            btnFilterAboveAverage.FlatAppearance.BorderSize = 0;
            btnFilterAboveAverage.FlatStyle = FlatStyle.Flat;
            btnFilterAboveAverage.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFilterAboveAverage.ForeColor = Color.White;
            btnFilterAboveAverage.Location = new Point(37, 857);
            btnFilterAboveAverage.Name = "btnFilterAboveAverage";
            btnFilterAboveAverage.Size = new Size(293, 50);
            btnFilterAboveAverage.TabIndex = 2;
            btnFilterAboveAverage.Text = "📊Show Above Average";
            btnFilterAboveAverage.UseVisualStyleBackColor = false;
            btnFilterAboveAverage.Click += BtnFilterAboveAverage_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.SeaGreen;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Sylfaen", 10.125F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(370, 856);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(205, 50);
            btnReset.TabIndex = 3;
            btnReset.Text = "♻️Reset View";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += BtnReset_Click;
            // 
            // formsPlot1
            // 
            formsPlot1.BackColor = Color.DarkSeaGreen;
            formsPlot1.DisplayScale = 2F;
            formsPlot1.Location = new Point(758, 345);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(950, 600);
            formsPlot1.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(37, 945);
            button1.Name = "button1";
            button1.Size = new Size(88, 70);
            button1.TabIndex = 5;
            button1.Text = "←";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.DarkSeaGreen;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.DarkSlateGray;
            btnExit.Location = new Point(821, 165);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(140, 82);
            btnExit.TabIndex = 22;
            btnExit.Text = "❌ Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // LecturerAnalysisForm
            // 
            BackColor = Color.Honeydew;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1753, 1018);
            Controls.Add(btnExit);
            Controls.Add(dataGridView1);
            Controls.Add(lblStats);
            Controls.Add(btnFilterAboveAverage);
            Controls.Add(btnReset);
            Controls.Add(formsPlot1);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LecturerAnalysisForm";
            Text = "📊 Student Grades Analysis";
            Load += LecturerAnalysisForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private Button button1;
        private Button btnExit;
    }

}
