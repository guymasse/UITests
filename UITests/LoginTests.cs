﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UITests
{
    [TestClass]
    public class LoginTests
    {
        [TestMethod]
        public void LogIn()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                // arrange
                var homePage = new PageObjectModels.HomePage(driver);
                homePage.NavigateTo();

                // act

                homePage.LogIn();

                WebPageDelay.Pause(10000);

                // assert
                Assert.AreEqual("Welcome Guy Masse", homePage.LoginMessage.Text);
            }

        }
    }
}