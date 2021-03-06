﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using System;

namespace UITests.TestSetup
{
    class SelectDriver :IDisposable
    {
        public IWebDriver Driver { get; private set; }

        public SelectDriver()
        {
            //Driver = new ChromeDriver();
            //Driver = new FirefoxDriver();
            EdgeOptions options = new EdgeOptions();
            Driver = new EdgeDriver("C:\\Automation\\Selenium\\edgedriver_win64", options);
        }

 
        public void Dispose()
        {
            Driver.Dispose();
        }
    }
    class SelectUrl
    {
        public String TestUrl { get; private set; }
        public SelectUrl()
        {
            TestUrl = "http://dbkpvrecapp01:8100/cdweb";
        }
    }
}
