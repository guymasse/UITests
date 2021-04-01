using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace UITests.PageObjectModels
{
    class PublicMarriageApplicationPage
    {
        private readonly IWebDriver Driver;
        public const string publicMarriageApplicationTitle = "Public Marriage License Requirements";

        public PublicMarriageApplicationPage(IWebDriver driver)
        {
            Driver = driver;
        }
        // Common Wait code
        WebDriverWait Wait => new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

        //Page Title
        private IWebElement PageText =>
            Wait.Until(e => e.FindElement(By.XPath("//h1[contains(.,'Public Marriage License Requirements')]")));

        //Get Next Button
        public IWebElement NextButton =>
            Wait.Until(e => e.FindElement(By.XPath("//a[@class='ss-right ui-link ui-btn ui-btn-a ui-icon-arrow-r ui-btn-icon-right ui-btn-inline ui-shadow ui-corner-all'][contains(.,'Next')]")));

        // Get Radio Button
        public IWebElement SelectedRadio =>
            Wait.Until(e => e.FindElement(By.XPath("//label[@class='ui-btn ui-corner-all ui-btn-a ui-btn-icon-left ui-radio-off ui-last-child']")));

        //Get ID Type Drop Down
        public IWebElement IdTypeDropDown =>
            Wait.Until(e => e.FindElement(By.XPath("//select[contains(@id,'field_GroomIDType')]")));


        public void EnsurePageLoaded()
        {
            bool pageHasLoaded = (PageText.Text == publicMarriageApplicationTitle);

            if (!pageHasLoaded)
            {
                throw new Exception($"Failed to load page. Page Url = {Driver.Url.Substring(0, 50)} Page Source: \r\n  {Driver.PageSource}");
            }
        }

    }
}
