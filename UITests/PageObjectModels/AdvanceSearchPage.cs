using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace UITests.PageObjectModels
{
    class AdvanceSearchPage
    {
        private readonly IWebDriver Driver;
 //       private const string PageUrl = "https://ecsworkbench.tyler-eagle.com/cdweb/search/DOCSEARCH215S4";
        private const string PageUrl = "http://dbkpvrecapp01:8100/cdweb/search/DOCSEARCH215S4";
        public const string PageTitle = "Advanced Search - Web/Intranet";



        public AdvanceSearchPage(IWebDriver driver)
        {
            Driver = driver;
        }

        // Common Wait code
        WebDriverWait Wait => new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

        //Get page elements
        private IWebElement PageText => 
            Wait.Until(e => e.FindElement(By.XPath("//li[@data-role='list-divider'][contains(.,'Advanced Search - Web/Intranet')]")));

        // Documnet Number field
        public IWebElement DocumentNumber => 
            Wait.Until(e => e.FindElement(By.Id("field_DocumentNumberID")));

        // Advance Search Checkbox
        public IWebElement AdvanceSearchCheckBox =>
            Wait.Until(e => e.FindElement(By.XPath("//label[@for='field_UseAdvancedSearch'][contains(.,'Use Advanced Name Searching (What is this?)')]")));
        //Document Search Button
        public IWebElement DocumentSearchButtonr =>
            Wait.Until(e => e.FindElement(By.Id("searchButton")));


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
