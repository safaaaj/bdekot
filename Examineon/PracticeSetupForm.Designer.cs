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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PracticeSetupForm));
            label1 = new Label();
            cmbPracticeSubject = new ComboBox();
            label2 = new Label();
            cmbPracticeDifficulty = new ComboBox();
            btnStartPractice = new Button();
            btnExit = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(420, 310);
            label1.Name = "label1";
            label1.Size = new Size(226, 42);
            label1.TabIndex = 0;
            label1.Text = "Select Subject:";
            // 
            // cmbPracticeSubject
            // 
            cmbPracticeSubject.BackColor = Color.White;
            cmbPracticeSubject.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPracticeSubject.Font = new Font("Sylfaen", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbPracticeSubject.ForeColor = Color.DarkGreen;
            cmbPracticeSubject.Location = new Point(330, 360);
            cmbPracticeSubject.Name = "cmbPracticeSubject";
            cmbPracticeSubject.Size = new Size(377, 43);
            cmbPracticeSubject.TabIndex = 1;
            cmbPracticeSubject.SelectedIndexChanged += cmbPracticeSubject_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(420, 450);
            label2.Name = "label2";
            label2.Size = new Size(259, 42);
            label2.TabIndex = 2;
            label2.Text = "Select Difficulty:";
            // 
            // cmbPracticeDifficulty
            // 
            cmbPracticeDifficulty.BackColor = Color.White;
            cmbPracticeDifficulty.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPracticeDifficulty.Font = new Font("Sylfaen", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 161);
            cmbPracticeDifficulty.ForeColor = Color.DarkGreen;
            cmbPracticeDifficulty.Location = new Point(330, 500);
            cmbPracticeDifficulty.Name = "cmbPracticeDifficulty";
            cmbPracticeDifficulty.Size = new Size(377, 43);
            cmbPracticeDifficulty.TabIndex = 3;
            cmbPracticeDifficulty.SelectedIndexChanged += cmbPracticeDifficulty_SelectedIndexChanged;
            // 
            // btnStartPractice
            // 
            btnStartPractice.BackColor = Color.White;
            btnStartPractice.FlatAppearance.BorderColor = Color.SeaGreen;
            btnStartPractice.FlatAppearance.BorderSize = 2;
            btnStartPractice.FlatStyle = FlatStyle.Flat;
            btnStartPractice.Font = new Font("Sylfaen", 11F, FontStyle.Bold);
            btnStartPractice.ForeColor = Color.SeaGreen;
            btnStartPractice.Location = new Point(400, 600);
            btnStartPractice.Name = "btnStartPractice";
            btnStartPractice.Size = new Size(240, 60);
            btnStartPractice.TabIndex = 4;
            btnStartPractice.Text = "Start Practice";
            btnStartPractice.UseVisualStyleBackColor = false;
            btnStartPractice.Click += btnStartPractice_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.FlatAppearance.BorderColor = Color.DarkOliveGreen;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.Brown;
            btnExit.Location = new Point(920, 30);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 45);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Sylfaen", 15F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.CadetBlue;
            btnBack.Location = new Point(12, 880);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(194, 101);
            btnBack.TabIndex = 10;
            btnBack.Text = "🔙 ";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // PracticeSetupForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ChatGPT_Image_Jun_7__2025__01_30_18_AM;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1064, 1022);
            Controls.Add(btnBack);
            Controls.Add(label1);
            Controls.Add(cmbPracticeSubject);
            Controls.Add(label2);
            Controls.Add(cmbPracticeDifficulty);
            Controls.Add(btnStartPractice);
            Controls.Add(btnExit);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PracticeSetupForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Practice Setup";
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
        private Button btnBack;
    }
}