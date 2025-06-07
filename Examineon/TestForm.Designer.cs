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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm));
            lblQuestion = new Label();
            rbA = new RadioButton();
            rbB = new RadioButton();
            rbC = new RadioButton();
            rbD = new RadioButton();
            btnNext = new Button();
            btnSubmit = new Button();
            lblProgress = new Label();
            mainPanel = new Panel();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // lblQuestion
            // 
            lblQuestion.BackColor = Color.Transparent;
            lblQuestion.Font = new Font("Sylfaen", 14F, FontStyle.Bold);
            lblQuestion.ForeColor = Color.Gray;
            lblQuestion.Location = new Point(20, 20);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(660, 60);
            lblQuestion.TabIndex = 0;
            lblQuestion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // rbA
            // 
            rbA.AutoSize = true;
            rbA.Font = new Font("Sylfaen", 11F);
            rbA.ForeColor = Color.DimGray;
            rbA.Location = new Point(60, 110);
            rbA.Name = "rbA";
            rbA.Size = new Size(85, 43);
            rbA.TabIndex = 1;
            rbA.Text = "A. ";
            rbA.CheckedChanged += rbA_CheckedChanged;
            // 
            // rbB
            // 
            rbB.AutoSize = true;
            rbB.Font = new Font("Sylfaen", 11F);
            rbB.ForeColor = Color.DimGray;
            rbB.Location = new Point(60, 170);
            rbB.Name = "rbB";
            rbB.Size = new Size(82, 43);
            rbB.TabIndex = 2;
            rbB.Text = "B. ";
            // 
            // rbC
            // 
            rbC.AutoSize = true;
            rbC.Font = new Font("Sylfaen", 11F);
            rbC.ForeColor = Color.DimGray;
            rbC.Location = new Point(60, 230);
            rbC.Name = "rbC";
            rbC.Size = new Size(75, 43);
            rbC.TabIndex = 3;
            rbC.Text = "C.";
            // 
            // rbD
            // 
            rbD.AutoSize = true;
            rbD.Font = new Font("Sylfaen", 11F);
            rbD.ForeColor = Color.DimGray;
            rbD.Location = new Point(60, 290);
            rbD.Name = "rbD";
            rbD.Size = new Size(86, 43);
            rbD.TabIndex = 4;
            rbD.Text = "D. ";
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.Transparent;
            btnNext.FlatAppearance.BorderColor = Color.SeaGreen;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Sylfaen", 10F, FontStyle.Bold);
            btnNext.ForeColor = Color.DarkGreen;
            btnNext.Location = new Point(600, 370);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(100, 57);
            btnNext.TabIndex = 5;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.Transparent;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Sylfaen", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.ForeColor = Color.DarkGreen;
            btnSubmit.Location = new Point(730, 370);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(120, 57);
            btnSubmit.TabIndex = 6;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblProgress
            // 
            lblProgress.AutoSize = true;
            lblProgress.BackColor = Color.Transparent;
            lblProgress.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblProgress.ForeColor = Color.DarkOliveGreen;
            lblProgress.Location = new Point(20, 370);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(0, 32);
            lblProgress.TabIndex = 7;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(180, 255, 255, 255);
            mainPanel.Controls.Add(lblQuestion);
            mainPanel.Controls.Add(rbA);
            mainPanel.Controls.Add(rbB);
            mainPanel.Controls.Add(rbC);
            mainPanel.Controls.Add(rbD);
            mainPanel.Controls.Add(btnNext);
            mainPanel.Controls.Add(btnSubmit);
            mainPanel.Controls.Add(lblProgress);
            mainPanel.Location = new Point(274, 80);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(880, 500);
            mainPanel.TabIndex = 0;
            // 
            // TestForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ChatGPT_Image_Jun_7__2025__02_25_55_AM;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1299, 777);
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TestForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "📝 Exam In Progress";
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ResumeLayout(false);
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
        private Panel mainPanel;
    }
}