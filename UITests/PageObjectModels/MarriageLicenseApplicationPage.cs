using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace UITests.PageObjectModels
{
    class MarriageLicenseApplicationPage
    {
        private readonly IWebDriver Driver;
        public const string marriageLicenseApplicationTitle = "Marriage License Application";

        public MarriageLicenseApplicationPage(IWebDriver driver)
        {
            Driver = driver;
        }

        // Common Wait code
        WebDriverWait Wait => new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

        // Page Text
        public IWebElement PageText =>
            Wait.Until(e => e.FindElement(By.XPath("//h1[contains(.,'Marriage License Application')]")));

        // Public Marriage Button
        public IWebElement PublicMarriageButton =>
            Wait.Until(e => e.FindElement(By.XPath("//div[@class='ss-action-internal'][contains(.,'Public Marriage Application')]")));

        // Confidential Marriage Button
        public IWebElement ConfidentialMarriageButton =>
            Wait.Until(e => e.FindElement(By.XPath("//div[@class='ss-action-internal'][contains(.,'Confidential Marriage Application')]")));

        public void EnsurePageLoaded()
        {
            bool pageHasLoaded = (PageText.Text == marriageLicenseApplicationTitle);

            if (!pageHasLoaded)
            {
                throw new Exception($"Failed to load page. Page Url = {Driver.Url.Substring(0, 50)} Page Source: \r\n  {Driver.PageSource}");
            }
        }

    }
}
