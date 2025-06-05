namespace Examineon
{
    partial class PracticeSetupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            cmbPracticeSubject = new ComboBox();
            label2 = new Label();
            cmbPracticeDifficulty = new ComboBox();
            btnStartPractice = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(290, 62);
            label1.Name = "label1";
            label1.Size = new Size(169, 32);
            label1.TabIndex = 0;
            label1.Text = "Select Subject:";
            label1.Click += label1_Click;
            // 
            // cmbPracticeSubject
            // 
            cmbPracticeSubject.FormattingEnabled = true;
            cmbPracticeSubject.Location = new Point(233, 135);
            cmbPracticeSubject.Name = "cmbPracticeSubject";
            cmbPracticeSubject.Size = new Size(377, 40);
            cmbPracticeSubject.TabIndex = 1;
            cmbPracticeSubject.SelectedIndexChanged += this.cmbPracticeSubject_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(290, 236);
            label2.Name = "label2";
            label2.Size = new Size(186, 32);
            label2.TabIndex = 2;
            label2.Text = "Select Difficulty:";
            label2.Click += this.label2_Click;
            // 
            // cmbPracticeDifficulty
            // 
            cmbPracticeDifficulty.FormattingEnabled = true;
            cmbPracticeDifficulty.Location = new Point(233, 325);
            cmbPracticeDifficulty.Name = "cmbPracticeDifficulty";
            cmbPracticeDifficulty.Size = new Size(377, 40);
            cmbPracticeDifficulty.TabIndex = 3;
            cmbPracticeDifficulty.SelectedIndexChanged += this.cmbPracticeDifficulty_SelectedIndexChanged;
            // 
            // btnStartPractice
            // 
            btnStartPractice.Location = new Point(290, 426);
            btnStartPractice.Name = "btnStartPractice";
            btnStartPractice.Size = new Size(242, 76);
            btnStartPractice.TabIndex = 4;
            btnStartPractice.Text = "Start Practice";
            btnStartPractice.UseVisualStyleBackColor = true;
            btnStartPractice.Click += btnStartPractice_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(872, 83);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(110, 60);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // PracticeSetupForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 785);
            Controls.Add(btnExit);
            Controls.Add(btnStartPractice);
            Controls.Add(cmbPracticeDifficulty);
            Controls.Add(label2);
            Controls.Add(cmbPracticeSubject);
            Controls.Add(label1);
            Name = "PracticeSetupForm";
            Text = "PracticeSetupForm";
            Load += PracticeSetupForm_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox cmbPracticeSubject;
        private Label label2;
        private ComboBox cmbPracticeDifficulty;
        private Button btnStartPractice;
        private Button btnExit;
    }
}