using OpenQA.Selenium;
using System;


namespace UITests.PageObjectModels
{
    class PublicMarriageApplicationPage
    {
        private readonly IWebDriver Driver;
//        private const string publicMarriageApplicationUrl = "https://ecsworkbench.tyler-eagle.com/cdweb/wizard/WIZARD201S1";
        private const string publicMarriageApplicationUrl = "http://dbkpvrecapp01:8100/cdweb/wizard/WIZARD201S1";
        public const string publicMarriageApplicationTitle = "Public Marriage License Requirements";

        public PublicMarriageApplicationPage(IWebDriver driver)
        {
            Driver = driver;
        }
        public IWebElement PageText => Driver.FindElement(By.XPath("//h1[contains(.,'Public Marriage License Requirements')]"));
        public void NavigateTo()
        {
            Driver.Navigate().GoToUrl(publicMarriageApplicationUrl);
            EnsurePageLoaded();
        }
        public void EnsurePageLoaded()
        {
            bool pageHasLoaded = (Driver.Url.Substring(0, 61) == publicMarriageApplicationUrl) && (PageText.Text == publicMarriageApplicationTitle);

            if (!pageHasLoaded)
            {
                throw new Exception($"Failed to load page. Page Url = {Driver.Url.Substring(0, 61)} Page Source: \r\n  {Driver.PageSource}");
            }
        }

    }
}
