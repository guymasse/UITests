using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace UITests.PageObjectModels
{
    class HomePage
    {
        private readonly IWebDriver Driver;
//        private const string PageUrl = "https://ecsworkbench.tyler-eagle.com/cdweb/";
        private const string PageUrl = "http://dbkpvrecapp01:8100/cdweb/";
        public const string PageTitle = "Self-Service";

        public HomePage(IWebDriver driver)
        {
            Driver = driver;
        }

        // Common Wait code
        WebDriverWait Wait => new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

        // Login Button
        public IWebElement LoginButton => 
            Wait.Until(e => e.FindElement(By.XPath("//span[@class='ss-header-labels'][contains(.,'Log in')]")));

        // Login User Name
        public IWebElement LoginName => 
            Wait.Until(e => e.FindElement(By.Id("field_UserId")));

        // Login in Password
        public IWebElement LoginPassword => 
            Wait.Until(e => e.FindElement(By.Id("field_Password")));

        // Login Submit Button
        public IWebElement LoginSubmitButton => 
            Wait.Until(e => e.FindElement(By.Id("loginSubmit")));

        //Login  Message
        public IWebElement LoginMessage => 
            Wait.Until(e => e.FindElement(By.Id("ss-user-welcome")));

        // Account Button
        public IWebElement AccountButton => 
            Wait.Until(e => e.FindElement(By.XPath("//span[@class='ss-header-labels'][contains(.,'Account')]")));

        // Logout Button
        public IWebElement LogoutButton => 
            Wait.Until(e => e.FindElement(By.XPath("//button[@data-icon='check'][contains(.,'Log Out')]")));

        // User Profile Button
        public IWebElement UserProfileButton => 
            Wait.Until(e => e.FindElement(By.XPath("//button[@class=' ui-btn ui-shadow ui-corner-all'][contains(.,'User Profile')]")));

        // User Profile Text
        public IWebElement UserProfileText => 
            Wait.Until(e => e.FindElement(By.XPath("//h4[@class='ss-group-title'][contains(.,'Profile Information')]")));

        // User Profile Save Button
        public IWebElement UserProfileSaveButton => 
            Wait.Until(e => e.FindElement(By.XPath("//a[@class='ss-right ui-link ui-btn ui-btn-a ui-icon-check ui-btn-icon-left ui-btn-inline ui-shadow ui-corner-all'][contains(.,'Save')]")));

        // User Profile Cancel Button
        public IWebElement UserProfileCancelButton => 
            Wait.Until(e => e.FindElement(By.XPath("//a[@class='ss-left ui-link ui-btn ui-btn-a ui-icon-delete ui-btn-icon-left ui-btn-inline ui-shadow ui-corner-all'][contains(.,'Cancel')]")));

        // Historical Index Link
        public IWebElement HistoricalIndexlink =>
            Wait.Until(e => e.FindElement(By.XPath("//h1[contains(.,'Historical Index Search')]")));

        // Vital Records Link
        public IWebElement VitalRecordslink =>
            Wait.Until(e => e.FindElement(By.XPath("//div[@class='ss-action-internal'][contains(.,'Vital Records Certified Copies')]")));

        // Marriage Application Link
        public IWebElement MarriageApplicationlink =>
            Wait.Until(e => e.FindElement(By.XPath("//h1[contains(.,'Marriage License Application')]")));

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

        // Login in
        public void LogIn()
        {
            LoginButton.Click();
            LoginName.SendKeys("guy");
            LoginPassword.SendKeys("guy12345");
            LoginSubmitButton.Click();
        }

        // Log out
        public void Logout()
        {
            AccountButton.Click();
            LogoutButton.Click();
        }

        //Account Info
        public void UserProfile()
        {
            AccountButton.Click();
            UserProfileButton.Click();

        }
    }
}
