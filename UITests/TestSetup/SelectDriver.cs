using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace UITests.TestSetup
{
    class SelectDriver :IDisposable
    {
        public IWebDriver Driver { get; private set; }

        public SelectDriver()
        {
            Driver = new ChromeDriver();
        }

        public void Dispose()
        {
            Driver.Dispose();
        }
    }
}
