using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Examineon;

namespace Examineon.Tests
{
    [TestClass]
    public class Form1Tests
    {
        [TestMethod]
        public void Constructor_InitializesDropdownsCorrectly()
        {
            Exception ex = null;
            Form1 form = null;

            var thread = new Thread(() =>
            {
                try
                {
                    form = new Form1();
                    form.Show();

                    var cmbType = form.Controls.Find("cmbType", true).FirstOrDefault() as ComboBox;
                    var cmbCategory = form.Controls.Find("cmbCategory", true).FirstOrDefault() as ComboBox;
                    var cmbDifficulty = form.Controls.Find("cmbDifficulty", true).FirstOrDefault() as ComboBox;

                    Assert.IsTrue(cmbType.Items.Count >= 2);
                    Assert.IsTrue(cmbCategory.Items.Count >= 3);
                    Assert.IsTrue(cmbDifficulty.Items.Count >= 3);
                }
                catch (Exception e)
                {
                    ex = e;
                }
            });

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();

            if (ex != null)
                Assert.Fail("Exception: " + ex);
        }

        [TestMethod]
        public void BtnAdd_Click_WithoutData_ShowsWarning()
        {
            var thread = new Thread(() =>
            {
                var form = new Form1();
                form.Show();

                var addButton = form.Controls.Find("btnAdd", true).FirstOrDefault() as Button;
                Assert.IsNotNull(addButton);
                addButton.PerformClick(); // Should trigger "Please fill in all..." MessageBox
            });

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();
        }

        [TestMethod]
        public void BtnDisplay_Click_NoCrash()
        {
            var thread = new Thread(() =>
            {
                var form = new Form1();
                form.Show();

                var btnDisplay = form.Controls.Find("btnDisplay", true).FirstOrDefault() as Button;
                Assert.IsNotNull(btnDisplay);
                btnDisplay.PerformClick(); // Smoke test
            });

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();
        }

        [TestMethod]
        public void BtnClear_Click_ClearsFields()
        {
            var thread = new Thread(() =>
            {
                var form = new Form1();
                form.Show();

                var txtQuestion = form.Controls.Find("txtQuestion", true).FirstOrDefault() as TextBox;
                var btnClear = form.Controls.Find("btnClear", true).FirstOrDefault() as Button;

                txtQuestion.Text = "Dummy question";
                btnClear.PerformClick();

                Assert.AreEqual("", txtQuestion.Text);
            });

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();
        }

        [TestMethod]
        public void BtnExit_Click_ClosesApp_Safely()
        {
            var thread = new Thread(() =>
            {
                var form = new Form1();
                form.Show();

                var btnExit = form.Controls.Find("btnExit", true).FirstOrDefault() as Button;
                Assert.IsNotNull(btnExit);
                btnExit.PerformClick(); // Application.Exit()
            });

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();
        }
    }
}
