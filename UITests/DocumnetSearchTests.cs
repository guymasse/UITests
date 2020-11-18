using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using UITests.PageObjectModels;
using UITests.TestSetup;

namespace UITests
{
    [TestClass]
    public class DocumnetSearchTests
    {
        [TestMethod]
        public void DocumentNumberTest()
        {
            using (IWebDriver driver = new SelectDriver().Driver)
            {
                // arrange
                var documentNumberSearchPage = new DocumentNumberSearchPage(driver);
                documentNumberSearchPage.NavigateTo();

                // act

                // Code to submict a document number query
                documentNumberSearchPage.EnterDocumentNumber("2017000017");
                documentNumberSearchPage.PreformSearch();
                WebPageDelay.Pause(5000);

                // assert
                Assert.AreEqual("Document Number Search - Web/Intranet Document Number equals 2017000017", documentNumberSearchPage.SearchResult.Text);
            }
        }
    }
}
