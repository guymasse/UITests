using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using UITests.PageObjectModels;

namespace UITests
{
    [TestClass]

    public class SmokeTestEachPage
    {
        //private readonly IWebDriver driver = new ChromeDriver();
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
                //driver.Close();
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
                var publicMarriageCertificatePage = new PageObjectModels.PublicMarriageCertificatePage(driver);
                publicMarriageCertificatePage.NavigateTo();

                // act

                // assert
            }
        }
        [TestMethod]
        public void PublicMarriargeApplicationPage()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                // arrange
                var publicMarriageApplicationPage = new PageObjectModels.PublicMarriageApplicationPage(driver);
                publicMarriageApplicationPage.NavigateTo();

                // act

                // assert
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
        [TestMethod]
        public void DocumentNumberSearchPage()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                // arrange
                var documentNumberSearchPage = new DocumentNumberSearchPage(driver);
                documentNumberSearchPage.NavigateTo();

                // act

                // assert
            }
        }
        [TestMethod]
        public void FBNNewFilingPage()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                // arrange
                var fbnNewFilingPage = new FBNNewFilingPage(driver);
                fbnNewFilingPage.NavigateTo();

                // act

                // assert
            }
        }
        [TestMethod]
        public void FBNRenewalPage()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                // arrange
                var fbnRenewalPage = new FBNRenewalPage(driver);
                fbnRenewalPage.NavigateTo();

                // act

                // assert
            }
        }

    }
}
