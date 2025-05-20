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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(106, 87);
            label1.Name = "label1";
            label1.Size = new Size(760, 119);
            label1.TabIndex = 0;
            label1.Text = "Welcome Back !";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(310, 274);
            label2.Name = "label2";
            label2.Size = new Size(288, 45);
            label2.TabIndex = 1;
            label2.Text = "Choose Your Role :";
            label2.Click += label2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Student ", "Lecturer" });
            comboBox1.Location = new Point(251, 354);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(400, 40);
            comboBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(355, 424);
            label3.Name = "label3";
            label3.Size = new Size(179, 45);
            label3.TabIndex = 4;
            label3.Text = "Username :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(251, 503);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(400, 39);
            textBox1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(365, 592);
            label4.Name = "label4";
            label4.Size = new Size(169, 45);
            label4.TabIndex = 6;
            label4.Text = "Password :";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(239, 684);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(400, 39);
            textBox2.TabIndex = 7;
            // 
            // button1
            // 
            button1.Font = new Font("Yu Gothic", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(300, 800);
            button1.Name = "button1";
            button1.Size = new Size(282, 62);
            button1.TabIndex = 8;
            button1.Text = "LOG IN";
            button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);

            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(960, 982);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
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
    }
}