using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Examineon;

namespace Examineon.Tests
{
    [TestClass]
    public class ExamSetupTests
    {
        [TestMethod]
        public void Constructor_InitializesComboBoxesAndEvents()
        {
            Exception ex = null;
            ExamSetup form = null;

            var thread = new Thread(() =>
            {
                try
                {
                    form = new ExamSetup("123456789");

                    var subjectCombo = form.Controls.Find("cmbPracticeSubject", true).FirstOrDefault() as ComboBox;
                    var diffCombo = form.Controls.Find("cmbPracticeDifficulty", true).FirstOrDefault() as ComboBox;

                    Assert.IsNotNull(subjectCombo);
                    Assert.IsNotNull(diffCombo);
                    Assert.AreEqual(3, subjectCombo.Items.Count);
                    Assert.AreEqual(3, diffCombo.Items.Count);
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
        public void BtnStartPractice_Click_NoExamFound_ShowsMessageBox()
        {
            Exception ex = null;

            var thread = new Thread(() =>
            {
                try
                {
                    var form = new ExamSetup("123456789");

                    var cmbSubj = form.Controls.Find("cmbPracticeSubject", true).FirstOrDefault() as ComboBox;
                    var cmbDiff = form.Controls.Find("cmbPracticeDifficulty", true).FirstOrDefault() as ComboBox;

                    cmbSubj.SelectedItem = "NonExistentSubject";
                    cmbDiff.SelectedItem = "NonExistentDifficulty";

                    var btn = form.Controls.Find("btnStartPractice", true).FirstOrDefault() as Button;

                    btn.PerformClick(); // simulate click (just to make sure it doesn't crash)
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
                Assert.Fail("Exception occurred: " + ex.Message);
        }


        [TestMethod]
        public void BtnExit_Click_ClosesApp_Safely()
        {
            Exception ex = null;

            var thread = new Thread(() =>
            {
                try
                {
                    var form = new ExamSetup("123456789");
                    var exitBtn = form.Controls.Find("btnExit", true).FirstOrDefault() as Button;

                    Assert.IsNotNull(exitBtn);
                    exitBtn.PerformClick(); // Will exit app, expect no exception here
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
                Assert.Fail("Crash on btnExit: " + ex.Message);
        }
    }
}
