using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace UITests.PageObjectModels
{
    class FBNRenewalPage
    {
        private readonly IWebDriver Driver;
        public const string PageTitle = "Fictitious Business Names Search - Renewal";

        public FBNRenewalPage(IWebDriver driver)
        {
            Driver = driver;
        }

        // Common Wait code
        WebDriverWait Wait => new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

        //Get page elements
        private IWebElement PageText =>
            Wait.Until(e => e.FindElement(By.XPath("//li[@data-role='list-divider'][contains(.,'Fictitious Business Names Search - Renewal')]")));

        public void EnsurePageLoaded()
        {
            bool pageHasLoaded = (PageText.Text == PageTitle);

            if (!pageHasLoaded)
            {
                throw new Exception($"Failed to load page. Page Url = {Driver.Url} Page Source: \r\n  {PageText.Text}");
            }
        }

    }
}
