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
            label1.Font = new Font("Yu Gothic UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(121, 31);
            label1.Name = "label1";
            label1.Size = new Size(720, 128);
            label1.TabIndex = 0;
            label1.Text = "Create Accout !";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(404, 316);
            label2.Name = "label2";
            label2.Size = new Size(155, 37);
            label2.TabIndex = 1;
            label2.Text = "Username ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(285, 387);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(393, 39);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(414, 453);
            label3.Name = "label3";
            label3.Size = new Size(145, 37);
            label3.TabIndex = 3;
            label3.Text = "Passowrd ";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(285, 524);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(393, 39);
            textBox2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(452, 591);
            label4.Name = "label4";
            label4.Size = new Size(52, 37);
            label4.TabIndex = 5;
            label4.Text = "ID ";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(285, 654);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(393, 39);
            textBox3.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(394, 725);
            label5.Name = "label5";
            label5.Size = new Size(189, 37);
            label5.TabIndex = 7;
            label5.Text = "Email Adress ";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(285, 791);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(393, 39);
            textBox4.TabIndex = 8;
            // 
            // button1
            // 
            button1.Font = new Font("Yu Gothic", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(338, 891);
            button1.Name = "button1";
            button1.Size = new Size(275, 49);
            button1.TabIndex = 9;
            button1.Text = "SIGN UP ";
            button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Trebuchet MS", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(432, 184);
            label6.Name = "label6";
            label6.Size = new Size(83, 37);
            label6.TabIndex = 11;
            label6.Text = "Role ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Student ", "Lecturer" });
            comboBox1.Location = new Point(285, 241);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(393, 40);
            comboBox1.TabIndex = 12;
            // 
            // button3
            // 
            button3.Location = new Point(50, 1042);
            button3.Name = "button3";
            button3.Size = new Size(76, 43);
            button3.TabIndex = 13;
            button3.Text = "<--";
            button3.UseVisualStyleBackColor = true;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 1117);
            Controls.Add(button3);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SignUpForm";
            Text = "SignUpForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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