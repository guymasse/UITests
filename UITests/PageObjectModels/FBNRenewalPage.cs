using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace UITests.PageObjectModels
{
    class FBNRenewalPage
    {
        private readonly IWebDriver Driver;
        private const string PageUrl = "https://ecsworkbench.tyler-eagle.com/cdweb/search/DOCSEARCH201S3";
        public const string PageTitle = "Fictitious Business Names Search - Renewal";

        public FBNRenewalPage(IWebDriver driver)
        {
            Driver = driver;
        }

        // Common Wait code
        WebDriverWait Wait => new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

        //Get page elements
        private IWebElement PageText =>
            Wait.Until(e => e.FindElement(By.XPath("//li[@data-role='list-divider'][contains(.,'Fictitious Business Names Search - Renewal')]")));
        public void NavigateTo()
        {
            Driver.Navigate().GoToUrl(PageUrl);
            WebPageDelay.Pause(10000);
            EnsurePageLoaded();
        }
        public void EnsurePageLoaded()
        {
            bool pageHasLoaded = (Driver.Url == PageUrl) && (PageText.Text == PageTitle);

            if (!pageHasLoaded)
            {
                throw new Exception($"Failed to load page. Page Url = {Driver.Url} Page Source: \r\n  {PageText.Text}");
            }
        }

    }
}
