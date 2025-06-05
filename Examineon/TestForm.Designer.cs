namespace Examineon
{
    partial class TestForm
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
            lblQuestion = new Label();
            rbA = new RadioButton();
            rbB = new RadioButton();
            rbC = new RadioButton();
            rbD = new RadioButton();
            btnNext = new Button();
            btnSubmit = new Button();
            lblProgress = new Label();
            SuspendLayout();
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Location = new Point(56, 57);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(0, 32);
            lblQuestion.TabIndex = 0;
            // 
            // rbA
            // 
            rbA.AutoSize = true;
            rbA.Location = new Point(58, 152);
            rbA.Name = "rbA";
            rbA.Size = new Size(184, 36);
            rbA.TabIndex = 1;
            rbA.TabStop = true;
            rbA.Text = "radioButton1";
            rbA.UseVisualStyleBackColor = true;
            rbA.CheckedChanged += rbA_CheckedChanged;
            // 
            // rbB
            // 
            rbB.AutoSize = true;
            rbB.Location = new Point(56, 203);
            rbB.Name = "rbB";
            rbB.Size = new Size(184, 36);
            rbB.TabIndex = 2;
            rbB.TabStop = true;
            rbB.Text = "radioButton1";
            rbB.UseVisualStyleBackColor = true;
            // 
            // rbC
            // 
            rbC.AutoSize = true;
            rbC.Location = new Point(56, 256);
            rbC.Name = "rbC";
            rbC.Size = new Size(184, 36);
            rbC.TabIndex = 3;
            rbC.TabStop = true;
            rbC.Text = "radioButton1";
            rbC.UseVisualStyleBackColor = true;
            // 
            // rbD
            // 
            rbD.AutoSize = true;
            rbD.Location = new Point(56, 313);
            rbD.Name = "rbD";
            rbD.Size = new Size(184, 36);
            rbD.TabIndex = 4;
            rbD.TabStop = true;
            rbD.Text = "radioButton1";
            rbD.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(387, 195);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(112, 62);
            btnNext.TabIndex = 5;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click_1;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(387, 292);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(151, 57);
            btnSubmit.TabIndex = 7;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblProgress
            // 
            lblProgress.AutoSize = true;
            lblProgress.Location = new Point(35, 417);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(78, 32);
            lblProgress.TabIndex = 8;
            lblProgress.Text = "label1";
            // 
            // TestForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 497);
            Controls.Add(lblProgress);
            Controls.Add(btnSubmit);
            Controls.Add(btnNext);
            Controls.Add(rbD);
            Controls.Add(rbC);
            Controls.Add(rbB);
            Controls.Add(rbA);
            Controls.Add(lblQuestion);
            Name = "TestForm";
            Text = "TestForm";
            Load += TestForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblQuestion;
        private RadioButton rbA;
        private RadioButton rbB;
        private RadioButton rbC;
        private RadioButton rbD;
        private Button btnNext;
        private Button btnSubmit;
        private Label lblProgress;
    }
}