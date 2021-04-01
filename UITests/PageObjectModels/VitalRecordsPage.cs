using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace UITests.PageObjectModels
{
    class VitalRecordsPage
    {
        private readonly IWebDriver Driver;
        public const string vitalRecordsTitle = "Vital Records Certified Copies";
        
        public VitalRecordsPage(IWebDriver driver)
        {
            Driver = driver;
        }
        // Common Wait code
        WebDriverWait Wait => new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

        //Page Title
        public IWebElement PageText =>
            Wait.Until(e => e.FindElement(By.XPath("//h1[contains(.,'Vital Records Certified Copies')]")));

        // Birth Certificate Link
        public IWebElement BirthCertificatelink =>
            Wait.Until(e => e.FindElement(By.XPath("//div[@class='ss-action-internal'][contains(.,'Birth Certificate')]")));

        // Death Certificate Link
        public IWebElement DeathCertificatelink =>
            Wait.Until(e => e.FindElement(By.XPath("//div[@class='ss-action-internal'][contains(.,'Death Certificate')]")));

        // Public Marriage Certificate Link
        public IWebElement PublicMarriageCertificatelink =>
            Wait.Until(e => e.FindElement(By.XPath("//div[@class='ss-action-internal'][contains(.,'Public Marriage Certificate')]")));

        // Confidential Marriage Certificate Link
        public IWebElement ConfidentialMarriageCertificatelink =>
            Wait.Until(e => e.FindElement(By.XPath("//div[@class='ss-action-internal'][contains(.,'Confidential Marriage Certificate')]")));


        public void EnsurePageLoaded()
        {
            bool pageHasLoaded = (PageText.Text == vitalRecordsTitle);

            if (!pageHasLoaded)
            {
                throw new Exception($"Failed to load page. Page Url = {Driver.Url} Page Source: \r\n  {Driver.PageSource}");
            }
        }

    }

}
