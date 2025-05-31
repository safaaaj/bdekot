

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
            dataGridView1 = new DataGridView();
            lblStats = new Label();
            btnFilterAboveAverage = new Button();
            btnReset = new Button();
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(43, 75);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.Size = new Size(544, 445);
            dataGridView1.TabIndex = 0;
            // 
            // lblStats
            // 
            lblStats.AutoSize = true;
            lblStats.Font = new Font("Segoe UI", 10F);
            lblStats.Location = new Point(43, 564);
            lblStats.Margin = new Padding(4, 0, 4, 0);
            lblStats.Name = "lblStats";
            lblStats.Size = new Size(316, 37);
            lblStats.TabIndex = 1;
            lblStats.Text = "Statistics will appear here";
            // 
            // btnFilterAboveAverage
            // 
            btnFilterAboveAverage.Location = new Point(139, 746);
            btnFilterAboveAverage.Margin = new Padding(4);
            btnFilterAboveAverage.Name = "btnFilterAboveAverage";
            btnFilterAboveAverage.Size = new Size(260, 51);
            btnFilterAboveAverage.TabIndex = 2;
            btnFilterAboveAverage.Text = "Show Above Average";
            btnFilterAboveAverage.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(438, 746);
            btnReset.Margin = new Padding(4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(195, 51);
            btnReset.TabIndex = 3;
            btnReset.Text = "Show All";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // formsPlot1
            // 
            formsPlot1.DisplayScale = 2F;
            formsPlot1.Location = new Point(763, 75);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(767, 659);
            formsPlot1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(1063, 862);
            button2.Name = "button2";
            button2.Size = new Size(88, 43);
            button2.TabIndex = 6;
            button2.Text = "-->";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(969, 862);
            button1.Name = "button1";
            button1.Size = new Size(88, 43);
            button1.TabIndex = 5;
            button1.Text = "<--";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LecturerAnalysisForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1753, 955);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(formsPlot1);
            Controls.Add(btnReset);
            Controls.Add(btnFilterAboveAverage);
            Controls.Add(lblStats);
            Controls.Add(dataGridView1);
            Margin = new Padding(4);
            Name = "LecturerAnalysisForm";
            Text = "Student Grades Analysis";
            Load += LecturerAnalysisForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private Button button2;
        private Button button1;
        
    }

}
