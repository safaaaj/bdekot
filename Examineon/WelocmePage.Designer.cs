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
            label1.Font = new Font("Trebuchet MS", 25.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(294, 273);
            label1.Name = "label1";
            label1.Size = new Size(411, 86);
            label1.TabIndex = 0;
            label1.Text = "EXAMINEON";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(358, 374);
            label2.Name = "label2";
            label2.Size = new Size(270, 32);
            label2.TabIndex = 1;
            label2.Text = "Welcome to Examineon";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 7.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(172, 406);
            label3.Name = "label3";
            label3.Size = new Size(633, 30);
            label3.TabIndex = 2;
            label3.Text = "your smart platform for managing exams and practice questions";
            // 
            // button1
            // 
            button1.Font = new Font("Trebuchet MS", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(114, 526);
            button1.Name = "button1";
            button1.Size = new Size(299, 72);
            button1.TabIndex = 3;
            button1.Text = "login";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Trebuchet MS", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(507, 532);
            button2.Name = "button2";
            button2.Size = new Size(311, 66);
            button2.TabIndex = 4;
            button2.Text = "SignUp";
            button2.UseVisualStyleBackColor = true;
            // 
            // WelocmePage
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 982);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "WelocmePage";
            Text = "WelocmePage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
    }
}