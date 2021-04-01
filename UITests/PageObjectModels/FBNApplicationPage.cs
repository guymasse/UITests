using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace UITests.PageObjectModels
{
    class FBNApplicationPage
    {
        private readonly IWebDriver Driver;
        public const string PageTitle = "Fictitious Business Names Application";

        public FBNApplicationPage(IWebDriver driver)
        {
            Driver = driver;
        }

        // Common Wait code
        WebDriverWait Wait => new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

        //Get page elements

        //Get Page Text
        private IWebElement PageText =>
            Wait.Until(e => e.FindElement(By.XPath("//h1[contains(.,'Fictitious Business Names Application')]")));
        
        //Get Search FBN Link
        public IWebElement SearchFBNLink =>
            Wait.Until(e => e.FindElement(By.XPath("//div[@class='ss-action-internal'][contains(.,'Search Fictition Business Names')]")));

        //Get FBN New Filling Link
        public IWebElement NewFillingLink =>
            Wait.Until(e => e.FindElement(By.XPath("//h1[contains(.,'New Filing')]")));

        //Get FBN Renewal Link
        public IWebElement RenewalLink =>
            Wait.Until(e => e.FindElement(By.XPath("//h1[contains(.,'Renewal')]")));

        //Get FBN Withdraw Link
        public IWebElement WithdrawalLink =>
            Wait.Until(e => e.FindElement(By.XPath("//h1[contains(.,'Withdraw from a Partnership')]")));

        //Get FBN Renewal Link
        public IWebElement AbandonmentLink =>
            Wait.Until(e => e.FindElement(By.XPath("//h1[contains(.,'Abandonment')]")));

        public void EnsurePageLoaded()
        {
            bool pageHasLoaded = (PageText.Text == PageTitle);

            if (!pageHasLoaded)
            {
                throw new Exception($"Failed to load page. Page Url = {Driver.Url.Substring(0, 50)} Page Source: \r\n  {PageText.Text}");
            }
        }
    }
}
