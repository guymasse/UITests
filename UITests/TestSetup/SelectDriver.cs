using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;

namespace UITests.TestSetup
{
    class SelectDriver :IDisposable
    {
        public IWebDriver Driver { get; private set; }

        public SelectDriver()
        {
            Driver = new ChromeDriver();
            //Driver = new FirefoxDriver();
            //Driver = new EdgeDriver();
        }

        // Common Wait code

        public void Dispose()
        {
            Driver.Dispose();
        }
    }
}
