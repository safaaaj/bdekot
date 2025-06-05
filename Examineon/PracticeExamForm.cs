using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;




namespace Examineon
    {
    public partial class PracticeExamForm : Form
    {
        private List<Question> questions;
        private int currentIndex = 0;
        private int score = 0;
        private string selectedSubject;
        private string selectedDifficulty;

        public PracticeExamForm(string subject, string difficulty, List<Question> questions)
        {
            InitializeComponent();
            this.selectedSubject = subject;
            this.selectedDifficulty = difficulty;
            this.questions = questions;

            // ❌ Don’t show message here. Questions are already validated before calling this.
            if (questions.Count > 0)
                ShowQuestion(0);
        }


        private void ShowQuestion(int index)
        {
            var q = questions[index];
            label1.Text = q.QuestionText;
            rbA.Text = q.AnswerA;
            rbB.Text = q.AnswerB;
            rbC.Text = q.AnswerC;
            rbD.Text = q.AnswerD;

            rbA.Checked = rbB.Checked = rbC.Checked = rbD.Checked = false;
        }

        private void CheckAnswer()
        {
            string selected = "";
            if (rbA.Checked) selected = "A";
            else if (rbB.Checked) selected = "B";
            else if (rbC.Checked) selected = "C";
            else if (rbD.Checked) selected = "D";

            if (selected == questions[currentIndex].CorrectAnswer)
                score++;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentIndex < questions.Count)
            {
                CheckAnswer();
                currentIndex++;
            }

            if (currentIndex < questions.Count)
            {
                ShowQuestion(currentIndex);
            }
            else
            {
                btnNext.Enabled = false; // Disable the Next button
                btnSubmit.Visible = true; // Show Submit when questions are done
                MessageBox.Show("You finished all questions. Click Submit!");
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (currentIndex < questions.Count)
                CheckAnswer();

            double percentage = ((double)score / questions.Count) * 100;
            MessageBox.Show($"Your score: {percentage:F2}%");

            var setupForm = new PracticeSetupForm();
            setupForm.Show();
            this.Close();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PracticeExamForm_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                ShowQuestion(currentIndex);
            }
            else
            {
                MessageBox.Show("This is the first question.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

