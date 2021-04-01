using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using UITests.PageObjectModels;
using UITests.TestSetup;

namespace UITests
{
    [TestClass]
    public class SmokeTestEachPage
    {
        [TestMethod]
        public void OpenHomePage()
        {
            using (IWebDriver driver = new SelectDriver().Driver)
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
            using (IWebDriver driver = new SelectDriver().Driver)
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
            using (IWebDriver driver = new SelectDriver().Driver)
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
            using (IWebDriver driver = new SelectDriver().Driver)
            {
                // arrange
                var homePage = new HomePage(driver);
                homePage.NavigateTo();

                // act
                homePage.HistoricalIndexlink.Click();
                WebPageDelay.Pause();

                // assert
                var historicalSearchPage = new PageObjectModels.HistoricalSearchPage(driver);
                historicalSearchPage.EnsurePageLoaded();

            }
        }
        [TestMethod]
        public void VitlaRecordsPage()
        {
            using (IWebDriver driver = new SelectDriver().Driver)
            {
                // arrange
                var homePage = new HomePage(driver);
                homePage.NavigateTo();

                // act
                homePage.VitalRecordslink.Click();
                WebPageDelay.Pause();

                // assert
                var vitalRecordsPage = new PageObjectModels.VitalRecordsPage(driver);
                vitalRecordsPage.EnsurePageLoaded();
            }
        }
        [TestMethod]
        public void BirthCertificatePage()
        {
            using (IWebDriver driver = new SelectDriver().Driver)
            {
                // arrange
                var homePage = new HomePage(driver);
                homePage.NavigateTo();

                // act
                homePage.VitalRecordslink.Click();
                WebPageDelay.Pause();
                var vitalRecordsPage = new PageObjectModels.VitalRecordsPage(driver);
                vitalRecordsPage.BirthCertificatelink.Click();
                WebPageDelay.Pause();

                // assert
                var birthCertificatePage = new PageObjectModels.BirthCertificatePage(driver);
                birthCertificatePage.EnsurePageLoaded();
            }
        }
        [TestMethod]
        public void DeathCertificatePage()
        {
            using (IWebDriver driver = new SelectDriver().Driver)
            {
                // arrange
                var homePage = new HomePage(driver);
                homePage.NavigateTo();

                // act
                homePage.VitalRecordslink.Click();
                WebPageDelay.Pause();
                var vitalRecordsPage = new PageObjectModels.VitalRecordsPage(driver);
                vitalRecordsPage.DeathCertificatelink.Click();
                WebPageDelay.Pause();

                // assert
                var deathCertificatePage = new PageObjectModels.DeathCertificatePage(driver);
                deathCertificatePage.EnsurePageLoaded();
            }
        }
        [TestMethod]
        public void PublicMarriargeCertificatePage()
        {
            using (IWebDriver driver = new SelectDriver().Driver)
            {
                // arrange
                var homePage = new HomePage(driver);
                homePage.NavigateTo();

                // act
                homePage.VitalRecordslink.Click();
                WebPageDelay.Pause();
                var vitalRecordsPage = new PageObjectModels.VitalRecordsPage(driver);
                vitalRecordsPage.PublicMarriageCertificatelink.Click();
                WebPageDelay.Pause();

                // assert
                var publicMarriageCertificatePage = new PageObjectModels.PublicMarriageCertificatePage(driver);
                publicMarriageCertificatePage.EnsurePageLoaded();
            }
        }

        [TestMethod]
        public void ConfidentialMarriargeCertificatePage()
        {
            using (IWebDriver driver = new SelectDriver().Driver)
            {
                // arrange
                var homePage = new HomePage(driver);
                homePage.NavigateTo();

                // act
                homePage.VitalRecordslink.Click();
                WebPageDelay.Pause();
                var vitalRecordsPage = new PageObjectModels.VitalRecordsPage(driver);
                vitalRecordsPage.ConfidentialMarriageCertificatelink.Click();
                WebPageDelay.Pause();

                // assert
                var confidentialMarriageCertificatePage = new PageObjectModels.ConfidentialMarriageCertificatePage(driver);
                confidentialMarriageCertificatePage.EnsurePageLoaded();
            }
        }

        [TestMethod]
        public void PublicMarriargeApplicationPage()
        {
            using (IWebDriver driver = new SelectDriver().Driver)
            {
                // arrange
                var homePage = new HomePage(driver);
                homePage.NavigateTo();

                // act
                homePage.MarriageApplicationlink.Click();
                WebPageDelay.Pause();
                var marriageLicenseApplicationPage = new PageObjectModels.MarriageLicenseApplicationPage(driver);
                marriageLicenseApplicationPage.PublicMarriageButton.Click();
                WebPageDelay.Pause();

                // assert
                var publicMarriageApplicationPage = new PageObjectModels.PublicMarriageApplicationPage(driver);
                publicMarriageApplicationPage.EnsurePageLoaded();

            }
        }

