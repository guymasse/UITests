using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace UITests.PageObjectModels
{
    class FBNSearchPage
    {
        private readonly IWebDriver Driver;
        public const string PageTitle = "Search Fictition Business Names";

        public FBNSearchPage(IWebDriver driver)
        {
            Driver = driver;
        }

        // Common Wait code
        WebDriverWait Wait => new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

        //Get page elements
        private IWebElement PageText =>
            Wait.Until(e => e.FindElement(By.XPath("//li[contains(.,'Search Fictition Business Names')]")));
        public void EnsurePageLoaded()
        {
            bool pageHasLoaded = (PageText.Text == PageTitle);

            if (!pageHasLoaded)
            {
                throw new Exception($"Failed to load page. Page Url = {Driver.Url.Substring(0, 50)} Page Source: \r\n  {PageText.Text}");
            }
        }
    }
}
