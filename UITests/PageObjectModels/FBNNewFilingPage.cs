using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace UITests.PageObjectModels
{
    class FBNNewFilingPage
    {
        private readonly IWebDriver Driver;
        private const string PageUrl = "https://ecsworkbench.tyler-eagle.com/cdweb/wizard/WIZARD201S2";
        public const string PageTitle = "New Filing Requirements";

        public FBNNewFilingPage(IWebDriver driver)
        {
            Driver = driver;
        }

        // Common Wait code
        WebDriverWait Wait => new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

        //Get page elements
        private IWebElement PageText =>
            Wait.Until(e => e.FindElement(By.XPath("//h1[contains(.,'New Filing Requirements')]")));
        public void NavigateTo()
        {
            Driver.Navigate().GoToUrl(PageUrl);
            EnsurePageLoaded();
        }
        public void EnsurePageLoaded()
        {
            bool pageHasLoaded = (Driver.Url.Substring(0, 61) == PageUrl) && (PageText.Text == PageTitle);

            if (!pageHasLoaded)
            {
                throw new Exception($"Failed to load page. Page Url = {Driver.Url.Substring(0, 61)} Page Source: \r\n  {PageText.Text}");
            }
        }
    }
}
