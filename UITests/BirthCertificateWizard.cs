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
                birthCertificatePage.Step2FirstName.SendKeys("MATEO");
                birthCertificatePage.Step2LastName.SendKeys("VIQUEZ");
                birthCertificatePage.Step2DateOfBirthe.SendKeys("10/16/2014");
                birthCertificatePage.Step2CityOfBirthe.SendKeys("TEMECULA");
                birthCertificatePage.NextButton.Click();
                WebPageDelay.Pause();

                // assert


            }
        }
    }
}
