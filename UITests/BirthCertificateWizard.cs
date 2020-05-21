using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using UITests.TestSetup;

namespace UITests
{
    [TestClass]

   public class BirthCertificateWizard
    {
        public string step2PageTitle = "Birth Record Information";

        [TestMethod]
        public void BirthCertificate()
        {
            using (IWebDriver driver = new SelectDriver().Driver)
            {
                // arrange
                var birthCertificatePage = new PageObjectModels.BirthCertificatePage(driver);
                birthCertificatePage.NavigateTo();

                // act
                // Step 1 of Wizard
                birthCertificatePage.Step1IAm.Click();
                birthCertificatePage.NextButton.Click();

                // Assert
                Assert.AreEqual("Birth Record Information", birthCertificatePage.Step2PageText.Text);

                // Step 2 of wizard
                birthCertificatePage.Step2FirstName.SendKeys("Guy");
                birthCertificatePage.Step2LastName.SendKeys("Masse");
                birthCertificatePage.Step2DateOfBirthe.SendKeys("12/23/1955");
                birthCertificatePage.Step2CityOfBirthe.SendKeys("Windsor");
                birthCertificatePage.NextButton.Click();
                WebPageDelay.Pause();

                // assert


            }
        }
    }
}
