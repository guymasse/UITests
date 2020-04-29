using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITests.PageObjectModels
{
    class AdvanceSearchPage
    {
        private readonly IWebDriver Driver;
        private const string PageUrl = "http://lkwdvsvrecapp1:7061/cdweb/search/DOCSEARCH215S4";
        public const string PageTitle = "Advanced Search - Web/Intranet";



        public AdvanceSearchPage(IWebDriver driver)
        {
            Driver = driver;
        }
       
        private IWebElement PageText => Driver.FindElement(By.XPath("//li[@data-role='list-divider'][contains(.,'Advanced Search - Web/Intranet')]"));

        public IWebElement DocumentNumber => Driver.FindElement(By.Id("field_DocumentNumberID"));

        public IWebElement AdvanceSearchCheckBox => Driver.FindElement(By.XPath("//label[@for='field_UseAdvancedSearch'][contains(.,'Use Advanced Name Searching (What is this?)')]"));


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

            DocumentNumber.Submit();
        }

    }
}
