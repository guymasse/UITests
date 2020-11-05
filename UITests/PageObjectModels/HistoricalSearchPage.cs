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
//        public const string historicalUrl = "https://ecsworkbench.tyler-eagle.com/cdweb/historicalIndex/HISTORICAL_INDEX987S1";
        public const string historicalUrl = "http://dbkpvrecapp01:8100/cdweb/historicalIndex/HISTORICAL_INDEX987S1";
        public const string historicalTitle = "Self-Service: Historical Index";

        public HistoricalSearchPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public void NavigateTo()
        {
            Driver.Navigate().GoToUrl(historicalUrl);
            EnsurePageLoaded();
        }

        public void EnsurePageLoaded()
        {
            bool pageHasLoaded = (Driver.Url == historicalUrl) && (Driver.Title == historicalTitle);

            if (!pageHasLoaded)
            {
                throw new Exception($"Failed to load page. Page Url = {Driver.Url} Page Source: \r\n  {Driver.PageSource}");
            }
        }

    }
}
