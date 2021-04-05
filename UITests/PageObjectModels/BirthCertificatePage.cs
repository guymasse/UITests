using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using UITests.TestSetup;

namespace UITests.PageObjectModels
{
    class BirthCertificatePage
    {
        private readonly IWebDriver Driver;
        public const string birthCertificateTitle = "Birth Certificate Authorized Copies";

        public BirthCertificatePage(IWebDriver driver)
        {
            Driver = driver;
        }

        // Common Wait code
        WebDriverWait Wait => new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
        // Text on page
        public IWebElement PageText => 
            Wait.Until(e => e.FindElement(By.XPath("//h1[contains(.,'Birth Certificate Authorized Copies')]")));

        // Cancel Button
        public IWebElement CancelButton =>
            Wait.Until(e => e.FindElement(By.XPath("//a[contains(@class,'ui-link ui-btn ui-btn-a ui-icon-delete ui-btn-icon-left ui-btn-inline ui-shadow ui-corner-all')]")));

        // Next Button
        public IWebElement NextButton =>
            Wait.Until(e => e.FindElement(By.XPath("//a[@class='ss-right ui-link ui-btn ui-btn-a ui-icon-arrow-r ui-btn-icon-right ui-btn-inline ui-shadow ui-corner-all'][contains(.,'Next')]")));
        // Previous Button
        public IWebElement PreviousButton =>
            Wait.Until(e => e.FindElement(By.XPath("//a[@class='ss-right ui-link ui-btn ui-btn-a ui-icon-arrow-l ui-btn-icon-left ui-btn-inline ui-shadow ui-corner-all'][contains(.,'Previous')]")));

        // Complete Button
        public IWebElement CompleteButton =>
            Wait.Until(e => e.FindElement(By.XPath("//a[@class='ss-right ui-link ui-btn ui-btn-b ui-icon-check ui-btn-icon-right ui-btn-inline ui-shadow ui-corner-all'][contains(.,'Complete')]")));

        // Place Order Button
        public IWebElement PlaceOrderButton =>
            Wait.Until(e => e.FindElement(By.XPath("//a[@class='ss-right ui-link ui-btn ui-btn-b ui-icon-check ui-btn-icon-right ui-btn-inline ui-shadow ui-corner-all'][contains(.,'Place your Order')]")));

        // STEP 1
        // I am radio button (The registrant)
        public IWebElement Step1IAm =>
            Wait.Until(e => e.FindElement(By.XPath("//label[@class='ui-btn ui-corner-all ui-btn-a ui-btn-icon-left ui-radio-off ui-first-child']")));

        // STEP 2
        // Text on page
        public IWebElement Step2PageText => 
            Wait.Until(e => e.FindElement(By.XPath("//h1[contains(.,'Birth Record Information')]")));

        // Step 2 Required fields
        public IWebElement Step2FirstName =>
            Wait.Until(e => e.FindElement(By.Id("field_BirthFirstName")));

        public IWebElement Step2LastName =>
            Wait.Until(e => e.FindElement(By.Id("field_BirthLastName")));

        public IWebElement Step2DateOfBirth =>
            Wait.Until(e => e.FindElement(By.Id("field_DateofBirth")));

        public IWebElement Step2CityOfBirth =>
            Wait.Until(e => e.FindElement(By.Id("field_CityofBirth")));

        // STEP 3
        // Text on page
        public IWebElement Step3PageText =>
            Wait.Until(e => e.FindElement(By.XPath("//h1[contains(.,'Requestor Information')]")));

        // Step 3 Required fields
        public IWebElement Step3FullName =>
            Wait.Until(e => e.FindElement(By.Id("field_RequestorName")));

        public IWebElement Step3StreetAddress =>
            Wait.Until(e => e.FindElement(By.Id("field_RequestorReturn2_DOT_Address1")));

        public IWebElement Step3City=>
            Wait.Until(e => e.FindElement(By.Id("field_RequestorReturn2_DOT_City")));

        public IWebElement Step3State =>
            Wait.Until(e => e.FindElement(By.Id("field_RequestorReturn2_DOT_State")));

        public IWebElement Step3Zip =>
            Wait.Until(e => e.FindElement(By.Id("field_RequestorReturn2_DOT_Zip")));

        public IWebElement Step3Relationship =>
            Wait.Until(e => e.FindElement(By.Id("field_RelationshipToPerson")));

        public IWebElement Step3IdNumber =>
            Wait.Until(e => e.FindElement(By.Id("field_IDNumber")));

        public IWebElement Step3PhoneNumber =>
            Wait.Until(e => e.FindElement(By.Id("field_RequestorPhone")));

        public IWebElement Step3NumberOfCopies =>
            Wait.Until(e => e.FindElement(By.Id("field_NumberOfCopies")));

        // STEP 4
        // Text on page
        public IWebElement Step4PageText =>
            Wait.Until(e => e.FindElement(By.XPath("//h1[contains(.,'Review Request')]")));

        // Ceckout
        // Text on page
        public IWebElement CheckoutPageText =>
            Wait.Until(e => e.FindElement(By.XPath("//h1[contains(.,'Checkout')]")));

        public IWebElement PaymentMethod =>
            Wait.Until(e => e.FindElement(By.Id("field_PayMethod")));

        public IWebElement CustomerName =>
            Wait.Until(e => e.FindElement(By.Id("field_Name")));

        public IWebElement ConfirmationText =>
            Wait.Until(e => e.FindElement(By.XPath("//b[contains(.,'Thank you for your order.')]")));


         public void EnsurePageLoaded()
        {
            bool pageHasLoaded = (PageText.Text == birthCertificateTitle);

            if (!pageHasLoaded)
            {
                throw new Exception($"Failed to load page. Page Url = {Driver.Url.Substring(0, 55)} Page Source: \r\n  {Driver.PageSource}");
            }
        }

        public void SetRelationship(string type)
        {
            SelectElement idRelationType = new SelectElement(Step3Relationship);
            idRelationType.SelectByText(type);
            WebPageDelay.Pause();
        }

        public void SetPaymentMethod(string method)
        {
            SelectElement paymentMethodType = new SelectElement(PaymentMethod);
            paymentMethodType.SelectByText(method);
            WebPageDelay.Pause();
        }


    }
}
