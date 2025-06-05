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
            SuspendLayout();
            // 
            // btnPracticeExam
            // 
            btnPracticeExam.Location = new Point(60, 568);
            btnPracticeExam.Name = "btnPracticeExam";
            btnPracticeExam.Size = new Size(237, 68);
            btnPracticeExam.TabIndex = 0;
            btnPracticeExam.Text = "Practice form";
            btnPracticeExam.UseVisualStyleBackColor = true;
            btnPracticeExam.Click += btnPracticeExam_Click;
            // 
            // button1
            // 
            button1.Location = new Point(60, 455);
            button1.Name = "button1";
            button1.Size = new Size(237, 68);
            button1.TabIndex = 1;
            button1.Text = "Exam form";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SecondaryForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 797);
            Controls.Add(button1);
            Controls.Add(btnPracticeExam);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SecondaryForm";
            Text = "SecondaryForm";
            Load += SecondaryForm_Load;
            ResumeLayout(false);

            this.btnViewScores = new System.Windows.Forms.Button();

            // 
            // btnViewScores
            // 
            this.btnViewScores.Location = new System.Drawing.Point(50, 300); // adjust position as needed
            this.btnViewScores.Name = "btnViewScores";
            this.btnViewScores.Size = new System.Drawing.Size(200, 50);
            this.btnViewScores.Text = "View My Scores";
            this.btnViewScores.UseVisualStyleBackColor = true;
            this.btnViewScores.Click += new System.EventHandler(this.btnViewScores_Click);

            // Add to form
            this.Controls.Add(this.btnViewScores);

        }

        #endregion

        private Button btnPracticeExam;
        private Button button1;


    }
}