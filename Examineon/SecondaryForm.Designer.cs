namespace Examineon
{
    partial class SecondaryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecondaryForm));
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(202, 880);
            button2.Name = "button2";
            button2.Size = new Size(88, 43);
            button2.TabIndex = 6;
            button2.Text = "-->";
            button2.UseVisualStyleBackColor = true;
           // button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(108, 880);
            button1.Name = "button1";
            button1.Size = new Size(88, 43);
            button1.TabIndex = 5;
            button1.Text = "<--";
            button1.UseVisualStyleBackColor = true;
         //   button1.Click += button1_Click;
            // 
            // SecondaryForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1463, 999);
            Controls.Add(button2);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SecondaryForm";
            Text = "SecondaryForm";
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
        private Button button1;
    }
}