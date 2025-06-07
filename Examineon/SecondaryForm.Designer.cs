namespace Examineon
{
    partial class SecondaryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnViewScores;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecondaryForm));
            btnPracticeExam = new Button();
            button1 = new Button();
            btnViewScores = new Button();
            lblTitle = new Label();
            lblSubtitle = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // btnPracticeExam
            // 
            btnPracticeExam.BackColor = Color.Transparent;
            btnPracticeExam.FlatStyle = FlatStyle.Flat;
            btnPracticeExam.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnPracticeExam.ForeColor = Color.White;
            btnPracticeExam.Location = new Point(57, 251);
            btnPracticeExam.Name = "btnPracticeExam";
            btnPracticeExam.Size = new Size(699, 206);
            btnPracticeExam.TabIndex = 2;
            btnPracticeExam.Text = "\U0001f9ea Practice Form";
            btnPracticeExam.UseVisualStyleBackColor = false;
            btnPracticeExam.Click += btnPracticeExam_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(663, 495);
            button1.Name = "button1";
            button1.Size = new Size(699, 206);
            button1.TabIndex = 3;
            button1.Text = "📝 Exam Form";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnViewScores
            // 
            btnViewScores.BackColor = Color.Transparent;
            btnViewScores.FlatStyle = FlatStyle.Flat;
            btnViewScores.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnViewScores.ForeColor = Color.White;
            btnViewScores.Location = new Point(258, 743);
            btnViewScores.Name = "btnViewScores";
            btnViewScores.Size = new Size(699, 206);
            btnViewScores.TabIndex = 4;
            btnViewScores.Text = "📊 View My Scores";
            btnViewScores.UseVisualStyleBackColor = false;
            btnViewScores.Click += btnViewScores_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DarkSlateGray;
            lblTitle.Location = new Point(365, 27);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(781, 93);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "📄 Student Dashboard";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.BackColor = Color.Transparent;
            lblSubtitle.Font = new Font("Segoe UI", 14F, FontStyle.Italic);
            lblSubtitle.ForeColor = Color.Black;
            lblSubtitle.Location = new Point(516, 136);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(499, 51);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Choose what you’d like to do:";
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(57, 904);
            button3.Name = "button3";
            button3.Size = new Size(103, 72);
            button3.TabIndex = 14;
            button3.Text = "←";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;

            // 
            // SecondaryForm
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = Properties.Resources.main;
            ClientSize = new Size(1529, 1011);
            Controls.Add(button3);
            Controls.Add(lblTitle);
            Controls.Add(lblSubtitle);
            Controls.Add(btnPracticeExam);
            Controls.Add(button1);
            Controls.Add(btnViewScores);
            Font = new Font("Segoe UI", 12F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SecondaryForm";
            Text = "Student Panel";
            Load += SecondaryForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Button btnPracticeExam;
        private Button button1;
        private Label lblTitle;
        private Label lblSubtitle;
        private Button button3;
    }
}