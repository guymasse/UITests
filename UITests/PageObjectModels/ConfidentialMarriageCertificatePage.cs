using OpenQA.Selenium;
using System;


namespace UITests.PageObjectModels
{
    class ConfidentialMarriageCertificatePage
    {
        private readonly IWebDriver Driver;
//        private const string publicMarriageCertificateUrl = "https://ecsworkbench.tyler-eagle.com/cdweb/wizard/COPYREQUEST201S3";
        private const string confidentialMarriageCertificateUrl = "http://dbkpvrecapp01:8100/cdweb/wizard/COPYREQUEST201S4";
        public const string confidentialMarriageCertificateTitle = "Confidential Marriage Certificate Copies";

        public ConfidentialMarriageCertificatePage(IWebDriver driver)
        {
            Driver = driver;
        }
        public IWebElement PageText => Driver.FindElement(By.XPath("//h1[contains(.,'Confidential Marriage Certificate Copies')]"));
        public void NavigateTo()
        {
            Driver.Navigate().GoToUrl(confidentialMarriageCertificateUrl);
            EnsurePageLoaded();
        }
        public void EnsurePageLoaded()
        {
            bool pageHasLoaded = (Driver.Url.Substring(0, 55) == confidentialMarriageCertificateUrl) && (PageText.Text == confidentialMarriageCertificateTitle);

            if (!pageHasLoaded)
            {
                throw new Exception($"Failed to load page. Page Url = {Driver.Url.Substring(0, 55)} Page Source: \r\n  {Driver.PageSource}");
            }
        }
    }
}
