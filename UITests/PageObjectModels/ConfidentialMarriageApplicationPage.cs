using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace UITests.PageObjectModels
{
    class ConfidentialMarriageApplicationPage
    {
        private readonly IWebDriver Driver;
//        private const string publicMarriageApplicationUrl = "https://ecsworkbench.tyler-eagle.com/cdweb/wizard/WIZARD201S1";
        private const string confidentialMarriageApplicationUrl = "http://dbkpvrecapp01:8100/cdweb/wizard/WIZARD201S4";
        public const string confidentialMarriageApplicationTitle = "Confidential Marriage License Requirements";

        public ConfidentialMarriageApplicationPage(IWebDriver driver)
        {
            Driver = driver;
        }
        // Common Wait code
        WebDriverWait Wait => new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

        public IWebElement PageText => Driver.FindElement(By.XPath("//h1[contains(.,'Confidential Marriage License Requirements')]"));
        public void NavigateTo()
        {
            Driver.Navigate().GoToUrl(confidentialMarriageApplicationUrl);
            EnsurePageLoaded();
        }
        public void EnsurePageLoaded()
        {
            bool pageHasLoaded = (Driver.Url.Substring(0, 50) == confidentialMarriageApplicationUrl) && (PageText.Text == confidentialMarriageApplicationTitle);

            if (!pageHasLoaded)
            {
                throw new Exception($"Failed to load page. Page Url = {Driver.Url.Substring(0, 50)} Page Source: \r\n  {Driver.PageSource}");
            }
        }

    }
}
