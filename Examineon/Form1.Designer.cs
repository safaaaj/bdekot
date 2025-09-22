namespace Examineon
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnAdd = new Button();
            btnClear = new Button();
            btnDisplay = new Button();
            QType = new Label();
            QCategory = new Label();
            QDifficulty = new Label();
            cmbCategory = new ComboBox();
            cmbType = new ComboBox();
            cmbDifficulty = new ComboBox();
            txtQuestion = new TextBox();
            txtAnswerA = new TextBox();
            txtAnswerB = new TextBox();
            txtAnswerC = new TextBox();
            txtAnswerD = new TextBox();
            rbA = new RadioButton();
            rbB = new RadioButton();
            rbC = new RadioButton();
            rbD = new RadioButton();
            btnEdit = new Button();
            btnDelete = new Button();
            lstQuestions = new ListBox();
            btnExit = new Button();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DarkSeaGreen;
            btnAdd.Font = new Font("Segoe UI Variable Display", 10.875F, FontStyle.Bold);
            btnAdd.ForeColor = Color.DarkSlateGray;
            btnAdd.Location = new Point(63, 542);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(222, 102);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "➕ Add Question";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.DarkSeaGreen;
            btnClear.Font = new Font("Segoe UI Variable Display", 10.875F, FontStyle.Bold);
            btnClear.ForeColor = Color.DarkSlateGray;
            btnClear.Location = new Point(63, 727);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(211, 102);
            btnClear.TabIndex = 1;
            btnClear.Text = "\U0001f9f9 Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDisplay
            // 
            btnDisplay.BackColor = Color.DarkSeaGreen;
            btnDisplay.Font = new Font("Segoe UI Variable Display", 10.875F, FontStyle.Bold);
            btnDisplay.ForeColor = Color.DarkSlateGray;
            btnDisplay.Location = new Point(367, 542);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(200, 102);
            btnDisplay.TabIndex = 2;
            btnDisplay.Text = "📋Display";
            btnDisplay.UseVisualStyleBackColor = false;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // QType
            // 
            QType.AutoSize = true;
            QType.BackColor = Color.Transparent;
            QType.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            QType.ForeColor = Color.DarkSlateGray;
            QType.Location = new Point(63, 265);
            QType.Name = "QType";
            QType.Size = new Size(289, 45);
            QType.TabIndex = 3;
            QType.Text = "📘 Question Type";
            // 
            // QCategory
            // 
            QCategory.AutoSize = true;
            QCategory.BackColor = Color.Transparent;
            QCategory.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            QCategory.ForeColor = Color.DarkSlateGray;
            QCategory.Location = new Point(63, 343);
            QCategory.Name = "QCategory";
            QCategory.Size = new Size(354, 45);
            QCategory.TabIndex = 4;
            QCategory.Text = "📂 Question Category";
            // 
            // QDifficulty
            // 
            QDifficulty.AutoSize = true;
            QDifficulty.BackColor = Color.Transparent;
            QDifficulty.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            QDifficulty.ForeColor = Color.DarkSlateGray;
            QDifficulty.Location = new Point(63, 419);
            QDifficulty.Name = "QDifficulty";
            QDifficulty.Size = new Size(339, 45);
            QDifficulty.TabIndex = 5;
            QDifficulty.Text = "⭐ Question Difficulty";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(423, 350);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(242, 40);
            cmbCategory.TabIndex = 6;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(367, 272);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(242, 40);
            cmbType.TabIndex = 7;
            cmbType.SelectedIndexChanged += cmbType_SelectedIndexChanged;
            // 
            // cmbDifficulty
            // 
            cmbDifficulty.FormattingEnabled = true;
            cmbDifficulty.Location = new Point(408, 419);
            cmbDifficulty.Name = "cmbDifficulty";
            cmbDifficulty.Size = new Size(242, 40);
            cmbDifficulty.TabIndex = 8;
            cmbDifficulty.SelectedIndexChanged += cmbDifficulty_SelectedIndexChanged;
            // 
            // txtQuestion
            // 
            txtQuestion.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold | FontStyle.Italic);
            txtQuestion.Location = new Point(1120, 218);
            txtQuestion.Name = "txtQuestion";
            txtQuestion.Size = new Size(200, 46);
            txtQuestion.TabIndex = 9;
            txtQuestion.TextChanged += txtQuestion_TextChanged;
            // 
            // txtAnswerA
            // 
            txtAnswerA.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold | FontStyle.Italic);
            txtAnswerA.Location = new Point(973, 293);
            txtAnswerA.Name = "txtAnswerA";
            txtAnswerA.Size = new Size(200, 46);
            txtAnswerA.TabIndex = 10;
            txtAnswerA.TextChanged += txtAnswerA_TextChanged;
            // 
            // txtAnswerB
            // 
            txtAnswerB.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold | FontStyle.Italic);
            txtAnswerB.Location = new Point(973, 368);
            txtAnswerB.Name = "txtAnswerB";
            txtAnswerB.Size = new Size(200, 46);
            txtAnswerB.TabIndex = 11;
            txtAnswerB.TextChanged += txtAnswerB_TextChanged;
            // 
            // txtAnswerC
            // 
            txtAnswerC.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold | FontStyle.Italic);
            txtAnswerC.Location = new Point(973, 451);
            txtAnswerC.Name = "txtAnswerC";
            txtAnswerC.Size = new Size(200, 46);
            txtAnswerC.TabIndex = 12;
            txtAnswerC.TextChanged += txtAnswerC_TextChanged;
            // 
            // txtAnswerD
            // 
            txtAnswerD.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold | FontStyle.Italic);
            txtAnswerD.Location = new Point(973, 527);
            txtAnswerD.Name = "txtAnswerD";
            txtAnswerD.Size = new Size(200, 46);
            txtAnswerD.TabIndex = 13;
            txtAnswerD.TextChanged += txtAnswerD_TextChanged;
            // 
            // rbA
            // 
            rbA.AutoSize = true;
            rbA.BackColor = Color.Transparent;
            rbA.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rbA.ForeColor = Color.DarkSlateGray;
            rbA.Location = new Point(1221, 290);
            rbA.Name = "rbA";
            rbA.Size = new Size(251, 49);
            rbA.TabIndex = 14;
            rbA.TabStop = true;
            rbA.Text = "radioButton1";
            rbA.UseVisualStyleBackColor = false;
            rbA.CheckedChanged += rbA_CheckedChanged;
            // 
            // rbB
            // 
            rbB.AutoSize = true;
            rbB.BackColor = Color.Transparent;
            rbB.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rbB.ForeColor = Color.DarkSlateGray;
            rbB.Location = new Point(1221, 365);
            rbB.Name = "rbB";
            rbB.Size = new Size(251, 49);
            rbB.TabIndex = 15;
            rbB.TabStop = true;
            rbB.Text = "radioButton2";
            rbB.UseVisualStyleBackColor = false;
            rbB.CheckedChanged += rbB_CheckedChanged;
            // 
            // rbC
            // 
            rbC.AutoSize = true;
            rbC.BackColor = Color.Transparent;
            rbC.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rbC.ForeColor = Color.DarkSlateGray;
            rbC.Location = new Point(1221, 448);
            rbC.Name = "rbC";
            rbC.Size = new Size(251, 49);
            rbC.TabIndex = 16;
            rbC.TabStop = true;
            rbC.Text = "radioButton3";
            rbC.UseVisualStyleBackColor = false;
            rbC.CheckedChanged += rbC_CheckedChanged;
            // 
            // rbD
            // 
            rbD.AutoSize = true;
            rbD.BackColor = Color.Transparent;
            rbD.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rbD.ForeColor = Color.DarkSlateGray;
            rbD.Location = new Point(1221, 524);
            rbD.Name = "rbD";
            rbD.Size = new Size(251, 49);
            rbD.TabIndex = 17;
            rbD.TabStop = true;
            rbD.Text = "radioButton4";
            rbD.UseVisualStyleBackColor = false;
            rbD.CheckedChanged += rbD_CheckedChanged;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.DarkSeaGreen;
            btnEdit.Font = new Font("Segoe UI Variable Display", 10.875F, FontStyle.Bold);
            btnEdit.ForeColor = Color.DarkSlateGray;
            btnEdit.Location = new Point(367, 727);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(200, 99);
            btnEdit.TabIndex = 18;
            btnEdit.Text = "✏️Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Segoe UI Variable Display", 10.875F, FontStyle.Bold);
            btnDelete.ForeColor = Color.DarkSlateGray;
            btnDelete.Location = new Point(173, 894);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(268, 99);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "🗑️Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // lstQuestions
            // 
            lstQuestions.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstQuestions.ForeColor = Color.DarkSlateGray;
            lstQuestions.FormattingEnabled = true;
            lstQuestions.ItemHeight = 40;
            lstQuestions.Location = new Point(688, 628);
            lstQuestions.Name = "lstQuestions";
            lstQuestions.Size = new Size(659, 524);
            lstQuestions.TabIndex = 20;
            lstQuestions.SelectedIndexChanged += lstQuestions_SelectedIndexChanged;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.DarkSeaGreen;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.DarkSlateGray;
            btnExit.Location = new Point(1422, 1094);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(158, 82);
            btnExit.TabIndex = 21;
            btnExit.Text = "❌ Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(1068, 159);
            label1.Name = "label1";
            label1.Size = new Size(289, 45);
            label1.TabIndex = 22;
            label1.Text = "🌱 Question Text ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Variable Display", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(423, 86);
            label2.Name = "label2";
            label2.Size = new Size(609, 85);
            label2.TabIndex = 23;
            label2.Text = "CREAT QUESTIONS";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(91, 1094);
            button1.Margin = new Padding(5, 6, 5, 6);
            button1.Name = "button1";
            button1.Size = new Size(119, 71);
            button1.TabIndex = 24;
            button1.Text = "←";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.greno1;
            ClientSize = new Size(1608, 1206);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(lstQuestions);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(rbD);
            Controls.Add(rbC);
            Controls.Add(rbB);
            Controls.Add(rbA);
            Controls.Add(txtAnswerD);
            Controls.Add(txtAnswerC);
            Controls.Add(txtAnswerB);
            Controls.Add(txtAnswerA);
            Controls.Add(txtQuestion);
            Controls.Add(cmbDifficulty);
            Controls.Add(cmbType);
            Controls.Add(cmbCategory);
            Controls.Add(QDifficulty);
            Controls.Add(QCategory);
            Controls.Add(QType);
            Controls.Add(btnDisplay);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();


        }

        #endregion

        private Button btnAdd;
        private Button btnClear;
        private Button btnDisplay;
        private Label QType;
        private Label QCategory;
        private Label QDifficulty;
        private ComboBox cmbCategory;
        private ComboBox cmbType;
        private ComboBox cmbDifficulty;
        private TextBox txtQuestion;
        private TextBox txtAnswerA;
        private TextBox txtAnswerB;
        private TextBox txtAnswerC;
        private TextBox txtAnswerD;
        private RadioButton rbA;
        private RadioButton rbB;
        private RadioButton rbC;
        private RadioButton rbD;
        private Button btnEdit;
        private Button btnDelete;
        private ListBox lstQuestions;
        private Button btnExit;
        private Button button1;
        private Label label1;
        private Label label2;
    }
}