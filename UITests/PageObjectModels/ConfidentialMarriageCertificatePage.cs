using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace UITests.PageObjectModels
{
    class ConfidentialMarriageCertificatePage
    {
        private readonly IWebDriver Driver;
        public const string confidentialMarriageCertificateTitle = "Confidential Marriage Certificate Copies";

        public ConfidentialMarriageCertificatePage(IWebDriver driver)
        {
            Driver = driver;
        }
        // Common Wait code
        WebDriverWait Wait => new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

        public IWebElement PageText =>
            Wait.Until(e => e.FindElement(By.XPath("//h1[contains(.,'Confidential Marriage Certificate Copies')]")));

        public void EnsurePageLoaded()
        {
            bool pageHasLoaded = (PageText.Text == confidentialMarriageCertificateTitle);

            if (!pageHasLoaded)
            {
                throw new Exception($"Failed to load page. Page Url = {Driver.Url.Substring(0, 55)} Page Source: \r\n  {Driver.PageSource}");
            }
        }
    }
}
