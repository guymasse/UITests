using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace UITests.PageObjectModels
{
    class DeathCertificatePage
    {
        private readonly IWebDriver Driver;
        public const string deathCertificateTitle = "Death Certificate Authorized Copies";
  
        public DeathCertificatePage(IWebDriver driver)
        {
            Driver = driver;
        }

        // Common Wait code
        WebDriverWait Wait => new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

        // Get page Text
        private IWebElement PageText =>
            Wait.Until(e => e.FindElement(By.XPath("//h1[contains(.,'Death Certificate Authorized Copies')]")));

        //Get Radio Button
        public IWebElement SelectedRadio =>
            Wait.Until(e => e.FindElement(By.XPath("//label[@class='ui-btn ui-corner-all ui-btn-a ui-btn-icon-left ui-radio-off ui-first-child']")));


        // Get Next Button
        public IWebElement NextButton =>
            Wait.Until(e => e.FindElement(By.XPath("//a[@class='ss-right ui-link ui-btn ui-btn-a ui-icon-arrow-r ui-btn-icon-right ui-btn-inline ui-shadow ui-corner-all'][contains(.,'Next')]")));

        public void EnsurePageLoaded()
        {
            bool pageHasLoaded = (PageText.Text == deathCertificateTitle);

            if (!pageHasLoaded)
            {
                throw new Exception($"Failed to load page. Page Url = {Driver.Url.Substring(0, 55)} Page Source: \r\n  {Driver.PageSource}");
            }
        }


    }
}
