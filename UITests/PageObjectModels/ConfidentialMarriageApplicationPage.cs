using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace UITests.PageObjectModels
{
    class ConfidentialMarriageApplicationPage
    {
        private readonly IWebDriver Driver;
        public const string confidentialMarriageApplicationTitle = "Confidential Marriage License Requirements";

        public ConfidentialMarriageApplicationPage(IWebDriver driver)
        {
            Driver = driver;
        }

        // Common Wait code
        WebDriverWait Wait => new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

        public IWebElement PageText => 
            Wait.Until(e => e.FindElement(By.XPath("//h1[contains(.,'Confidential Marriage License Requirements')]")));

        public void EnsurePageLoaded()
        {
            bool pageHasLoaded = (PageText.Text == confidentialMarriageApplicationTitle);

            if (!pageHasLoaded)
            {
                throw new Exception($"Failed to load page. Page Url = {Driver.Url.Substring(0, 50)} Page Source: \r\n  {Driver.PageSource}");
            }
        }

    }
}
