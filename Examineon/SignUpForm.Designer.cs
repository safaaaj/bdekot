namespace Examineon
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            button1 = new Button();
            label6 = new Label();
            comboBox1 = new ComboBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(490, 114);
            label1.Name = "label1";
            label1.Size = new Size(743, 128);
            label1.TabIndex = 0;
            label1.Text = "Create Account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(0, 90, 50);
            label2.Location = new Point(446, 413);
            label2.Name = "label2";
            label2.Size = new Size(169, 45);
            label2.TabIndex = 1;
            label2.Text = "Username";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(318, 482);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(400, 39);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(0, 90, 50);
            label3.Location = new Point(1020, 384);
            label3.Name = "label3";
            label3.Size = new Size(163, 45);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(888, 467);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(400, 39);
            textBox2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(0, 90, 50);
            label4.Location = new Point(388, 602);
            label4.Name = "label4";
            label4.Size = new Size(54, 45);
            label4.TabIndex = 5;
            label4.Text = "ID";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(224, 657);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(400, 39);
            textBox3.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(0, 90, 50);
            label5.Location = new Point(953, 602);
            label5.Name = "label5";
            label5.Size = new Size(231, 45);
            label5.TabIndex = 7;
            label5.Text = "Email Address";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(847, 686);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(400, 39);
            textBox4.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(30, 120, 60);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(587, 1003);
            button1.Name = "button1";
            button1.Size = new Size(300, 55);
            button1.TabIndex = 11;
            button1.Text = "SIGN UP";
            button1.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 90, 50);
            label6.Location = new Point(715, 769);
            label6.Name = "label6";
            label6.Size = new Size(99, 50);
            label6.TabIndex = 9;
            label6.Text = "Role";
            // 
            // comboBox1
            // 
            comboBox1.Items.AddRange(new object[] { "Student", "Lecturer" });
            comboBox1.Location = new Point(570, 836);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(400, 40);
            comboBox1.TabIndex = 10;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(63, 1115);
            button3.Name = "button3";
            button3.Size = new Size(200, 90);
            button3.TabIndex = 12;
            button3.Text = "←";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.login2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1542, 1229);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(button3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SignUpForm";
            Text = "SignUpForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        // Fields
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
        private Button button1;
        private Label label6;
        private ComboBox comboBox1;
        private Button button3;
    }
}