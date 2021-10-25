using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowProject1.Pages
{
    public class LoginPage
    {
        public IWebDriver webDriver { get; }
        public LoginPage(IWebDriver Driver)
        {
            webDriver = Driver;
        }

        public IWebElement contactBtn => webDriver.FindElement(By.Id("contact-link"));
        public IWebElement headingContactPage => webDriver.FindElement(By.XPath("//*[@id='center_column']/h1"));

        public void clickContact() => contactBtn.Click();

        public void assertHeading()
        {
            Assert.That(headingContactPage.Text.Equals("CUSTOMER SERVICE - CONTACT US"), Is.True);
            
            //headingContactPage.Text.Equals("CUSTOMER SERVICE - CONTACT US");

           }

    }
}
