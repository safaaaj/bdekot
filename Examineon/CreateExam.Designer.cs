namespace Examineon
{
    partial class CreateExam
    {
        private System.ComponentModel.IContainer components = null;

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateExam));
            chkRandomTopics = new CheckBox();
            btnCreateExam = new Button();
            cmbDifficulty = new ComboBox();
            label4 = new Label();
            clbTopics = new CheckedListBox();
            label3 = new Label();
            nudNumQuestions = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            dgvAvailableQuestions = new DataGridView();
            dgvExams = new DataGridView();
            btnDeleteExam = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)nudNumQuestions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAvailableQuestions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvExams).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // chkRandomTopics
            // 
            chkRandomTopics.BackColor = Color.Transparent;
            chkRandomTopics.FlatStyle = FlatStyle.Flat;
            chkRandomTopics.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            chkRandomTopics.ForeColor = Color.Teal;
            chkRandomTopics.Location = new Point(128, 735);
            chkRandomTopics.Margin = new Padding(5, 6, 5, 6);
            chkRandomTopics.Name = "chkRandomTopics";
            chkRandomTopics.Size = new Size(532, 60);
            chkRandomTopics.TabIndex = 5;
            chkRandomTopics.Text = "Random topics instead";
            chkRandomTopics.UseVisualStyleBackColor = false;
            // 
            // btnCreateExam
            // 
            btnCreateExam.BackColor = Color.MediumSeaGreen;
            btnCreateExam.FlatStyle = FlatStyle.Flat;
            btnCreateExam.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateExam.ForeColor = Color.White;
            btnCreateExam.Location = new Point(47, 1131);
            btnCreateExam.Margin = new Padding(5, 6, 5, 6);
            btnCreateExam.Name = "btnCreateExam";
            btnCreateExam.Size = new Size(325, 100);
            btnCreateExam.TabIndex = 8;
            btnCreateExam.Text = "➕  Create Exam";
            btnCreateExam.UseVisualStyleBackColor = false;
            btnCreateExam.Click += btnCreateExam_Click;
            // 
            // cmbDifficulty
            // 
            cmbDifficulty.BackColor = Color.White;
            cmbDifficulty.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDifficulty.FlatStyle = FlatStyle.Flat;
            cmbDifficulty.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbDifficulty.ForeColor = Color.Black;
            cmbDifficulty.Items.AddRange(new object[] { "Easy", "Medium", "Hard" });
            cmbDifficulty.Location = new Point(338, 878);
            cmbDifficulty.Margin = new Padding(5, 6, 5, 6);
            cmbDifficulty.Name = "cmbDifficulty";
            cmbDifficulty.Size = new Size(322, 53);
            cmbDifficulty.TabIndex = 7;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkSlateGray;
            label4.Location = new Point(32, 871);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(272, 60);
            label4.TabIndex = 6;
            label4.Text = "Difficulty Level:";
            // 
            // clbTopics
            // 
            clbTopics.BackColor = SystemColors.Menu;
            clbTopics.CheckOnClick = true;
            clbTopics.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clbTopics.ForeColor = Color.DarkSlateGray;
            clbTopics.Items.AddRange(new object[] { "English", "Math", "Hebrew" });
            clbTopics.Location = new Point(316, 527);
            clbTopics.Margin = new Padding(5, 6, 5, 6);
            clbTopics.Name = "clbTopics";
            clbTopics.Size = new Size(264, 133);
            clbTopics.TabIndex = 4;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(47, 527);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(271, 60);
            label3.TabIndex = 3;
            label3.Text = "Select Topics:";
            label3.Click += label3_Click;
            // 
            // nudNumQuestions
            // 
            nudNumQuestions.BackColor = Color.White;
            nudNumQuestions.BorderStyle = BorderStyle.FixedSingle;
            nudNumQuestions.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nudNumQuestions.ForeColor = Color.Black;
            nudNumQuestions.Location = new Point(421, 397);
            nudNumQuestions.Margin = new Padding(5, 6, 5, 6);
            nudNumQuestions.Name = "nudNumQuestions";
            nudNumQuestions.Size = new Size(206, 46);
            nudNumQuestions.TabIndex = 2;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(32, 389);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(379, 54);
            label2.TabIndex = 1;
            label2.Text = "Number of Questions";
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(629, 37);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(411, 130);
            label1.TabIndex = 0;
            label1.Text = "Create Exam";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // dgvAvailableQuestions
            // 
            dgvAvailableQuestions.BackgroundColor = Color.White;
            dgvAvailableQuestions.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAvailableQuestions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAvailableQuestions.ColumnHeadersHeight = 46;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Honeydew;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvAvailableQuestions.DefaultCellStyle = dataGridViewCellStyle2;
            dgvAvailableQuestions.EnableHeadersVisualStyles = false;
            dgvAvailableQuestions.Location = new Point(866, 238);
            dgvAvailableQuestions.Margin = new Padding(4);
            dgvAvailableQuestions.Name = "dgvAvailableQuestions";
            dgvAvailableQuestions.RowHeadersWidth = 82;
            dgvAvailableQuestions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAvailableQuestions.Size = new Size(1385, 360);
            dgvAvailableQuestions.TabIndex = 13;
            // 
            // dgvExams
            // 
            dgvExams.BackgroundColor = Color.White;
            dgvExams.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvExams.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvExams.ColumnHeadersHeight = 46;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Honeydew;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvExams.DefaultCellStyle = dataGridViewCellStyle4;
            dgvExams.EnableHeadersVisualStyles = false;
            dgvExams.Location = new Point(866, 682);
            dgvExams.Margin = new Padding(4);
            dgvExams.Name = "dgvExams";
            dgvExams.RowHeadersWidth = 82;
            dgvExams.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvExams.Size = new Size(1385, 360);
            dgvExams.TabIndex = 14;
            // 
            // btnDeleteExam
            // 
            btnDeleteExam.BackColor = Color.IndianRed;
            btnDeleteExam.FlatStyle = FlatStyle.Flat;
            btnDeleteExam.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteExam.ForeColor = Color.White;
            btnDeleteExam.Location = new Point(426, 1131);
            btnDeleteExam.Margin = new Padding(5, 6, 5, 6);
            btnDeleteExam.Name = "btnDeleteExam";
            btnDeleteExam.Size = new Size(325, 100);
            btnDeleteExam.TabIndex = 9;
            btnDeleteExam.Text = "🗑  Delete Exam";
            btnDeleteExam.UseVisualStyleBackColor = false;
            btnDeleteExam.Click += btnDeleteExam_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(48, 1410);
            button1.Margin = new Padding(5, 6, 5, 6);
            button1.Name = "button1";
            button1.Size = new Size(119, 71);
            button1.TabIndex = 10;
            button1.Text = "←";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.ColumnHeadersHeight = 46;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.Honeydew;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(856, 1131);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1385, 360);
            dataGridView1.TabIndex = 0;
            // 
            // CreateExam
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 245, 240);
            BackgroundImage = Properties.Resources.greno1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(2361, 1551);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(nudNumQuestions);
            Controls.Add(label3);
            Controls.Add(clbTopics);
            Controls.Add(chkRandomTopics);
            Controls.Add(label4);
            Controls.Add(cmbDifficulty);
            Controls.Add(btnCreateExam);
            Controls.Add(btnDeleteExam);
            Controls.Add(button1);
            Controls.Add(dgvAvailableQuestions);
            Controls.Add(dgvExams);
            Controls.Add(dataGridView1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 9F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreateExam";
            Text = "Create Exam";
            Load += CreateExam_Load;
            ((System.ComponentModel.ISupportInitialize)nudNumQuestions).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAvailableQuestions).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvExams).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        private void BtnCreateExam_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private CheckBox chkRandomTopics;
        private Button btnCreateExam;
        private Button btnDeleteExam;
        private ComboBox cmbDifficulty;
        private Label label4;
        private CheckedListBox clbTopics;
        private Label label3;
        private NumericUpDown nudNumQuestions;
        private Label label2;
        private Label label1;
        private DataGridView dgvAvailableQuestions;
        private DataGridView dgvExams;
        private Button button1;
        private DataGridView dataGridView1;
    }
}
