using OpenQA.Selenium;
using System;


namespace UITests.PageObjectModels
{
    class BirthCertificatePage
    {
        private readonly IWebDriver Driver;
        private const string birthCertificateUrl = "https://ecsworkbench.tyler-eagle.com/cdweb/wizard/COPYREQUEST201S1";
        public const string birthCertificateTitle = "Birth Certificate Authorized Copies";

        public BirthCertificatePage(IWebDriver driver)
        {
            Driver = driver;
        }
        public IWebElement PageText => Driver.FindElement(By.XPath("//h1[contains(.,'Birth Certificate Authorized Copies')]"));

        public void NavigateTo()
        {
            Driver.Navigate().GoToUrl(birthCertificateUrl);
            EnsurePageLoaded();
        }
        public void EnsurePageLoaded()
        {
            bool pageHasLoaded = (Driver.Url.Substring(0, 66) == birthCertificateUrl) && (PageText.Text == birthCertificateTitle);

            if (!pageHasLoaded)
            {
                throw new Exception($"Failed to load page. Page Url = {Driver.Url.Substring(0, 66)} Page Source: \r\n  {Driver.PageSource}");
            }
        }


    }
}
