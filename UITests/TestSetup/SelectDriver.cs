using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace UITests.TestSetup
{
    class SelectDriver
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
