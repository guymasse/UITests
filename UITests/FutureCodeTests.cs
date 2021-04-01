
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using UITests.PageObjectModels;
using UITests.TestSetup;

namespace UITests
{
    [TestClass]

    public class FutureCodeTests
    {

        [TestMethod]
        public void RadioButtonTest()
        {
            using (IWebDriver driver = new SelectDriver().Driver)
            {
                // arrange
                var homePage = new HomePage(driver);
                homePage.NavigateTo();
                homePage.VitalRecordslink.Click();
                WebPageDelay.Pause();
                var vitalRecordsPage = new PageObjectModels.VitalRecordsPage(driver);
                vitalRecordsPage.DeathCertificatelink.Click();
                WebPageDelay.Pause();

                // act
                // Wizard Navigation Test code for radio buttons and next button
                var deathCertificatePage = new PageObjectModels.DeathCertificatePage(driver);
                deathCertificatePage.SelectedRadio.Click();
                WebPageDelay.Pause();
                deathCertificatePage.NextButton.Click();
                WebPageDelay.Pause();

                // assert
            }
        }
        [TestMethod]
        public void DropDownTest()
        {
            using (IWebDriver driver = new SelectDriver().Driver)
            {
                // arrange
                var homePage = new HomePage(driver);
                homePage.NavigateTo();
                homePage.MarriageApplicationlink.Click();
                WebPageDelay.Pause();
                var marriageLicenseApplicationPage = new PageObjectModels.MarriageLicenseApplicationPage(driver);
                marriageLicenseApplicationPage.PublicMarriageButton.Click();
                WebPageDelay.Pause();
                var publicMarriageApplicationPage = new PageObjectModels.PublicMarriageApplicationPage(driver);
                // act
                // Wizard Navigation Test code for radio buttons and next button and select dropdown
                publicMarriageApplicationPage.NextButton.Click();
                WebPageDelay.Pause();

                publicMarriageApplicationPage.SelectedRadio.Click();
                WebPageDelay.Pause();

                publicMarriageApplicationPage.NextButton.Click();
                WebPageDelay.Pause();

                SelectElement idType = new SelectElement(publicMarriageApplicationPage.IdTypeDropDown);
                idType.SelectByText("Passport");

                // assert
                Assert.AreEqual("Passport", idType.SelectedOption.Text);
                WebPageDelay.Pause();
            }
        }
        [TestMethod]
        public void CheckBoxTest()
        {
            using (IWebDriver driver = new SelectDriver().Driver)
            {
                // arrange
                var homePage = new HomePage(driver);
                homePage.NavigateTo();
                homePage.OfficialRecordsSearchlink.Click();
                WebPageDelay.Pause();
                var officialRecordsSearchPagePage = new PageObjectModels.OfficialRecordsSearchPage(driver);
                officialRecordsSearchPagePage.AdvanceSearchLink.Click();
                WebPageDelay.Pause();
                var advanceSearchPage = new AdvanceSearchPage(driver);
                // act

                // Code to check a box
                //Actions action = new Actions(driver);
                //action.MoveToElement(advanceSearchPage.AdvanceSearchCheckBox);
                //WebPageDelay.Pause(1000);
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("arguments[0].scrollIntoView();", advanceSearchPage.AdvanceSearchCheckBox);
                advanceSearchPage.AdvanceSearchCheckBox.Click();


                // assert
            }
        }
        //[TestMethod]
        //[UseReporter(typeof(BeyondCompareReporter))]
        //public void ScreenShotTest()
        //{
        //    using (IWebDriver driver = new SelectDriver().Driver)
        //    {
        //        // arrange
        //        var homePage = new HomePage(driver);
        //        homePage.NavigateTo();
        //        WebPageDelay.Pause(5500);
        //        // act

        //        // Code to check a box
        //        ITakesScreenshot screenShotDriver = (ITakesScreenshot)driver;

        //        Screenshot screenshot = screenShotDriver.GetScreenshot();

        //        screenshot.SaveAsFile("Homepage.jpeg", ScreenshotImageFormat.Jpeg);

        //        FileInfo file = new FileInfo("Homepage.jpeg");

        //        Approvals.Verify(file);


        //        // assert
        //    }

            // Other code
            // Page Time out
            // driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);

            //Returning a page object
            // AdvanceSearchPage advanceSearchPage = Otherpageobject.functionthatreturnsapageobject

    }
}
