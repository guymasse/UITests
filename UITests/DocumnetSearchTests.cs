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
                var documentNumberSearchPage = new DocumentNumberSearchPage(driver);
                documentNumberSearchPage.NavigateTo();

                // act

                // Code to submict a document number query
                documentNumberSearchPage.EnterDocumentNumber("2017000012");
                documentNumberSearchPage.PreformSearch();
                WebPageDelay.Pause(5000);

                // assert
            }
        }
    }
}
