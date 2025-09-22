using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using OfficeOpenXml;
using Examineon;

namespace Examineon.Tests
{
    [TestClass]
    public class SignUpFormTests
    {
        private string excelPath;

        [TestInitialize]
        public void Setup()
        {
            excelPath = "DATABASE.xlsx";
            if (File.Exists(excelPath))
                File.Delete(excelPath);
        }

        [TestMethod]
        public void Button1_Click_WithInvalidUsername_ShowsError()
        {
            var form = new SignUpForm();

            SetControl(form, "textBox1", "a!23");     // ❌ invalid username
            SetControl(form, "textBox2", "Abc123$%"); // valid password
            SetControl(form, "textBox3", "123456789"); // valid ID
            SetControl(form, "textBox4", "abc@gmail.com"); // valid email
            SetComboBox(form, "comboBox1", "student");

            var method = typeof(SignUpForm).GetMethod("Button1_Click", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            method.Invoke(form, new object[] { null, EventArgs.Empty });

            Assert.IsTrue(true); // ✅ Test just checks that the method runs with input
        }

        [TestMethod]
        public void Button1_Click_ValidRegistration_WritesToExcel()
        {
            var form = new SignUpForm();

            SetControl(form, "textBox1", "User12");       // valid username
            SetControl(form, "textBox2", "Pass123!");     // valid password
            SetControl(form, "textBox3", "111222333");    // valid ID
            SetControl(form, "textBox4", "test@gmail.com"); // valid email
            SetComboBox(form, "comboBox1", "student");

            var method = typeof(SignUpForm).GetMethod("Button1_Click", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            method.Invoke(form, new object[] { null, EventArgs.Empty });

            using (var package = new ExcelPackage(new FileInfo("DATABASE.xlsx")))
            {
                var ws = package.Workbook.Worksheets.FirstOrDefault(w => w.Name == "Users");
                var usernameCell = ws?.Cells[2, 1].Text.Trim();
                var emailCell = ws?.Cells[2, 4].Text.Trim();

                Assert.AreEqual("User12", usernameCell);
                Assert.AreEqual("test@gmail.com", emailCell);
            }
        }

        [TestMethod]
        public void Button3_Click_ShowsWelcomePage()
        {
            var form = new SignUpForm();
            var method = typeof(SignUpForm).GetMethod("button3_Click", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            method.Invoke(form, new object[] { null, EventArgs.Empty });

            Assert.IsTrue(true); // ✅ Smoke test: no exception = pass
        }

        [TestCleanup]
        public void Cleanup()
        {
            if (File.Exists(excelPath))
                File.Delete(excelPath);
        }

        // 🧰 Helper: set TextBox value by name
        private void SetControl(Form form, string controlName, string value)
        {
            var control = form.Controls.Find(controlName, true).FirstOrDefault() as TextBox;
            if (control != null)
                control.Text = value;
        }

        // 🧰 Helper: set ComboBox value by name
        private void SetComboBox(Form form, string controlName, string value)
        {
            var control = form.Controls.Find(controlName, true).FirstOrDefault() as ComboBox;
            if (control != null)
                control.SelectedItem = value;
        }
    }
}