        [TestMethod]
        public void ConfidentialMarriargeApplicationPage()
        {
            using (IWebDriver driver = new SelectDriver().Driver)
            {
                // arrange
                var homePage = new HomePage(driver);
                homePage.NavigateTo();

                // act
                homePage.MarriageApplicationlink.Click();
                WebPageDelay.Pause();
                var marriageLicenseApplicationPage = new PageObjectModels.MarriageLicenseApplicationPage(driver);
                marriageLicenseApplicationPage.ConfidentialMarriageButton.Click();
                WebPageDelay.Pause();

                // assert
                var confidentialMarriageApplicationPage = new PageObjectModels.ConfidentialMarriageApplicationPage(driver);
                confidentialMarriageApplicationPage.EnsurePageLoaded();

            }
        }

        [TestMethod]
        public void AdvanceSearchPage()
        {
            using (IWebDriver driver = new SelectDriver().Driver)
            {
                // arrange
                var homePage = new HomePage(driver);
                homePage.NavigateTo();

                // act
                homePage.OfficialRecordsSearchlink.Click();
                WebPageDelay.Pause();
                var officialRecordsSearchPagePage = new PageObjectModels.OfficialRecordsSearchPage(driver);
                officialRecordsSearchPagePage.AdvanceSearchLink.Click();
                WebPageDelay.Pause();

                // assert
                var advanceSearchPage = new AdvanceSearchPage(driver);
                advanceSearchPage.EnsurePageLoaded();
            }
        }

        [TestMethod]
        public void DocumentNumberSearchPage()
        {
            using (IWebDriver driver = new SelectDriver().Driver)
            {
                // arrange
                var homePage = new HomePage(driver);
                homePage.NavigateTo();

                // act
                homePage.OfficialRecordsSearchlink.Click();
                WebPageDelay.Pause();
                var officialRecordsSearchPage = new PageObjectModels.OfficialRecordsSearchPage(driver);
                officialRecordsSearchPage.DocumentNumberSearchLink.Click();
                WebPageDelay.Pause();

                // assert
                var documentNumberSearchPage = new DocumentNumberSearchPage(driver);
                documentNumberSearchPage.EnsurePageLoaded();
            }
        }

        [TestMethod]
        public void FBNSearchPage()
        {
            using (IWebDriver driver = new SelectDriver().Driver)
            {
                // arrange
                var homePage = new HomePage(driver);
                homePage.NavigateTo();

                // act
                homePage.FBNApplicationlink.Click();
                WebPageDelay.Pause();
                var fBNApplicationPage = new PageObjectModels.FBNApplicationPage(driver);
                fBNApplicationPage.SearchFBNLink.Click();
                WebPageDelay.Pause();

                // assert
                var fbnSearchPage = new FBNSearchPage(driver);
                fbnSearchPage.EnsurePageLoaded();
            }
        }

        [TestMethod]
        public void FBNNewFilingPage()
        {
            using (IWebDriver driver = new SelectDriver().Driver)
            {
                // arrange
                var homePage = new HomePage(driver);
                homePage.NavigateTo();

                // act
                homePage.FBNApplicationlink.Click();
                WebPageDelay.Pause();
                var fBNApplicationPage = new PageObjectModels.FBNApplicationPage(driver);
                fBNApplicationPage.NewFillingLink.Click();
                WebPageDelay.Pause();

                // assert
                var fbnNewFilingPage = new FBNNewFilingPage(driver);
                fbnNewFilingPage.EnsurePageLoaded();

            }
        }

        [TestMethod]
        public void FBNRenewalPage()
        {
            using (IWebDriver driver = new SelectDriver().Driver)
            {
                // arrange
                var homePage = new HomePage(driver);
                homePage.NavigateTo();

                // act
                homePage.FBNApplicationlink.Click();
                WebPageDelay.Pause();
                var fBNApplicationPage = new PageObjectModels.FBNApplicationPage(driver);
                fBNApplicationPage.RenewalLink.Click();
                WebPageDelay.Pause();

                // assert
                var fbnRenewalPage = new FBNRenewalPage(driver);
                fbnRenewalPage.EnsurePageLoaded();
            }
        }

        [TestMethod]
        public void FBNWithdrawalPage()
        {
            using (IWebDriver driver = new SelectDriver().Driver)
            {
                // arrange
                var homePage = new HomePage(driver);
                homePage.NavigateTo();

                // act
                homePage.FBNApplicationlink.Click();
                WebPageDelay.Pause();
                var fBNApplicationPage = new PageObjectModels.FBNApplicationPage(driver);
                fBNApplicationPage.WithdrawalLink.Click();
                WebPageDelay.Pause();

                // assert
                var fbnWithdrawalPage = new FBNWithdrawalPage(driver);
                fbnWithdrawalPage.EnsurePageLoaded();
            }
        }

        [TestMethod]
        public void FBNAbandonmentPage()
        {
            using (IWebDriver driver = new SelectDriver().Driver)
            {
                // arrange
                var homePage = new HomePage(driver);
                homePage.NavigateTo();

                // act
                homePage.FBNApplicationlink.Click();
                WebPageDelay.Pause();
                var fBNApplicationPage = new PageObjectModels.FBNApplicationPage(driver);
                fBNApplicationPage.AbandonmentLink.Click();
                WebPageDelay.Pause();

                // assert
                var fBNAbandonmentPage = new FBNAbandonmentPage(driver);
                fBNAbandonmentPage.EnsurePageLoaded();
            }
        }

    }
}
