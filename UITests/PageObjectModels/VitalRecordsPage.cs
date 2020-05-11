using OpenQA.Selenium;
using System;


namespace UITests.PageObjectModels
{
    class VitalRecordsPage
    {
        private readonly IWebDriver Driver;
        private const string vitalRecordsUrl = "https://ecsworkbench.tyler-eagle.com/cdweb/action/ACTIONGROUP201S1";
        public const string vitalRecordsTitle = "Vital Records Certified Copies";
        
        public VitalRecordsPage(IWebDriver driver)
        {
            Driver = driver;
        }
        public IWebElement PageText => Driver.FindElement(By.XPath("//h1[contains(.,'Vital Records Certified Copies')]"));

        public void NavigateTo()
        {
            Driver.Navigate().GoToUrl(vitalRecordsUrl);
            EnsurePageLoaded();
        }
        public void EnsurePageLoaded()
        {
            bool pageHasLoaded = (Driver.Url == vitalRecordsUrl) && (PageText.Text == vitalRecordsTitle);

            if (!pageHasLoaded)
            {
                throw new Exception($"Failed to load page. Page Url = {Driver.Url} Page Source: \r\n  {Driver.PageSource}");
            }
        }

    }

}
