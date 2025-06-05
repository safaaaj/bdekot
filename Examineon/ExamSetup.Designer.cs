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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStartPractice = new System.Windows.Forms.Button();
            this.cmbPracticeDifficulty = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPracticeSubject = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(801, 72);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 60);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStartPractice
            // 
            this.btnStartPractice.Location = new System.Drawing.Point(219, 415);
            this.btnStartPractice.Name = "btnStartPractice";
            this.btnStartPractice.Size = new System.Drawing.Size(242, 76);
            this.btnStartPractice.TabIndex = 10;
            this.btnStartPractice.Text = "Start Exam";
            this.btnStartPractice.UseVisualStyleBackColor = true;
           
            // 
            // cmbPracticeDifficulty
            // 
            this.cmbPracticeDifficulty.FormattingEnabled = true;
            this.cmbPracticeDifficulty.Location = new System.Drawing.Point(162, 314);
            this.cmbPracticeDifficulty.Name = "cmbPracticeDifficulty";
            this.cmbPracticeDifficulty.Size = new System.Drawing.Size(377, 40);
            this.cmbPracticeDifficulty.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Select Difficulty:";
            // 
            // cmbPracticeSubject
            // 
            this.cmbPracticeSubject.FormattingEnabled = true;
            this.cmbPracticeSubject.Location = new System.Drawing.Point(162, 124);
            this.cmbPracticeSubject.Name = "cmbPracticeSubject";
            this.cmbPracticeSubject.Size = new System.Drawing.Size(377, 40);
            this.cmbPracticeSubject.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select Subject:";
            // 
            // ExamSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 715);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStartPractice);
            this.Controls.Add(this.cmbPracticeDifficulty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbPracticeSubject);
            this.Controls.Add(this.label1);
            this.Name = "ExamSetup";
            this.Text = "Exam Setup";
            this.Load += new System.EventHandler(this.ExamSetup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStartPractice;
        private System.Windows.Forms.ComboBox cmbPracticeDifficulty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPracticeSubject;
        private System.Windows.Forms.Label label1;
    }
}
