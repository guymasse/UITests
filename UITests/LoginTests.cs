using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using UITests.TestSetup;

namespace UITests
{
    [TestClass]
    public class LoginTests
    {
        [TestMethod]
        public void LogIn()
        {
            using (IWebDriver driver = new SelectDriver().Driver)
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
        [TestMethod]
        public void UserProfile()
        {
            using (IWebDriver driver = new SelectDriver().Driver)
            {
                // arrange
                var homePage = new PageObjectModels.HomePage(driver);
                homePage.NavigateTo();

                // act

                homePage.LogIn();

                WebPageDelay.Pause(10000);

                homePage.UserProfile();

                // assert
                Assert.AreEqual("Profile Information", homePage.UserProfileText.Text);
            }
        }
        [TestMethod]
        public void UserProfileSave()
        {
            using (IWebDriver driver = new SelectDriver().Driver)
            {
                // arrange
                var homePage = new PageObjectModels.HomePage(driver);
                homePage.NavigateTo();

                // act

                homePage.LogIn();

                WebPageDelay.Pause(10000);

                homePage.UserProfile();
                homePage.UserProfileSaveButton.Click();

                // assert
                Assert.AreEqual("Welcome Guy Masse", homePage.LoginMessage.Text);
            }
        }
        [TestMethod]
        public void UserProfileCancel()
        {
            using (IWebDriver driver = new SelectDriver().Driver)
            {
                // arrange
                var homePage = new PageObjectModels.HomePage(driver);
                homePage.NavigateTo();

                // act

                homePage.LogIn();

                WebPageDelay.Pause(10000);

                homePage.UserProfile();
                homePage.UserProfileCancelButton.Click();

                // assert
                Assert.AreEqual("Welcome Guy Masse", homePage.LoginMessage.Text);
            }
        }
        [TestMethod]
        public void LogOut()
        {
            using (IWebDriver driver = new SelectDriver().Driver)
            {
                // arrange
                var homePage = new PageObjectModels.HomePage(driver);
                homePage.NavigateTo();

                // act

                homePage.LogIn();

                WebPageDelay.Pause(10000);

                homePage.Logout();
                WebPageDelay.Pause(10000);

                // assert
                Assert.AreEqual("Please log in", homePage.LoginMessage.Text);
            }

        }

    }
}
