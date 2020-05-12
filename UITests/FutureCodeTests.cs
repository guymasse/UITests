using System;
using System.IO;
using ApprovalTests;
using ApprovalTests.Reporters;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using UITests.PageObjectModels;

namespace UITests
{
    [TestClass]

    public class FutureCodeTests
    {

        [TestMethod]
        public void RadioButtonTest()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                // arrange
                var deathCertificatePage = new PageObjectModels.DeathCertificatePage(driver);
                deathCertificatePage.NavigateTo();

                // act
                // Wizard Navigation Test code for radio buttons and next button
                WebDriverWait Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));

                IWebElement selectedRadio =
                    Wait.Until(e => e.FindElement(By.XPath("//label[@class='ui-btn ui-corner-all ui-btn-a ui-btn-icon-left ui-radio-off ui-first-child']")));
                selectedRadio.Click();
                WebPageDelay.Pause();
                IWebElement nextButton = driver.FindElement(By.XPath("//a[@class='ss-right ui-link ui-btn ui-btn-a ui-icon-arrow-r ui-btn-icon-right ui-btn-inline ui-shadow ui-corner-all'][contains(.,'Next')]"));
                nextButton.Click();
                WebPageDelay.Pause();

                // assert
            }
        }
        [TestMethod]
        public void DropDownTest()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                // arrange
                var publicMarriageApplicationPage = new PageObjectModels.PublicMarriageApplicationPage(driver);
                publicMarriageApplicationPage.NavigateTo();
                // act

                // Wizard Navigation Test code for radio buttons and next button and select dropdown
                IWebElement nextButton = driver.FindElement(By.XPath("//a[@class='ss-right ui-link ui-btn ui-btn-a ui-icon-arrow-r ui-btn-icon-right ui-btn-inline ui-shadow ui-corner-all'][contains(.,'Next')]"));
                nextButton.Click();
                WebPageDelay.Pause();

                IWebElement selectedRadio = driver.FindElement(By.XPath("//label[@class='ui-btn ui-corner-all ui-btn-a ui-btn-icon-left ui-radio-off ui-last-child']"));
                selectedRadio.Click();
                WebPageDelay.Pause();

                IWebElement nextButton2 = driver.FindElement(By.XPath("//a[@class='ss-right ui-link ui-btn ui-btn-a ui-icon-arrow-r ui-btn-icon-right ui-btn-inline ui-shadow ui-corner-all'][contains(.,'Next')]"));
                nextButton2.Click();
                WebPageDelay.Pause();

                IWebElement idTypeDropDown = driver.FindElement(By.XPath("//select[contains(@id,'field_GroomIDType')]"));
                SelectElement idType = new SelectElement(idTypeDropDown);
                idType.SelectByText("Passport");


                // assert
                Assert.AreEqual("Passport", idType.SelectedOption.Text);
                WebPageDelay.Pause();
            }
        }
        [TestMethod]
        public void CheckBoxTest()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                // arrange
                var advanceSearchPage = new AdvanceSearchPage(driver);
                advanceSearchPage.NavigateTo();
                // act

                // Code to check a box
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("arguments[0].scrollIntoView();", advanceSearchPage.AdvanceSearchCheckBox);             
                advanceSearchPage.AdvanceSearchCheckBox.Click();


                // assert
            }
        }
        [TestMethod]
        [UseReporter(typeof(BeyondCompareReporter))]
        public void ScreenShotTest()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                // arrange
                var homePage = new HomePage(driver);
                homePage.NavigateTo();
                WebPageDelay.Pause();
                // act

                // Code to check a box
                ITakesScreenshot screenShotDriver = (ITakesScreenshot)driver;

                Screenshot screenshot = screenShotDriver.GetScreenshot();

                screenshot.SaveAsFile("Homepage.jpeg", ScreenshotImageFormat.Jpeg);
 
                FileInfo file = new FileInfo("Homepage.jpeg");

                Approvals.Verify(file);


                // assert
            }

            // Other code
            // Page Time out
            // driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);

            //Returning a page object
            // AdvanceSearchPage advanceSearchPage = Otherpageobject.functionthatreturnsapageobject

        }
    }
}
