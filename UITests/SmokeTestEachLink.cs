﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using UITests.PageObjectModels;

namespace UITests
{
    [TestClass]

    public class SmokeTestEachLink
    {

        public const string publicMarriageCertificateUrl = "http://dbkpvrecapp01:8100/cdweb/wizard/WIZARD201S1";
        public const string publicMarriageCertificateTitle = "Public Marriage License Requirements";

        [TestMethod]
        public void OpenHomePage()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                // arrange
                var homePage = new HomePage(driver);
                homePage.NavigateTo();

                // act

                // assert
            }
        }

        [TestMethod]
        public void ReloadingHomePageOnBack()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                // arrange
                var homePage = new HomePage(driver);
                homePage.NavigateTo();
                var advanceSearchPage = new AdvanceSearchPage(driver);
                advanceSearchPage.NavigateTo();
                driver.Navigate().Back();
                homePage.EnsurePageLoaded();
                // act

                // assert
            }
        }

        [TestMethod]
        public void ReloadingHomePageOnForward()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                // arrange
                var advanceSearchPage = new AdvanceSearchPage(driver);
                advanceSearchPage.NavigateTo();
                var homePage = new HomePage(driver);
                homePage.NavigateTo();
                driver.Navigate().Back();
                driver.Navigate().Forward();
                homePage.EnsurePageLoaded();
                // act

                // assert

            }
        }

        [TestMethod]
        public void HistoricalSearchPage()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                // arrange
                var historicalSearchPage = new PageObjectModels.HistoricalSearchPage(driver);
                historicalSearchPage.NavigateTo();
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
                var vitalRecordsPage = new PageObjectModels.VitalRecordsPage(driver);
                vitalRecordsPage.NavigateTo();

                // act

                // assert
            }
        }
        [TestMethod]
        public void BirthCertificatePage()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                // arrange
                var birthCertificatePage = new PageObjectModels.BirthCertificatePage(driver);
                birthCertificatePage.NavigateTo();

                // act

                // assert
            }
        }
        [TestMethod]
        public void DeathCertificatePage()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                // arrange
                var deathCertificatePage = new PageObjectModels.DeathCertificatePage(driver);
                deathCertificatePage.NavigateTo();

                // act

                // assert
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
                Assert.AreEqual(publicMarriageCertificateUrl, driver.Url.Substring(0, 50));
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
