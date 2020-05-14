using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace UITests.PageObjectModels
{
    class HomePage
    {
        private readonly IWebDriver Driver;
        private const string PageUrl = "https://ecsworkbench.tyler-eagle.com/cdweb/";
        public const string PageTitle = "Self-Service";

        public HomePage(IWebDriver driver)
        {
            Driver = driver;
        }

        // Common Wait code
        WebDriverWait Wait => new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

        // Login Button
        public IWebElement LoginButton => Wait.Until(e => e.FindElement(By.XPath("//span[@class='ss-header-labels'][contains(.,'Log in')]")));

        // Login User Name
        public IWebElement LoginName => Wait.Until(e => e.FindElement(By.Id("field_UserId")));

        // Login in Password
        public IWebElement LoginPassword => Wait.Until(e => e.FindElement(By.Id("field_Password")));

        // Login Submit Button
        public IWebElement LoginSubmitButton => Wait.Until(e => e.FindElement(By.Id("loginSubmit")));

        //Login  Message
        public IWebElement LoginMessage => Wait.Until(e => e.FindElement(By.Id("ss-user-welcome")));

        // Account Button
        public IWebElement AccountButton => Wait.Until(e => e.FindElement(By.XPath("//span[@class='ss-header-labels'][contains(.,'Account')]")));

        // Logout Button
        public IWebElement LogoutButton => Wait.Until(e => e.FindElement(By.XPath("//button[@data-icon='check'][contains(.,'Log Out')]")));


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
    }
}
