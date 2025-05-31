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
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(224, 469);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(257, 102);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(532, 469);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(257, 102);
            btnClear.TabIndex = 1;
            btnClear.Text = "clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDisplay
            // 
            btnDisplay.Location = new Point(818, 469);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(257, 102);
            btnDisplay.TabIndex = 2;
            btnDisplay.Text = "display";
            btnDisplay.UseVisualStyleBackColor = true;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // QType
            // 
            QType.AutoSize = true;
            QType.Location = new Point(34, 92);
            QType.Name = "QType";
            QType.Size = new Size(169, 32);
            QType.TabIndex = 3;
            QType.Text = "Question Type";
            // 
            // QCategory
            // 
            QCategory.AutoSize = true;
            QCategory.Location = new Point(34, 144);
            QCategory.Name = "QCategory";
            QCategory.Size = new Size(214, 32);
            QCategory.TabIndex = 4;
            QCategory.Text = "Question Category";
            // 
            // QDifficulty
            // 
            QDifficulty.AutoSize = true;
            QDifficulty.Location = new Point(34, 211);
            QDifficulty.Name = "QDifficulty";
            QDifficulty.Size = new Size(214, 32);
            QDifficulty.TabIndex = 5;
            QDifficulty.Text = "Question Difficulty";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(254, 144);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(242, 40);
            cmbCategory.TabIndex = 6;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(254, 89);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(242, 40);
            cmbType.TabIndex = 7;
            cmbType.SelectedIndexChanged += cmbType_SelectedIndexChanged;
            // 
            // cmbDifficulty
            // 
            cmbDifficulty.FormattingEnabled = true;
            cmbDifficulty.Location = new Point(254, 203);
            cmbDifficulty.Name = "cmbDifficulty";
            cmbDifficulty.Size = new Size(242, 40);
            cmbDifficulty.TabIndex = 8;
            cmbDifficulty.SelectedIndexChanged += cmbDifficulty_SelectedIndexChanged;
            // 
            // txtQuestion
            // 
            txtQuestion.Location = new Point(747, 107);
            txtQuestion.Name = "txtQuestion";
            txtQuestion.Size = new Size(200, 39);
            txtQuestion.TabIndex = 9;
            txtQuestion.TextChanged += txtQuestion_TextChanged;
            // 
            // txtAnswerA
            // 
            txtAnswerA.Location = new Point(747, 174);
            txtAnswerA.Name = "txtAnswerA";
            txtAnswerA.Size = new Size(200, 39);
            txtAnswerA.TabIndex = 10;
            txtAnswerA.TextChanged += txtAnswerA_TextChanged;
            // 
            // txtAnswerB
            // 
            txtAnswerB.Location = new Point(747, 241);
            txtAnswerB.Name = "txtAnswerB";
            txtAnswerB.Size = new Size(200, 39);
            txtAnswerB.TabIndex = 11;
            txtAnswerB.TextChanged += txtAnswerB_TextChanged;
            // 
            // txtAnswerC
            // 
            txtAnswerC.Location = new Point(747, 308);
            txtAnswerC.Name = "txtAnswerC";
            txtAnswerC.Size = new Size(200, 39);
            txtAnswerC.TabIndex = 12;
            txtAnswerC.TextChanged += txtAnswerC_TextChanged;
            // 
            // txtAnswerD
            // 
            txtAnswerD.Location = new Point(747, 380);
            txtAnswerD.Name = "txtAnswerD";
            txtAnswerD.Size = new Size(200, 39);
            txtAnswerD.TabIndex = 13;
            txtAnswerD.TextChanged += txtAnswerD_TextChanged;
            // 
            // rbA
            // 
            rbA.AutoSize = true;
            rbA.Location = new Point(1002, 174);
            rbA.Name = "rbA";
            rbA.Size = new Size(184, 36);
            rbA.TabIndex = 14;
            rbA.TabStop = true;
            rbA.Text = "radioButton1";
            rbA.UseVisualStyleBackColor = true;
            rbA.CheckedChanged += rbA_CheckedChanged;
            // 
            // rbB
            // 
            rbB.AutoSize = true;
            rbB.Location = new Point(1002, 241);
            rbB.Name = "rbB";
            rbB.Size = new Size(184, 36);
            rbB.TabIndex = 15;
            rbB.TabStop = true;
            rbB.Text = "radioButton2";
            rbB.UseVisualStyleBackColor = true;
            rbB.CheckedChanged += rbB_CheckedChanged;
            // 
            // rbC
            // 
            rbC.AutoSize = true;
            rbC.Location = new Point(1002, 308);
            rbC.Name = "rbC";
            rbC.Size = new Size(184, 36);
            rbC.TabIndex = 16;
            rbC.TabStop = true;
            rbC.Text = "radioButton3";
            rbC.UseVisualStyleBackColor = true;
            rbC.CheckedChanged += rbC_CheckedChanged;
            // 
            // rbD
            // 
            rbD.AutoSize = true;
            rbD.Location = new Point(1002, 383);
            rbD.Name = "rbD";
            rbD.Size = new Size(184, 36);
            rbD.TabIndex = 17;
            rbD.TabStop = true;
            rbD.Text = "radioButton4";
            rbD.UseVisualStyleBackColor = true;
            rbD.CheckedChanged += rbD_CheckedChanged;
            // 
            // button2
            // 
            button2.Location = new Point(287, 878);
            button2.Name = "button2";
            button2.Size = new Size(88, 43);
            button2.TabIndex = 19;
            button2.Text = "-->";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(193, 878);
            button1.Name = "button1";
            button1.Size = new Size(88, 43);
            button1.TabIndex = 18;
            button1.Text = "<--";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1597, 1015);
            Controls.Add(button2);
            Controls.Add(button1);
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
        private Button button2;
        private Button button1;
    }
}