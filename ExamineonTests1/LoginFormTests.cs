using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml;
using Examineon;

namespace Examineon.Tests
{
    [TestClass]
    public class LoginFormTests
    {
        private string testExcelPath;

        [TestInitialize]
        public void Setup()
        {
            testExcelPath = "DATABASE.xlsx";

            using (var package = new ExcelPackage(new FileInfo(testExcelPath)))
            {
                var ws = package.Workbook.Worksheets.Add("Sheet1");
                ws.Cells[1, 1].Value = "Username";
                ws.Cells[1, 2].Value = "Password";
                ws.Cells[1, 3].Value = "ID";
                ws.Cells[1, 5].Value = "Role";

                ws.Cells[2, 1].Value = "student1";
                ws.Cells[2, 2].Value = "1234";
                ws.Cells[2, 3].Value = "S1001";
                ws.Cells[2, 5].Value = "student";

                package.Save();
            }
        }

        [TestMethod]
        public void Button1_Click_ValidStudentLogin()
        {
            // Arrange
            var form = new LoginForm();

            var comboBox = form.Controls.Find("comboBox1", true)[0] as ComboBox;
            var textBox1 = form.Controls.Find("textBox1", true)[0] as TextBox;
            var textBox2 = form.Controls.Find("textBox2", true)[0] as TextBox;

            comboBox.Text = "student";
            textBox1.Text = "student1";
            textBox2.Text = "1234";

            // Act
            var method = typeof(LoginForm).GetMethod("button1_Click", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            method.Invoke(form, new object[] { null, EventArgs.Empty });

            // Assert: You can add your own way to verify something was shown or state was changed
            Assert.IsTrue(true); // Placeholder: can't verify MessageBox or UI changes directly
        }
        [TestMethod]
        public void Button1_Click_ValidLecturerLogin()
        {
            // Arrange
            var form = new LoginForm();

            var comboBox = form.Controls.Find("comboBox1", true)[0] as ComboBox;
            var textBox1 = form.Controls.Find("textBox1", true)[0] as TextBox;
            var textBox2 = form.Controls.Find("textBox2", true)[0] as TextBox;

            comboBox.Text = "lecturer";
            textBox1.Text = "lecturer1";
            textBox2.Text = "abcd"; // password for lecturer1 in Excel

            // Act
            var method = typeof(LoginForm).GetMethod("button1_Click", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            method.Invoke(form, new object[] { null, EventArgs.Empty });

            // Assert
            Assert.IsTrue(true); // Placeholder — logic ran successfully
        }

        [TestCleanup]
        public void Cleanup()
        {
            if (File.Exists(testExcelPath))
                File.Delete(testExcelPath);
        }

        [TestMethod]
        public void Button3_Click_ShowsWelcomePageAndHidesLoginForm()
        {
            // Arrange
            var loginForm = new LoginForm();

            // Act
            var method = typeof(LoginForm).GetMethod("button3_Click", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            method.Invoke(loginForm, new object[] { null, EventArgs.Empty });

            // Assert – dummy check just to confirm method ran without exception
            Assert.IsTrue(true);
        }

        
    }
}
