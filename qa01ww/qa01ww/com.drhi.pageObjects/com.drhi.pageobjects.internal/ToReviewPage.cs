using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using qa01ww.com.drhi.support;
using qa01ww.com.drhi.utils;

namespace qa01ww.com.drhi.pageObjects.com.drhi.pageobjects
{
    public class ToReviewPage
    {
        [FindsBy(How = How.XPath, Using = "//*[starts-with(@id,'ownership_')]")]
        private IWebElement AssignDROownership { get; set; }

        [FindsBy(How = How.Id, Using = "droDropDown")]
        private IWebElement droDropDown { get; set; }

        [FindsBy(How = How.Id, Using = "assignDroOwnerPopup_Save")]
        private IWebElement assignDroOwnerPopup_Save { get; set; }

        public void clickOnAssignedApplication()
        {
            Helpers.explicitWait(AppDriver.Driver, "ApplicationsUnderReview");
            AssignDROownership.Click();
        }

        public void assignToDRO()
        {
            var dROdropdown = new SelectElement(droDropDown);
            dROdropdown.SelectByIndex(2);
            assignDroOwnerPopup_Save.Click();
        }
    }
}

