using OpenQA.Selenium;
using System;


namespace UITests.PageObjectModels
{
    class PublicMarriageCertificatePage
    {
        private readonly IWebDriver Driver;
//        private const string publicMarriageCertificateUrl = "https://ecsworkbench.tyler-eagle.com/cdweb/wizard/COPYREQUEST201S3";
        private const string publicMarriageCertificateUrl = "http://dbkpvrecapp01:8100/cdweb/wizard/COPYREQUEST201S3";
        public const string publicMarriageCertificateTitle = "Public Marriage Certificate Authorized Copies";

        public PublicMarriageCertificatePage(IWebDriver driver)
        {
            Driver = driver;
        }
        public IWebElement PageText => Driver.FindElement(By.XPath("//h1[contains(.,'Public Marriage Certificate Authorized Copies')]"));
        public void NavigateTo()
        {
            Driver.Navigate().GoToUrl(publicMarriageCertificateUrl);
            EnsurePageLoaded();
        }
        public void EnsurePageLoaded()
        {
            bool pageHasLoaded = (Driver.Url.Substring(0, 66) == publicMarriageCertificateUrl) && (PageText.Text == publicMarriageCertificateTitle);

            if (!pageHasLoaded)
            {
                throw new Exception($"Failed to load page. Page Url = {Driver.Url.Substring(0, 66)} Page Source: \r\n  {Driver.PageSource}");
            }
        }
    }
}
