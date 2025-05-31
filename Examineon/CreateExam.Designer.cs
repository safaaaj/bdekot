namespace Examineon
{
    partial class CreateExam
    {
        private System.ComponentModel.IContainer components = null;

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
            chkRandomTopics = new CheckBox();
            btnCreateExam = new Button();
            cmbDifficulty = new ComboBox();
            label4 = new Label();
            clbTopics = new CheckedListBox();
            label3 = new Label();
            nudNumQuestions = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            dgvAvailableQuestions = new DataGridView();
            dgvExams = new DataGridView();
            btnDeleteExam = new Button();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)nudNumQuestions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAvailableQuestions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvExams).BeginInit();
            SuspendLayout();
            // 
            // chkRandomTopics
            // 
            chkRandomTopics.AutoSize = true;
            chkRandomTopics.Location = new Point(125, 630);
            chkRandomTopics.Name = "chkRandomTopics";
            chkRandomTopics.Size = new Size(289, 36);
            chkRandomTopics.TabIndex = 20;
            chkRandomTopics.Text = "Random topics instead";
            chkRandomTopics.UseVisualStyleBackColor = true;
            // 
            // btnCreateExam
            // 
            btnCreateExam.Location = new Point(70, 909);
            btnCreateExam.Name = "btnCreateExam";
            btnCreateExam.Size = new Size(300, 59);
            btnCreateExam.TabIndex = 19;
            btnCreateExam.Text = "Create Exam";
            btnCreateExam.UseVisualStyleBackColor = true;
            btnCreateExam.Click += btnCreateExam_Click;
            // 
            // cmbDifficulty
            // 
            cmbDifficulty.FormattingEnabled = true;
            cmbDifficulty.Items.AddRange(new object[] { "Easy", "Medium", "Hard" });
            cmbDifficulty.Location = new Point(327, 751);
            cmbDifficulty.Name = "cmbDifficulty";
            cmbDifficulty.Size = new Size(313, 40);
            cmbDifficulty.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(125, 751);
            label4.Name = "label4";
            label4.Size = new Size(177, 32);
            label4.TabIndex = 17;
            label4.Text = "Difficulty Level:";
            // 
            // clbTopics
            // 
            clbTopics.FormattingEnabled = true;
            clbTopics.Items.AddRange(new object[] { "English", "Math", "Hebrew" });
            clbTopics.Location = new Point(238, 443);
            clbTopics.Name = "clbTopics";
            clbTopics.Size = new Size(402, 112);
            clbTopics.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(125, 384);
            label3.Name = "label3";
            label3.Size = new Size(156, 32);
            label3.TabIndex = 15;
            label3.Text = "Select Topics:";
            // 
            // nudNumQuestions
            // 
            nudNumQuestions.Location = new Point(387, 270);
            nudNumQuestions.Name = "nudNumQuestions";
            nudNumQuestions.Size = new Size(312, 39);
            nudNumQuestions.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(125, 270);
            label2.Name = "label2";
            label2.Size = new Size(245, 32);
            label2.TabIndex = 13;
            label2.Text = "Number of Questions";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            label1.Location = new Point(410, 52);
            label1.Name = "label1";
            label1.Size = new Size(456, 106);
            label1.TabIndex = 12;
            label1.Text = "Create Exam";
            // 
            // dgvAvailableQuestions
            // 
            dgvAvailableQuestions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAvailableQuestions.Location = new Point(862, 147);
            dgvAvailableQuestions.Name = "dgvAvailableQuestions";
            dgvAvailableQuestions.RowHeadersWidth = 62;
            dgvAvailableQuestions.RowTemplate.Height = 28;
            dgvAvailableQuestions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAvailableQuestions.Size = new Size(1000, 300);
            dgvAvailableQuestions.TabIndex = 0;
            // 
            // dgvExams
            // 
            dgvExams.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExams.Location = new Point(862, 487);
            dgvExams.Name = "dgvExams";
            dgvExams.RowHeadersWidth = 62;
            dgvExams.RowTemplate.Height = 28;
            dgvExams.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvExams.Size = new Size(1000, 736);
            dgvExams.TabIndex = 31;
            // 
            // btnDeleteExam
            // 
            btnDeleteExam.Location = new Point(426, 909);
            btnDeleteExam.Name = "btnDeleteExam";
            btnDeleteExam.Size = new Size(300, 59);
            btnDeleteExam.TabIndex = 30;
            btnDeleteExam.Text = "Delete Selected Exam";
            btnDeleteExam.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(173, 860);
            button2.Name = "button2";
            button2.Size = new Size(88, 43);
            button2.TabIndex = 33;
            button2.Text = "-->";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(79, 860);
            button1.Name = "button1";
            button1.Size = new Size(88, 43);
            button1.TabIndex = 32;
            button1.Text = "<--";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CreateExam
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2052, 1250);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(chkRandomTopics);
            Controls.Add(cmbDifficulty);
            Controls.Add(label4);
            Controls.Add(clbTopics);
            Controls.Add(label3);
            Controls.Add(nudNumQuestions);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCreateExam);
            Controls.Add(btnDeleteExam);
            Controls.Add(dgvAvailableQuestions);
            Controls.Add(dgvExams);
            Name = "CreateExam";
            Text = "Create Exam";
            Load += CreateExam_Load;
            ((System.ComponentModel.ISupportInitialize)nudNumQuestions).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAvailableQuestions).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvExams).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.CheckBox chkRandomTopics;
        private System.Windows.Forms.Button btnCreateExam;
        private System.Windows.Forms.Button btnDeleteExam;
        private System.Windows.Forms.ComboBox cmbDifficulty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox clbTopics;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudNumQuestions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAvailableQuestions;
        private System.Windows.Forms.DataGridView dgvExams;
        private Button button2;
        private Button button1;
    }
}
