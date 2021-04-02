﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace UITests.PageObjectModels
{
    class BasicSearchPage
    {
        private readonly IWebDriver Driver;
        public const string PageTitle = "Basic Search - Web/Intranet";

        public BasicSearchPage(IWebDriver driver)
        {
            Driver = driver;
        }

        // Common Wait code
        WebDriverWait Wait => new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

        //Get page elements
        private IWebElement PageText => 
            Wait.Until(e => e.FindElement(By.XPath("//li[contains(.,'Basic Search - Web/Intranet')]")));

        //Document Search Button
        public IWebElement DocumentSearchButton =>
            Wait.Until(e => e.FindElement(By.Id("searchButton")));


        public void EnsurePageLoaded()
        {
            bool pageHasLoaded = (PageText.Text == PageTitle);

            if (!pageHasLoaded)
            {
                throw new Exception($"Failed to load page. Page Url = {Driver.Url} Page Source: \r\n  {PageText.Text}");
            }
        }
        public void PreformSearch()
        {

            DocumentSearchButton.Click();
        }

    }
}
