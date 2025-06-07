using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using System.IO;


namespace Examineon
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedRole = comboBox1.Text.Trim().ToLower(); // "student" or "lecturer"
            string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();


            // ✅ Basic validation
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(selectedRole))
            {
                MessageBox.Show("Please fill in all login fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var file = new FileInfo("DATABASE.xlsx");
            if (!file.Exists)
            {
                MessageBox.Show("User database not found.");
                return;
            }

            bool isValidUser = false;


            string studentId = "";

            using (var package = new ExcelPackage(file))
            {
                var ws = package.Workbook.Worksheets[0];
                int rowCount = ws.Dimension.End.Row;

                for (int row = 2; row <= rowCount; row++)
                {
                    string fileUser = ws.Cells[row, 1].Text.Trim();
                    string filePass = ws.Cells[row, 2].Text.Trim();
                    string fileRole = ws.Cells[row, 5].Text.Trim().ToLower();

                    if (fileUser == username && filePass == password && fileRole == selectedRole)
                    {
                        isValidUser = true;
                        studentId = ws.Cells[row, 3].Text.Trim();
                    }
                }
            }


            if (isValidUser)
            {
                MessageBox.Show($"Welcome {username}! You are logged in as a {selectedRole}.");


                if (selectedRole == "lecturer")
                {
                    MainForm main = new MainForm(selectedRole);
                    main.Show();
                }
                else if (selectedRole == "student")
                {
                    SecondaryForm secondary = new SecondaryForm(selectedRole, studentId);
                    secondary.Show();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username, password, or role.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            WelocmePage welcome = new WelocmePage();
            welcome.Show();
            this.Hide();
           
        }

        
    }
}
