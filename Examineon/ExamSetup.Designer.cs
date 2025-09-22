namespace Examineon
{
    partial class ExamSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExamSetup));
            btnExit = new Button();
            btnStartPractice = new Button();
            cmbPracticeDifficulty = new ComboBox();
            label2 = new Label();
            cmbPracticeSubject = new ComboBox();
            label1 = new Label();
            btnBack = new Button();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.Font = new Font("Sylfaen", 16.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(1269, 129);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(171, 60);
            btnExit.TabIndex = 11;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnStartPractice
            // 
            btnStartPractice.BackColor = Color.Transparent;
            btnStartPractice.Font = new Font("Sylfaen", 16.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStartPractice.ForeColor = Color.DarkOliveGreen;
            btnStartPractice.Location = new Point(631, 851);
            btnStartPractice.Name = "btnStartPractice";
            btnStartPractice.Size = new Size(242, 76);
            btnStartPractice.TabIndex = 10;
            btnStartPractice.Text = "Start";
            btnStartPractice.UseVisualStyleBackColor = false;
            // 
            // cmbPracticeDifficulty
            // 
            cmbPracticeDifficulty.FormattingEnabled = true;
            cmbPracticeDifficulty.Location = new Point(571, 739);
            cmbPracticeDifficulty.Name = "cmbPracticeDifficulty";
            cmbPracticeDifficulty.Size = new Size(377, 40);
            cmbPracticeDifficulty.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sylfaen", 16.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(606, 641);
            label2.Name = "label2";
            label2.Size = new Size(357, 58);
            label2.TabIndex = 8;
            label2.Text = "Select Difficulty:";
            // 
            // cmbPracticeSubject
            // 
            cmbPracticeSubject.FormattingEnabled = true;
            cmbPracticeSubject.Location = new Point(571, 528);
            cmbPracticeSubject.Name = "cmbPracticeSubject";
            cmbPracticeSubject.Size = new Size(377, 40);
            cmbPracticeSubject.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sylfaen", 16.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(606, 420);
            label1.Name = "label1";
            label1.Size = new Size(312, 58);
            label1.TabIndex = 6;
            label1.Text = "Select Subject:";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Sylfaen", 19F, FontStyle.Italic);
            btnBack.ForeColor = Color.DarkGreen;
            btnBack.Location = new Point(55, 1181);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(194, 101);
            btnBack.TabIndex = 12;
            btnBack.Text = "🔙 ";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // ExamSetup
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2025_06_07_042111;
            ClientSize = new Size(1482, 1348);
            Controls.Add(btnBack);
            Controls.Add(btnExit);
            Controls.Add(btnStartPractice);
            Controls.Add(cmbPracticeDifficulty);
            Controls.Add(label2);
            Controls.Add(cmbPracticeSubject);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ExamSetup";
            Text = "Exam Setup";
            Load += ExamSetup_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStartPractice;
        private System.Windows.Forms.ComboBox cmbPracticeDifficulty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPracticeSubject;
        private System.Windows.Forms.Label label1;
        private Button btnBack;
    }
}
