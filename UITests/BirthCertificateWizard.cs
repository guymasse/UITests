using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using UITests.PageObjectModels;
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
                var homePage = new HomePage(driver);
                homePage.NavigateTo();

                // act
                homePage.VitalRecordslink.Click();
                var vitalRecordsPage = new PageObjectModels.VitalRecordsPage(driver);
                vitalRecordsPage.BirthCertificatelink.Click();

                // act
                // Step 1 of Wizard
                var birthCertificatePage = new PageObjectModels.BirthCertificatePage(driver);
                birthCertificatePage.Step1IAm.Click();
                birthCertificatePage.NextButton.Click();

                // Assert
                Assert.AreEqual("Birth Record Information", birthCertificatePage.Step2PageText.Text);

                // Step 2 of wizard
                birthCertificatePage.Step2FirstName.SendKeys("MATEO");
                birthCertificatePage.Step2LastName.SendKeys("VIQUEZ");
                birthCertificatePage.Step2DateOfBirth.SendKeys("10/16/2014");
                birthCertificatePage.Step2CityOfBirth.SendKeys("TEMECULA");
                birthCertificatePage.NextButton.Click();

                // Assert
                Assert.AreEqual("Requestor Information", birthCertificatePage.Step3PageText.Text);

                // Step 3 of wizard
                birthCertificatePage.Step3FullName.SendKeys("ALVARO JOSH VIQUEZ");
                birthCertificatePage.Step3StreetAddress.SendKeys("41402 WILLOW RUN ROAD");
                birthCertificatePage.Step3City.SendKeys("TEMECULA");
                birthCertificatePage.Step3State.SendKeys("CA");
                birthCertificatePage.Step3Zip.SendKeys("90245");
                birthCertificatePage.SetRelationship("PARENT");
                birthCertificatePage.Step3IdNumber.SendKeys("ID-12345");
                birthCertificatePage.Step3PhoneNumber.SendKeys("303-555-8888");
                birthCertificatePage.Step3NumberOfCopies.SendKeys("1");
                birthCertificatePage.NextButton.Click();

                // Assert
                Assert.AreEqual("Review Request", birthCertificatePage.Step4PageText.Text);

                WebPageDelay.Pause(5000);

                // Step 4 Complete
                birthCertificatePage.CompleteButton.Click();

                // Assert
                Assert.AreEqual("Checkout", birthCertificatePage.CheckoutPageText.Text);

                // Checkout
                birthCertificatePage.SetPaymentMethod("In Office");
                birthCertificatePage.CustomerName.SendKeys("ALVARO JOSH VIQUEZ");
                birthCertificatePage.PlaceOrderButton.Click();
                WebPageDelay.Pause(5000);

                // assert

                Assert.AreEqual("Thank you for your order.", birthCertificatePage.ConfirmationText.Text);

            }
        }
    }
}
