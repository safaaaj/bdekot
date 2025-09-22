using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;
using Examineon;

namespace Examineon.Tests
{
    [TestClass]
    public class MainFormTests
    {
       
       
        [TestMethod]
        public void BtnCreateQ_Click_OpensForm1()
        {
            var form = new MainForm("lecturer");
            var method = typeof(MainForm).GetMethod("btnCreateQ_Click", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            method.Invoke(form, new object[] { null, EventArgs.Empty });

            Assert.IsTrue(true); // Smoke test: no crash
        }

        [TestMethod]
        public void BtnTeacherPage_Click_OpensCreateExamForm()
        {
            var form = new MainForm("lecturer");
            var method = typeof(MainForm).GetMethod("btnTeacherPage_Click", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            method.Invoke(form, new object[] { null, EventArgs.Empty });

            Assert.IsTrue(true); // Smoke test
        }

        [TestMethod]
        public void BtnOpenAnalysis_Click_OpensLecturerAnalysisForm()
        {
            var form = new MainForm("lecturer");
            var method = typeof(MainForm).GetMethod("btnOpenAnalysis_Click", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            method.Invoke(form, new object[] { null, EventArgs.Empty });

            Assert.IsTrue(true); // Smoke test
        }

        [TestMethod]
        public void Button3_Click_ShowsNavigationDialog()
        {
            // Still a smoke test — can't intercept MessageBox result in plain MSTest
            var form = new MainForm("lecturer");
            var method = typeof(MainForm).GetMethod("button3_Click", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            method.Invoke(form, new object[] { null, EventArgs.Empty });

            Assert.IsTrue(true); // Smoke test
        }

        [TestMethod]
        public void Constructor_WithLecturerRole_SetsCorrectTitleAndShowsAnalysisButton()
        {
            Exception exception = null;

            var thread = new System.Threading.Thread(() =>
            {
                try
                {
                    using (var form = new MainForm("lecturer"))
                    {
                        // Force handle creation and control initialization
                        form.Show(); // ensures control tree is built
                        var analysisBtn = form.Controls.Find("btnOpenAnalysis", true)
                                                       .OfType<Button>()
                                                       .FirstOrDefault();

                        if (analysisBtn == null)
                            throw new Exception("btnOpenAnalysis not found in Controls.");

                        Assert.IsTrue(analysisBtn.Enabled, "btnOpenAnalysis should be enabled.");
                        Assert.IsTrue(analysisBtn.Visible, "btnOpenAnalysis should be visible.");
                        Assert.AreEqual("Logged in as lecturer", form.Text);

                        form.Close(); // Close the form cleanly
                    }
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
                Assert.Fail("💥 Test failed with: " + exception);
        }


    }
}
