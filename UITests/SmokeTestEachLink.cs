using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using UITests.PageObjectModels;

namespace UITests
{
    [TestClass]

    public class SmokeTestEachLink
    {

        public const string historicalUrl = "http://lkwdvsvrecapp1:7061/cdweb/historicalIndex/HISTORICAL_INDEX987S1";
        public const string historicalTitle = "Self-Service: Historical Index";
        public const string vitalRecordsUrl = "http://lkwdvsvrecapp1:7061/cdweb/action/ACTIONGROUP201S1";
        public const string vitalRecordTitle = "Vital Records Certified Copies";
        public const string birthCertificateUrl = "http://lkwdvsvrecapp1:7061/cdweb/wizard/COPYREQUEST201S1";
        public const string birthCertificateTitle = "Birth Certificate Authorized Copies";
        public const string deathCertificateUrl = "http://lkwdvsvrecapp1:7061/cdweb/wizard/COPYREQUEST201S2";
        public const string deathCertificateTitle = "Death Certificate Authorized Copies";
        public const string publicMarriageCertificateUrl = "http://lkwdvsvrecapp1:7061/cdweb/wizard/WIZARD201S1";
        public const string publicMarriageCertificateTitle = "Public Marriage License Requirements";

        [TestMethod]
        public void HistoricalSearchPage()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                // arrange
                var historicalSearchPage = new PageObjectModels.HistoricalSearchPage(driver);
                historicalSearchPage.NavigateTo();
                WebPageDelay.Pause();
                // act

                // assert
            }
        }
        [TestMethod]
        public void VitlaRecordsPage()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                // arrange
                driver.Navigate().GoToUrl(vitalRecordsUrl);

                // act
                IWebElement PageText = driver.FindElement(By.XPath("//h1[contains(.,'Vital Records Certified Copies')]"));
                // assert
                Assert.AreEqual(vitalRecordTitle, PageText.Text);
                Assert.AreEqual(vitalRecordsUrl, driver.Url);
            }
        }
        [TestMethod]
        public void BirthCertificatePage()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                // arrange
                driver.Navigate().GoToUrl(birthCertificateUrl);

                // act
                IWebElement PageText = driver.FindElement(By.XPath("//h1[contains(.,'Birth Certificate Authorized Copies')]"));
                // assert
                Assert.AreEqual(birthCertificateTitle, PageText.Text);
                Assert.AreEqual(birthCertificateUrl, driver.Url.Substring(0,56));
            }
        }
        [TestMethod]
        public void DeathCertificatePage()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                // arrange
                driver.Navigate().GoToUrl(deathCertificateUrl);

                // act
                IWebElement PageText = driver.FindElement(By.XPath("//h1[contains(.,'Death Certificate Authorized Copies')]"));

                // assert
                Assert.AreEqual(deathCertificateTitle, PageText.Text);
                Assert.AreEqual(deathCertificateUrl, driver.Url.Substring(0, 56));
            }
        }
        [TestMethod]
        public void PublicMarriargeCertificatePage()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                // arrange
                driver.Navigate().GoToUrl(publicMarriageCertificateUrl);

                // act
                IWebElement PageText = driver.FindElement(By.XPath("//h1[contains(.,'Public Marriage License Requirements')]"));

                // assert
                Assert.AreEqual(publicMarriageCertificateTitle, PageText.Text);
                Assert.AreEqual(publicMarriageCertificateUrl, driver.Url.Substring(0, 51));
            }
        }
        [TestMethod]
        public void AdvanceSearchPage()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                // arrange
                var advanceSearchPage = new AdvanceSearchPage(driver);
                advanceSearchPage.NavigateTo();

                 // act

                // assert
             }
        }

    }
}
