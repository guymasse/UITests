using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using UITests.PageObjectModels;

namespace UITests
{
    [TestClass]
    public class DocumnetSearchTests
    {
        [TestMethod]
        public void DocumentNumberTest()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                // arrange
                var advanceSearchPage = new AdvanceSearchPage(driver);
                advanceSearchPage.NavigateTo();

                // act

                // Code to submict a document number query
                advanceSearchPage.EnterDocumentNumber("2017000012");
                advanceSearchPage.PreformSearch();
                WebPageDelay.Pause(50000);

                // assert
            }
        }
    }
}
