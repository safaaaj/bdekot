namespace Examineon
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Trebuchet MS", 36F, FontStyle.Bold);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(437, 113);
            label1.Name = "label1";
            label1.Size = new Size(797, 119);
            label1.TabIndex = 8;
            label1.Text = "WELCOME BACK!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(0, 90, 50);
            label2.Location = new Point(410, 375);
            label2.Name = "label2";
            label2.Size = new Size(305, 47);
            label2.TabIndex = 7;
            label2.Text = "Choose Your Role";
            label2.Click += label2_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.Honeydew;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Segoe UI", 12F);
            comboBox1.Items.AddRange(new object[] { "Student", "Lecturer" });
            comboBox1.Location = new Point(548, 457);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(380, 53);
            comboBox1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 90, 50);
            label3.Location = new Point(716, 576);
            label3.Name = "label3";
            label3.Size = new Size(169, 45);
            label3.TabIndex = 5;
            label3.Text = "Username";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Honeydew;
            textBox1.Font = new Font("Segoe UI", 11F);
            textBox1.Location = new Point(782, 659);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(380, 47);
            textBox1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 90, 50);
            label4.Location = new Point(437, 721);
            label4.Name = "label4";
            label4.Size = new Size(163, 45);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Honeydew;
            textBox2.Font = new Font("Segoe UI", 11F);
            textBox2.Location = new Point(499, 804);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(380, 47);
            textBox2.TabIndex = 2;
            textBox2.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(30, 120, 60);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(669, 978);
            button1.Name = "button1";
            button1.Size = new Size(200, 50);
            button1.TabIndex = 1;
            button1.Text = "LOG IN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(53, 1093);
            button3.Name = "button3";
            button3.Size = new Size(200, 90);
            button3.TabIndex = 0;
            button3.Text = "←";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 245, 233);
            BackgroundImage = Properties.Resources.login2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1608, 1206);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox2;
        private Button button1;
        private Button button3;
    }
}