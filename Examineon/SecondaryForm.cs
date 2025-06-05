using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;

namespace Examineon
{
    public partial class SecondaryForm : Form
    {
        
        private string userRole;

        private string studentId;

        public SecondaryForm(string role, string studentId)
        {
            InitializeComponent();
            this.studentId = studentId;

            userRole = role;


            this.Text = $"Logged in as {userRole}";
        }

        private void btnPracticeExam_Click(object sender, EventArgs e)
        {
            PracticeSetupForm setupForm = new PracticeSetupForm();
            setupForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExamSetup setupForm = new ExamSetup(studentId);
            setupForm.Show();
            this.Hide();
        }
        private void btnViewScores_Click(object sender, EventArgs e)
        {
            StudentScoresForm scoresForm = new StudentScoresForm(studentId);
            scoresForm.Show();
        }



        private void SecondaryForm_Load(object sender, EventArgs e)
        {

        }
    }
}
