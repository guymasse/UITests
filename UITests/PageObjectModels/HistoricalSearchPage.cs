using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace UITests.PageObjectModels
{
    class HistoricalSearchPage
    {
        private readonly IWebDriver Driver;
        public const string historicalTitle = "Historical Index Search";

        public HistoricalSearchPage(IWebDriver driver)
        {
            Driver = driver;
        }

        // Common Wait code
        WebDriverWait Wait => new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

        //Get page elements
        private IWebElement PageText =>
            Wait.Until(e => e.FindElement(By.XPath("//li[contains(.,'Historical Index Search')]")));

        public void EnsurePageLoaded()
        {
            bool pageHasLoaded = (PageText.Text == historicalTitle);

            if (!pageHasLoaded)
            {
                throw new Exception($"Failed to load page. Page Url = {Driver.Url} Page Source: \r\n  {Driver.PageSource}");
            }
        }
    }
}
