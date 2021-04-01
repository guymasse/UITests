using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace UITests.PageObjectModels
{
    class PublicMarriageCertificatePage
    {
        private readonly IWebDriver Driver;
        public const string publicMarriageCertificateTitle = "Public Marriage Certificate Authorized Copies";

        public PublicMarriageCertificatePage(IWebDriver driver)
        {
            Driver = driver;
        }

        // Common Wait code
        WebDriverWait Wait => new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

        // Page Title
        public IWebElement PageText =>
            Wait.Until(e => e.FindElement(By.XPath("//h1[contains(.,'Public Marriage Certificate Authorized Copies')]")));
        
        public void EnsurePageLoaded()
        {
            bool pageHasLoaded = (PageText.Text == publicMarriageCertificateTitle);

            if (!pageHasLoaded)
            {
                throw new Exception($"Failed to load page. Page Url = {Driver.Url.Substring(0, 55)} Page Source: \r\n  {Driver.PageSource}");
            }
        }
    }
}
