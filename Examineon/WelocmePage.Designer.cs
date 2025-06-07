namespace Examineon
{
    partial class WelocmePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelocmePage));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(34, 139, 34);
            label1.Location = new Point(503, 402);
            label1.Name = "label1";
            label1.Size = new Size(530, 106);
            label1.TabIndex = 5;
            label1.Text = "EXAMINEON";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.ForeColor = Color.DarkOliveGreen;
            label2.Location = new Point(551, 539);
            label2.Name = "label2";
            label2.Size = new Size(443, 51);
            label2.TabIndex = 4;
            label2.Text = "Welcome to Examineon";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            label3.ForeColor = Color.FromArgb(60, 80, 60);
            label3.Location = new Point(393, 637);
            label3.Name = "label3";
            label3.Size = new Size(770, 37);
            label3.TabIndex = 3;
            label3.Text = "Your smart platform for managing exams and practice questions";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(46, 139, 87);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(432, 742);
            button1.Name = "button1";
            button1.Size = new Size(240, 60);
            button1.TabIndex = 2;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SeaGreen;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(841, 742);
            button2.Name = "button2";
            button2.Size = new Size(240, 60);
            button2.TabIndex = 1;
            button2.Text = "Sign Up";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // WelocmePage
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            BackgroundImage = Properties.Resources.welcome;
            ClientSize = new Size(1537, 1025);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "WelocmePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Welcome to Examineon";
            Load += WelocmePage_Load;
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

    }
}