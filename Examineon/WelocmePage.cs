using System;
using System.Windows.Forms;

namespace Examineon
{
    public partial class WelocmePage : Form
    {
        public WelocmePage()
        {
            InitializeComponent();
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button2.Click += new System.EventHandler(this.button2_Click);
            button1.UseVisualStyleBackColor = true;
            button2.UseVisualStyleBackColor = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignUpForm signup = new SignUpForm();
            signup.Show();
            this.Hide();
        }

    }
}