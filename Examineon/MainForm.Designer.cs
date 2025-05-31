namespace Examineon
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btnCreateQ = new Button();
            btnTeacherPage = new Button();
            btnOpenAnalysis = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // btnCreateQ
            // 
            btnCreateQ.Location = new Point(101, 293);
            btnCreateQ.Name = "btnCreateQ";
            btnCreateQ.Size = new Size(327, 97);
            btnCreateQ.TabIndex = 0;
            btnCreateQ.Text = "create q";
            btnCreateQ.UseVisualStyleBackColor = true;
            btnCreateQ.Click += btnCreateQ_Click;
            // 
            // btnTeacherPage
            // 
            btnTeacherPage.ImeMode = ImeMode.NoControl;
            btnTeacherPage.Location = new Point(101, 470);
            btnTeacherPage.Name = "btnTeacherPage";
            btnTeacherPage.Size = new Size(327, 97);
            btnTeacherPage.TabIndex = 2;
            btnTeacherPage.Text = "Create Exam";
            btnTeacherPage.UseVisualStyleBackColor = true;
            // 
            // btnOpenAnalysis
            // 
            btnOpenAnalysis.Location = new Point(124, 652);
            btnOpenAnalysis.Name = "btnOpenAnalysis";
            btnOpenAnalysis.Size = new Size(327, 97);
            btnOpenAnalysis.TabIndex = 0;
            btnOpenAnalysis.Text = "Open Student Analysis";
            btnOpenAnalysis.UseVisualStyleBackColor = true;
            btnOpenAnalysis.Click += btnOpenAnalysis_Click;
            // 
            // button1
            // 
            button1.Location = new Point(51, 877);
            button1.Name = "button1";
            button1.Size = new Size(88, 43);
            button1.TabIndex = 3;
            button1.Text = "<--";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(145, 877);
            button2.Name = "button2";
            button2.Size = new Size(88, 43);
            button2.TabIndex = 4;
            button2.Text = "-->";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1193, 998);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnCreateQ);
            Controls.Add(btnTeacherPage);
            Controls.Add(btnOpenAnalysis);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load_2;
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenAnalysis;
        private Button btnCreateQ;
        private Button btnTeacherPage;
        private Button button1;
        private Button button2;
    }
}