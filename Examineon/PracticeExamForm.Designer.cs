namespace Examineon
{
    partial class PracticeExamForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblHeader;
        private Label lblQuestionNumber;
        private Label label1;
        private RadioButton rbA;
        private RadioButton rbB;
        private RadioButton rbC;
        private RadioButton rbD;
        private Button btnNext;
        private Button btnSubmit;
        private Button btnBack;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PracticeExamForm));
            lblHeader = new Label();
            lblQuestionNumber = new Label();
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
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.BackColor = Color.Transparent;
            lblHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblHeader.ForeColor = Color.LightYellow;
            lblHeader.Location = new Point(64, 20);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(0, 65);
            lblHeader.TabIndex = 0;
            // 
            // lblQuestionNumber
            // 
            lblQuestionNumber.AutoSize = true;
            lblQuestionNumber.BackColor = Color.Transparent;
            lblQuestionNumber.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            lblQuestionNumber.ForeColor = Color.SeaGreen;
            lblQuestionNumber.Location = new Point(64, 75);
            lblQuestionNumber.Name = "lblQuestionNumber";
            lblQuestionNumber.Size = new Size(0, 45);
            lblQuestionNumber.TabIndex = 1;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sylfaen", 12F);
            label1.ForeColor = Color.PaleGoldenrod;
            label1.Location = new Point(64, 226);
            label1.Name = "label1";
            label1.Size = new Size(850, 60);
            label1.TabIndex = 2;
            // 
            // rbA
            // 
            rbA.AutoSize = true;
            rbA.BackColor = Color.Transparent;
            rbA.Font = new Font("Segoe UI", 11F);
            rbA.ForeColor = Color.DarkSlateGray;
            rbA.Location = new Point(90, 336);
            rbA.Name = "rbA";
            rbA.Size = new Size(27, 26);
            rbA.TabIndex = 3;
            rbA.TabStop = true;
            rbA.UseVisualStyleBackColor = false;
            // 
            // rbB
            // 
            rbB.AutoSize = true;
            rbB.BackColor = Color.Transparent;
            rbB.Font = new Font("Segoe UI", 11F);
            rbB.ForeColor = Color.DarkSlateGray;
            rbB.Location = new Point(90, 381);
            rbB.Name = "rbB";
            rbB.Size = new Size(27, 26);
            rbB.TabIndex = 4;
            rbB.TabStop = true;
            rbB.UseVisualStyleBackColor = false;
            // 
            // rbC
            // 
            rbC.AutoSize = true;
            rbC.BackColor = Color.Transparent;
            rbC.Font = new Font("Segoe UI", 11F);
            rbC.ForeColor = Color.DarkSlateGray;
            rbC.Location = new Point(90, 426);
            rbC.Name = "rbC";
            rbC.Size = new Size(27, 26);
            rbC.TabIndex = 5;
            rbC.TabStop = true;
            rbC.UseVisualStyleBackColor = false;
            // 
            // rbD
            // 
            rbD.AutoSize = true;
            rbD.BackColor = Color.Transparent;
            rbD.Font = new Font("Segoe UI", 11F);
            rbD.ForeColor = Color.DarkSlateGray;
            rbD.Location = new Point(90, 471);
            rbD.Name = "rbD";
            rbD.Size = new Size(27, 26);
            rbD.TabIndex = 6;
            rbD.TabStop = true;
            rbD.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.Transparent;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Sylfaen", 10F, FontStyle.Bold);
            btnNext.ForeColor = Color.SeaGreen;
            btnNext.Location = new Point(763, 400);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(151, 50);
            btnNext.TabIndex = 7;
            btnNext.Text = "➡️ Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.Transparent;
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSubmit.ForeColor = Color.SeaGreen;
            btnSubmit.Location = new Point(763, 470);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(151, 50);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "✅ Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Sylfaen", 10F);
            btnBack.ForeColor = Color.SeaGreen;
            btnBack.Location = new Point(12, 656);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(194, 101);
            btnBack.TabIndex = 9;
            btnBack.Text = "🔙 Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // PracticeExamForm
            // 
            BackgroundImage = Properties.Resources.ChatGPT_Image_Jun_7__2025__01_14_41_AM;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1242, 907);
            Controls.Add(lblHeader);
            Controls.Add(lblQuestionNumber);
            Controls.Add(label1);
            Controls.Add(rbA);
            Controls.Add(rbB);
            Controls.Add(rbC);
            Controls.Add(rbD);
            Controls.Add(btnNext);
            Controls.Add(btnSubmit);
            Controls.Add(btnBack);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PracticeExamForm";
            Text = "Practice Exam";
            Load += PracticeExamForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
