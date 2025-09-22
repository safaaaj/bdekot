using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Examineon
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private string userRole;

        public MainForm(string role)
        {
            InitializeComponent();

            userRole = role;


            this.Text = $"Logged in as {userRole}";
            btnTeacherPage.Click += btnTeacherPage_Click;

            if (userRole != "lecturer")
            {
                btnOpenAnalysis.Enabled = false;
                btnOpenAnalysis.Visible = false;
            }
        }


        private void btnCreateQ_Click(object sender, EventArgs e)
        {

            Form1 form1 = new Form1();
            form1.Show();// or use .Show() if you want it modeless
        }


        private void MainForm_Load_1(object sender, EventArgs e)
        {

        }

        private void MainForm_Load_2(object sender, EventArgs e)
        {

        }

        private void btnTeacherPage_Click(object sender, EventArgs e)
        {
            CreateExam createExamForm = new CreateExam();
            createExamForm.Show();
            this.Hide();
        }
        private void btnOpenAnalysis_Click(object sender, EventArgs e)
        {
            LecturerAnalysisForm analysisForm = new LecturerAnalysisForm();
            analysisForm.Show();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Where do you want to go?\nYes = Login\nNo = Sign Up",
                "Choose Destination",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
            else if (result == DialogResult.No)
            {
                SignUpForm signUpForm = new SignUpForm();
                signUpForm.Show();
                this.Hide();
            }
            // If Cancel, do nothing
        }

       
    }

}
