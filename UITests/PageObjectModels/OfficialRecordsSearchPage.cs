using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace UITests.PageObjectModels
{
    class OfficialRecordsSearchPage
    {
        private readonly IWebDriver Driver;
        public const string PageTitle = "Official Records Search - Web/Intranet";

        public OfficialRecordsSearchPage(IWebDriver driver)
        {
            Driver = driver;
        }

        // Common Wait code
        WebDriverWait Wait => new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

        //Get page text
        private IWebElement PageText => 
            Wait.Until(e => e.FindElement(By.XPath("//h1[contains(.,'Official Records Search - Web/Intranet')]")));

        // Basic Search
        public IWebElement BasicSearchLink => 
            Wait.Until(e => e.FindElement(By.XPath("//div[@class='ss-action-internal'][contains(.,'Basic Search - Web/Intranet')]")));

        // Document Number Search
        public IWebElement DocumentNumberSearchLink =>
            Wait.Until(e => e.FindElement(By.XPath("//div[@class='ss-action-internal'][contains(.,'Document Number Search - Web/Intranet')]")));

        //Document Type Search
        public IWebElement DocumentTypeSearchLink =>
            Wait.Until(e => e.FindElement(By.XPath("//div[@class='ss-action-internal'][contains(.,'Document Type Search - Web/Intranet')]")));

        //Map Book Page Search
        public IWebElement MapBookPageSearchLink =>
            Wait.Until(e => e.FindElement(By.XPath("//div[@class='ss-action-internal'][contains(.,'Map Book/Page Search - Web/Intranet')]")));

        //Advance Search
        public IWebElement AdvanceSearchLink =>
            Wait.Until(e => e.FindElement(By.XPath("//div[@class='ss-action-internal'][contains(.,'Advanced Search - Web/Intranet')]")));

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
