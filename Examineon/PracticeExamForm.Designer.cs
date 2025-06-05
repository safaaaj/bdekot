namespace Examineon
{
    partial class PracticeExamForm
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
            rbA = new RadioButton();
            rbB = new RadioButton();
            rbC = new RadioButton();
            rbD = new RadioButton();
            btnNext = new Button();
            btnSubmit = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(86, 54);
            label1.Name = "label1";
            label1.Size = new Size(435, 40);
            label1.TabIndex = 0;
            label1.Click += label1_Click;
            // 
            // rbA
            // 
            rbA.AutoSize = true;
            rbA.Location = new Point(105, 127);
            rbA.Name = "rbA";
            rbA.Size = new Size(184, 36);
            rbA.TabIndex = 1;
            rbA.TabStop = true;
            rbA.Text = "radioButton1";
            rbA.UseVisualStyleBackColor = true;
            // 
            // rbB
            // 
            rbB.AutoSize = true;
            rbB.Location = new Point(103, 169);
            rbB.Name = "rbB";
            rbB.Size = new Size(184, 36);
            rbB.TabIndex = 2;
            rbB.TabStop = true;
            rbB.Text = "radioButton2";
            rbB.UseVisualStyleBackColor = true;
            // 
            // rbC
            // 
            rbC.AutoSize = true;
            rbC.Location = new Point(105, 226);
            rbC.Name = "rbC";
            rbC.Size = new Size(184, 36);
            rbC.TabIndex = 3;
            rbC.TabStop = true;
            rbC.Text = "radioButton3";
            rbC.UseVisualStyleBackColor = true;
            // 
            // rbD
            // 
            rbD.AutoSize = true;
            rbD.Location = new Point(103, 277);
            rbD.Name = "rbD";
            rbD.Size = new Size(184, 36);
            rbD.TabIndex = 4;
            rbD.TabStop = true;
            rbD.Text = "radioButton4";
            rbD.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(387, 258);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(151, 57);
            btnNext.TabIndex = 5;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(387, 336);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(151, 57);
            btnSubmit.TabIndex = 6;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(64, 514);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(118, 49);
            btnBack.TabIndex = 7;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // PracticeExamForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 819);
            Controls.Add(btnBack);
            Controls.Add(label1);
            Controls.Add(btnSubmit);
            Controls.Add(btnNext);
            Controls.Add(rbD);
            Controls.Add(rbC);
            Controls.Add(rbB);
            Controls.Add(rbA);
            Name = "PracticeExamForm";
            Text = "PracticeExamForm";
            Load += PracticeExamForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RadioButton rbA;
        private RadioButton rbB;
        private RadioButton rbC;
        private RadioButton rbD;
        private Button btnNext;
        private Button btnSubmit;
        private Label label1;
        private Button btnBack;
    }
}