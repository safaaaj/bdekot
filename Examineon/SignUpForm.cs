using OfficeOpenXml;
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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
            OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;


            comboBox1.SelectedIndex = 0;

            button1.Click += Button1_Click;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();
            string id = textBox3.Text.Trim();
            string email = textBox4.Text.Trim();
            string role = comboBox1.SelectedItem?.ToString().Trim().ToLower();

            // === FIELD VALIDATION ===

            // Username: 6-8 chars, only letters + max 2 digits
            if (username.Length < 6 || username.Length > 8 ||
                username.Count(char.IsDigit) > 2 ||
                !username.All(c => char.IsLetterOrDigit(c)) ||
                username.Any(c => !char.IsLetterOrDigit(c)))
            {
                MessageBox.Show("Username must be 6-8 characters, letters only, and contain up to 2 digits.", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Password: 8-10 chars, at least 1 letter, 1 digit, 1 special char
            if (password.Length < 8 || password.Length > 10 ||
                !password.Any(char.IsLetter) ||
                !password.Any(char.IsDigit) ||
                !password.Any(c => "!@#$%^&*".Contains(c)))
            {
                MessageBox.Show("Password must be 8-10 characters long and include at least one letter, one digit, and one special character (!@#$%^&*).", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ID: must be exactly 9 digits
            if (id.Length != 9 || !id.All(char.IsDigit))
            {
                MessageBox.Show("ID must be exactly 9 digits and numeric only.", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Email: must end with @gmail.com
            if (!email.EndsWith("@gmail.com", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Email must be a valid Gmail address (e.g. example@gmail.com).", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Role: required
            if (string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please select a role.", "Missing Role", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // === SAVE TO EXCEL ===

            var file = new FileInfo("DATABASE.xlsx");
            bool fileExists = file.Exists;

            using (var package = new ExcelPackage(file))
            {
                ExcelWorksheet ws = package.Workbook.Worksheets.FirstOrDefault(w => w.Name == "Users");
                if (ws == null)
                {
                    ws = package.Workbook.Worksheets.Add("Users");
                    ws.Cells[1, 1].Value = "Username";
                    ws.Cells[1, 2].Value = "Password";
                    ws.Cells[1, 3].Value = "ID";
                    ws.Cells[1, 4].Value = "Email";
                    ws.Cells[1, 5].Value = "Role";
                }

                int newRow = ws.Dimension?.End.Row + 1 ?? 2;

                for (int row = 2; row < newRow; row++)
                {
                    if (ws.Cells[row, 1].Text.Trim().ToLower() == username.ToLower())
                    {
                        MessageBox.Show("Username already exists. Please choose another.", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (ws.Cells[row, 3].Text.Trim() == id)
                    {
                        MessageBox.Show("This ID is already registered. Please use a different ID.", "Duplicate ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }


                ws.Cells[newRow, 1].Value = username;
                ws.Cells[newRow, 2].Value = password;
                ws.Cells[newRow, 3].Value = id;
                ws.Cells[newRow, 4].Value = email;
                ws.Cells[newRow, 5].Value = role;

                package.Save();

            }


            MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            this.Hide();

            if (role == "lecturer")
            {
                MainForm main = new MainForm(role);
                main.Show();
            }
            else if (role == "student")
            {
                SecondaryForm secondary = new SecondaryForm(role, id);
                secondary.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WelocmePage welcome = new WelocmePage();
            welcome.Show();
            this.Hide(); 

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}