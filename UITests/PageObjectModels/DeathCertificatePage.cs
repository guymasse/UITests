using OpenQA.Selenium;
using System;


namespace UITests.PageObjectModels
{
    class DeathCertificatePage
    {
        private readonly IWebDriver Driver;
//        private const string deathCertificateUrl = "https://ecsworkbench.tyler-eagle.com/cdweb/wizard/COPYREQUEST201S2";
        private const string deathCertificateUrl = "http://dbkpvrecapp01:8100/cdweb/wizard/COPYREQUEST201S2";
        public const string deathCertificateTitle = "Death Certificate Authorized Copies";
        public DeathCertificatePage(IWebDriver driver)
        {
            Driver = driver;
        }
        public IWebElement PageText => Driver.FindElement(By.XPath("//h1[contains(.,'Death Certificate Authorized Copies')]"));
        public void NavigateTo()
        {
            Driver.Navigate().GoToUrl(deathCertificateUrl);
            EnsurePageLoaded();
        }
        public void EnsurePageLoaded()
        {
            bool pageHasLoaded = (Driver.Url.Substring(0, 55) == deathCertificateUrl) && (PageText.Text == deathCertificateTitle);

            if (!pageHasLoaded)
            {
                throw new Exception($"Failed to load page. Page Url = {Driver.Url.Substring(0, 55)} Page Source: \r\n  {Driver.PageSource}");
            }
        }


    }
}
