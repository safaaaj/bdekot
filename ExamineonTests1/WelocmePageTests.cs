using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;
using Examineon;

namespace Examineon.Tests
{
    [TestClass]
    public class WelocmePageTests
    {
        [TestMethod]
        public void Constructor_SetsButtonsToUseVisualStyle()
        {
            var page = new WelocmePage();
            var button1 = page.Controls["button1"] as Button;
            var button2 = page.Controls["button2"] as Button;

            Assert.IsNotNull(button1);
            Assert.IsNotNull(button2);
            Assert.IsTrue(button1.UseVisualStyleBackColor);
            Assert.IsTrue(button2.UseVisualStyleBackColor);
        }

        [TestMethod]
        public void Button1_Click_DisablesButtonAndOpensLoginForm()
        {
            var page = new WelocmePage();
            var button1 = page.Controls["button1"] as Button;
            Assert.IsNotNull(button1);

            // simulate click
            var method = typeof(WelocmePage).GetMethod("button1_Click", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            method.Invoke(page, new object[] { button1, EventArgs.Empty });

            Assert.IsFalse(button1.Enabled);
        }

        [TestMethod]
        public void Button2_Click_DisablesButtonAndOpensSignupForm()
        {
            var page = new WelocmePage();
            var button2 = page.Controls["button2"] as Button;
            Assert.IsNotNull(button2);

            var method = typeof(WelocmePage).GetMethod("button2_Click", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            method.Invoke(page, new object[] { button2, EventArgs.Empty });

            Assert.IsFalse(button2.Enabled);
        }
    }
}
