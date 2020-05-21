using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using UITests.TestSetup;

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

        // Common Wait code
        WebDriverWait Wait => new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
        // Text on page
        public IWebElement PageText => 
            Wait.Until(e => e.FindElement(By.XPath("//h1[contains(.,'Birth Certificate Authorized Copies')]")));

        // Cancel Button
        public IWebElement CancelButton =>
            Wait.Until(e => e.FindElement(By.XPath("//a[contains(@class,'ui-link ui-btn ui-btn-a ui-icon-delete ui-btn-icon-left ui-btn-inline ui-shadow ui-corner-all')]")));

        // Next Button
        public IWebElement NextButton =>
            Wait.Until(e => e.FindElement(By.XPath("//a[@class='ss-right ui-link ui-btn ui-btn-a ui-icon-arrow-r ui-btn-icon-right ui-btn-inline ui-shadow ui-corner-all'][contains(.,'Next')]")));
        // Next Button
        public IWebElement PreviousButton =>
            Wait.Until(e => e.FindElement(By.XPath("//a[@class='ss-right ui-link ui-btn ui-btn-a ui-icon-arrow-l ui-btn-icon-left ui-btn-inline ui-shadow ui-corner-all'][contains(.,'Previous')]")));

        // STEP 1
        // I am radio button (The registrant)
        public IWebElement Step1IAm =>
            Wait.Until(e => e.FindElement(By.XPath("//label[@class='ui-btn ui-corner-all ui-btn-a ui-btn-icon-left ui-radio-off ui-first-child']")));

        // STEP 2
        // Text on page
        public IWebElement Step2PageText => 
            Wait.Until(e => e.FindElement(By.XPath("//h1[contains(.,'Birth Record Information')]")));

        // Step 2 Required fields
        public IWebElement Step2FirstName =>
            Wait.Until(e => e.FindElement(By.Id("field_BirthFirstName")));

        public IWebElement Step2LastName =>
            Wait.Until(e => e.FindElement(By.Id("field_BirthLastName")));

        public IWebElement Step2DateOfBirthe =>
            Wait.Until(e => e.FindElement(By.Id("field_DateofBirth")));

        public IWebElement Step2CityOfBirthe =>
            Wait.Until(e => e.FindElement(By.Id("field_CityofBirth")));


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
