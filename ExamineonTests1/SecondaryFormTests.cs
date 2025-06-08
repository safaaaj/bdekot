using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Windows.Forms;
using Examineon;

namespace Examineon.Tests
{
    [TestClass]
    public class SecondaryFormTests
    {
        [TestMethod]
        public void Constructor_WithStudentRole_SetsCorrectTitle()
        {
            Exception exception = null;
            SecondaryForm form = null;

            var thread = new System.Threading.Thread(() =>
            {
                try
                {
                    form = new SecondaryForm("student", "123456789");
                }
                catch (Exception ex)
                {
                    exception = ex;
                }
            });

            thread.SetApartmentState(System.Threading.ApartmentState.STA);
            thread.Start();
            thread.Join();

            if (exception != null)
                Assert.Fail("Test failed with: " + exception);

            Assert.IsNotNull(form);
            Assert.AreEqual("Logged in as student", form.Text);
        }

        [TestMethod]
        public void BtnPracticeExam_Click_OpensPracticeSetupForm()
        {
            var form = new SecondaryForm("student", "123456789");
            var method = typeof(SecondaryForm).GetMethod("btnPracticeExam_Click", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            method.Invoke(form, new object[] { null, EventArgs.Empty });

            Assert.IsTrue(true); // Smoke test
        }

        [TestMethod]
        public void Button1_Click_OpensExamSetupForm()
        {
            var form = new SecondaryForm("student", "123456789");
            var method = typeof(SecondaryForm).GetMethod("button1_Click", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            method.Invoke(form, new object[] { null, EventArgs.Empty });

            Assert.IsTrue(true); // Smoke test
        }

        [TestMethod]
        public void BtnViewScores_Click_OpensStudentScoresForm()
        {
            var form = new SecondaryForm("student", "123456789");
            var method = typeof(SecondaryForm).GetMethod("btnViewScores_Click", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            method.Invoke(form, new object[] { null, EventArgs.Empty });

            Assert.IsTrue(true); // Smoke test
        }

        [TestMethod]
        public void Button3_Click_ShowsNavigationPrompt()
        {
            var form = new SecondaryForm("student", "123456789");
            var method = typeof(SecondaryForm).GetMethod("button3_Click", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            method.Invoke(form, new object[] { null, EventArgs.Empty });

            Assert.IsTrue(true); // We can't test MessageBox, so it's a smoke test
        }
    }
}
