using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITests.PageObjectModels
{
    class HistoricalSearchPage
    {
        private readonly IWebDriver Driver;
        public const string historicalTitle = "Self-Service: Historical Index";

        public HistoricalSearchPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public void EnsurePageLoaded()
        {
            bool pageHasLoaded = (Driver.Title == historicalTitle);

            if (!pageHasLoaded)
            {
                throw new Exception($"Failed to load page. Page Url = {Driver.Url} Page Source: \r\n  {Driver.PageSource}");
            }
        }
    }
}
