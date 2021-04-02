using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
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
                homePage.OfficialRecordsSearchlink.Click();
                WebPageDelay.Pause();
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
                var homePage = new HomePage(driver);
                homePage.NavigateTo();
                homePage.OfficialRecordsSearchlink.Click();
                WebPageDelay.Pause();
                driver.Navigate().Back();
                driver.Navigate().Forward();
                driver.Navigate().Back();
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
                var vitalRecordsPage = new PageObjectModels.VitalRecordsPage(driver);
                vitalRecordsPage.BirthCertificatelink.Click();

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
                var vitalRecordsPage = new PageObjectModels.VitalRecordsPage(driver);
                vitalRecordsPage.DeathCertificatelink.Click();

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
                var vitalRecordsPage = new PageObjectModels.VitalRecordsPage(driver);
                vitalRecordsPage.PublicMarriageCertificatelink.Click();

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
                var vitalRecordsPage = new PageObjectModels.VitalRecordsPage(driver);
                vitalRecordsPage.ConfidentialMarriageCertificatelink.Click();

                // assert
                var confidentialMarriageCertificatePage = new PageObjectModels.ConfidentialMarriageCertificatePage(driver);
                confidentialMarriageCertificatePage.EnsurePageLoaded();
            }
        }

        [TestMethod]
        public void MarriargeLicenseApplicationPage()
        {
            using (IWebDriver driver = new SelectDriver().Driver)
            {
                // arrange
                var homePage = new HomePage(driver);
                homePage.NavigateTo();

                // act
                homePage.MarriageApplicationlink.Click();

                // assert
                var marriageLicenseApplicationPage = new PageObjectModels.MarriageLicenseApplicationPage(driver);
                marriageLicenseApplicationPage.EnsurePageLoaded();

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
                var marriageLicenseApplicationPage = new PageObjectModels.MarriageLicenseApplicationPage(driver);
                marriageLicenseApplicationPage.PublicMarriageButton.Click();

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
                var marriageLicenseApplicationPage = new PageObjectModels.MarriageLicenseApplicationPage(driver);
                marriageLicenseApplicationPage.ConfidentialMarriageButton.Click();

                // assert
                var confidentialMarriageApplicationPage = new PageObjectModels.ConfidentialMarriageApplicationPage(driver);
                confidentialMarriageApplicationPage.EnsurePageLoaded();

            }
        }

        [TestMethod]
        public void OfficialRecordsSearchPage()
        {
            using (IWebDriver driver = new SelectDriver().Driver)
            {
                // arrange
                var homePage = new HomePage(driver);
                homePage.NavigateTo();

                // act
                homePage.OfficialRecordsSearchlink.Click();

                // assert
                var officialRecordsSearchPagePage = new PageObjectModels.OfficialRecordsSearchPage(driver);
                officialRecordsSearchPagePage.EnsurePageLoaded();
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
                var officialRecordsSearchPagePage = new PageObjectModels.OfficialRecordsSearchPage(driver);
                officialRecordsSearchPagePage.AdvanceSearchLink.Click();

                // assert
                var advanceSearchPage = new AdvanceSearchPage(driver);
                advanceSearchPage.EnsurePageLoaded();
            }
        }

        [TestMethod]
        public void BasicSearchPage()
        {
            using (IWebDriver driver = new SelectDriver().Driver)
            {
                // arrange
                var homePage = new HomePage(driver);
                homePage.NavigateTo();

                // act
                homePage.OfficialRecordsSearchlink.Click();
                var officialRecordsSearchPagePage = new PageObjectModels.OfficialRecordsSearchPage(driver);
                officialRecordsSearchPagePage.BasicSearchLink.Click();

                // assert
                var basicSearchPage = new BasicSearchPage(driver);
                basicSearchPage.EnsurePageLoaded();
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
                var officialRecordsSearchPage = new PageObjectModels.OfficialRecordsSearchPage(driver);
                officialRecordsSearchPage.DocumentNumberSearchLink.Click();

                // assert
                var documentNumberSearchPage = new DocumentNumberSearchPage(driver);
                documentNumberSearchPage.EnsurePageLoaded();
            }
        }

        [TestMethod]
        public void DocumentTypeSearchPage()
        {
            using (IWebDriver driver = new SelectDriver().Driver)
            {
                // arrange
                var homePage = new HomePage(driver);
                homePage.NavigateTo();

                // act
                homePage.OfficialRecordsSearchlink.Click();
                var officialRecordsSearchPage = new PageObjectModels.OfficialRecordsSearchPage(driver);
                officialRecordsSearchPage.DocumentTypeSearchLink.Click();

                // assert
                var documentTypeSearchPage = new DocumentTypeSearchPage(driver);
                documentTypeSearchPage.EnsurePageLoaded();
            }
        }

        [TestMethod]
        public void MapBookPageSearchPage()
        {
            using (IWebDriver driver = new SelectDriver().Driver)
            {
                // arrange
                var homePage = new HomePage(driver);
                homePage.NavigateTo();

                // act
                homePage.OfficialRecordsSearchlink.Click();
                var officialRecordsSearchPage = new PageObjectModels.OfficialRecordsSearchPage(driver);
                officialRecordsSearchPage.MapBookPageSearchLink.Click();

                // assert
                var mapBookPageSearchPage = new MapBookPageSearchPage(driver);
                mapBookPageSearchPage.EnsurePageLoaded();
            }
        }
        
        [TestMethod]
        public void FBNApplicationPage()
        {
            using (IWebDriver driver = new SelectDriver().Driver)
            {
                // arrange
                var homePage = new HomePage(driver);
                homePage.NavigateTo();

                // act
                homePage.FBNApplicationlink.Click();

                // assert
                var fBNApplicationPage = new PageObjectModels.FBNApplicationPage(driver);
                fBNApplicationPage.EnsurePageLoaded();
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
                var fBNApplicationPage = new PageObjectModels.FBNApplicationPage(driver);
                fBNApplicationPage.SearchFBNLink.Click();

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
                var fBNApplicationPage = new PageObjectModels.FBNApplicationPage(driver);
                fBNApplicationPage.NewFillingLink.Click();

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
                var fBNApplicationPage = new PageObjectModels.FBNApplicationPage(driver);
                fBNApplicationPage.RenewalLink.Click();

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
                var fBNApplicationPage = new PageObjectModels.FBNApplicationPage(driver);
                fBNApplicationPage.WithdrawalLink.Click();

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
                var fBNApplicationPage = new PageObjectModels.FBNApplicationPage(driver);
                fBNApplicationPage.AbandonmentLink.Click();

                // assert
                var fBNAbandonmentPage = new FBNAbandonmentPage(driver);
                fBNAbandonmentPage.EnsurePageLoaded();
            }
        }

    }
}
