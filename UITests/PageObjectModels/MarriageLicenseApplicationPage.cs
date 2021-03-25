using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace UITests.PageObjectModels
{
    class MarriageLicenseApplicationPage
    {
        private readonly IWebDriver Driver;
//        private const string publicMarriageApplicationUrl = "https://ecsworkbench.tyler-eagle.com/cdweb/wizard/WIZARD201S1";
        private const string marriageLicenseApplicationUrl = "http://dbkpvrecapp01:8100/cdweb/action/ACTIONGROUP201S2";
        public const string marriageLicenseApplicationTitle = "Marriage License Application";

        public MarriageLicenseApplicationPage(IWebDriver driver)
        {
            Driver = driver;
        }
        // Common Wait code
        WebDriverWait Wait => new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

        public IWebElement PageText => Driver.FindElement(By.XPath("//h1[contains(.,'Public Marriage License Requirements')]"));

        // Public Marriage Button
        public IWebElement PublicMarriageButton =>
            Wait.Until(e => e.FindElement(By.XPath("//div[@class='ss-action-internal'][contains(.,'Public Marriage Application')]")));

        // Confidential Marriage Button
        public IWebElement ConfidentialMarriageButton =>
            Wait.Until(e => e.FindElement(By.XPath("//div[@class='ss-action-internal'][contains(.,'Confidential Marriage Application')]")));

        public void NavigateTo()
        {
            Driver.Navigate().GoToUrl(marriageLicenseApplicationUrl);
            EnsurePageLoaded();
        }
        public void EnsurePageLoaded()
        {
            bool pageHasLoaded = (Driver.Url.Substring(0, 50) == marriageLicenseApplicationUrl) && (PageText.Text == marriageLicenseApplicationTitle);

            if (!pageHasLoaded)
            {
                throw new Exception($"Failed to load page. Page Url = {Driver.Url.Substring(0, 50)} Page Source: \r\n  {Driver.PageSource}");
            }
        }

    }
}
