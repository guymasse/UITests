using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace UITests.PageObjectModels
{
    class DocumentNumberSearchPage
    {
        private readonly IWebDriver Driver;
//        private const string PageUrl = "https://ecsworkbench.tyler-eagle.com/cdweb/search/DOCSEARCH215S2";
        private const string PageUrl = "http://dbkpvrecapp01:8100/cdweb/search/DOCSEARCH215S2";
        public const string PageTitle = "Document Number Search - Web/Intranet";

        public DocumentNumberSearchPage(IWebDriver driver)
        {
            Driver = driver;
        }

        // Common Wait code
        WebDriverWait Wait => new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

        //Get page elements
        private IWebElement PageText =>
            Wait.Until(e => e.FindElement(By.XPath("//li[@data-role='list-divider'][contains(.,'Document Number Search - Web/Intranet')]")));

        // Documnet Number field
        public IWebElement DocumentNumber =>
            Wait.Until(e => e.FindElement(By.Id("field_DocumentNumberID")));

        //Document Search Button
        public IWebElement DocumentSearchButtonr =>
            Wait.Until(e => e.FindElement(By.Id("searchButton")));

        public IWebElement SearchResult =>
            Wait.Until(e => e.FindElement(By.XPath("//div[@class='selfServiceSearchResultHeaderLeft'][contains(.,'Document Number Search - Web/Intranet  Document Number equals 2017000012')]")));

        public void NavigateTo()
        {
            Driver.Navigate().GoToUrl(PageUrl);
            EnsurePageLoaded();
        }
        public void EnsurePageLoaded()
        {
            bool pageHasLoaded = (Driver.Url == PageUrl) && (PageText.Text == PageTitle);

            if (!pageHasLoaded)
            {
                throw new Exception($"Failed to load page. Page Url = {Driver.Url} Page Source: \r\n  {PageText.Text}");
            }
        }
        public void EnterDocumentNumber(string documentNumber)
        {
            DocumentNumber.SendKeys(documentNumber);
        }
        public void PreformSearch()
        {

            DocumentSearchButtonr.Click();
        }

    }
}
