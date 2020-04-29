using OpenQA.Selenium;
using System;

namespace UITests.PageObjectModels
{
    class HomePage
    {
        private readonly IWebDriver Driver;
        private const string PageUrl = "http://lkwdvsvrecapp1:7061/cdweb/";
        public const string PageTitle = "Self-Service";

        public HomePage(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebElement LoginButton => Driver.FindElement(By.XPath("//span[@class='ss-header-labels'][contains(.,'Log in')]"));
        public void NavigateTo()
        {
            Driver.Navigate().GoToUrl(PageUrl);
            EnsurePageLoaded();
        }

        public void EnsurePageLoaded()
        {
            bool pageHasLoaded = (Driver.Url == PageUrl) && (Driver.Title == PageTitle);

            if (!pageHasLoaded)
            {
                throw new Exception($"Failed to load page. Page Url = {Driver.Url} Page Source: \r\n  {Driver.PageSource}");
            }
        }
    }
}
