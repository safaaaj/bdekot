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
            lblTitle = new Label();
            lblSubtitle = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // btnCreateQ
            // 
            btnCreateQ.BackColor = Color.Transparent;
            btnCreateQ.FlatStyle = FlatStyle.Flat;
            btnCreateQ.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnCreateQ.ForeColor = Color.White;
            btnCreateQ.Location = new Point(47, 257);
            btnCreateQ.Name = "btnCreateQ";
            btnCreateQ.Size = new Size(699, 206);
            btnCreateQ.TabIndex = 2;
            btnCreateQ.Text = "➕ Create Question";
            btnCreateQ.UseVisualStyleBackColor = false;
            btnCreateQ.Click += btnCreateQ_Click;
            // 
            // btnTeacherPage
            // 
            btnTeacherPage.BackColor = Color.Transparent;
            btnTeacherPage.FlatStyle = FlatStyle.Flat;
            btnTeacherPage.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnTeacherPage.ForeColor = Color.White;
            btnTeacherPage.Location = new Point(663, 495);
            btnTeacherPage.Name = "btnTeacherPage";
            btnTeacherPage.Size = new Size(699, 206);
            btnTeacherPage.TabIndex = 3;
            btnTeacherPage.Text = "📝 Create Exam";
            btnTeacherPage.UseVisualStyleBackColor = false;
            btnTeacherPage.Click += btnTeacherPage_Click;
            // 
            // btnOpenAnalysis
            // 
            btnOpenAnalysis.BackColor = Color.Transparent;
            btnOpenAnalysis.FlatStyle = FlatStyle.Flat;
            btnOpenAnalysis.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnOpenAnalysis.ForeColor = Color.White;
            btnOpenAnalysis.Location = new Point(258, 743);
            btnOpenAnalysis.Name = "btnOpenAnalysis";
            btnOpenAnalysis.Size = new Size(699, 206);
            btnOpenAnalysis.TabIndex = 4;
            btnOpenAnalysis.Text = "📊 Open Student Analysis";
            btnOpenAnalysis.UseVisualStyleBackColor = false;
            btnOpenAnalysis.Click += btnOpenAnalysis_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DarkSlateGray;
            lblTitle.Location = new Point(329, 48);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(796, 93);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "📚 Lecturer Dashboard";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.BackColor = Color.Transparent;
            lblSubtitle.Font = new Font("Segoe UI", 14F, FontStyle.Italic);
            lblSubtitle.ForeColor = Color.Black;
            lblSubtitle.Location = new Point(452, 165);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(594, 51);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Welcome! Choose an action below.";
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(74, 915);
            button3.Name = "button3";
            button3.Size = new Size(103, 72);
            button3.TabIndex = 13;
            button3.Text = "←";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
          //  BackgroundImage = Properties.Resources.main;
            ClientSize = new Size(1529, 1011);
            Controls.Add(button3);
            Controls.Add(lblTitle);
            Controls.Add(lblSubtitle);
            Controls.Add(btnCreateQ);
            Controls.Add(btnTeacherPage);
            Controls.Add(btnOpenAnalysis);
            Font = new Font("Segoe UI", 12F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Lecturer Dashboard";
            Load += MainForm_Load_2;
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private System.Windows.Forms.Button btnOpenAnalysis;
        private Button btnCreateQ;
        private Button btnTeacherPage;
        private Label lblTitle;
        private Label lblSubtitle;
        private Button button3;
    }
}
