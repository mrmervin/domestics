using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using qa01ww.com.drhi.support;
using qa01ww.com.drhi.utils;

namespace qa01ww.com.drhi.pageObjects.com.drhi.pageobjects
{
    public class BulkDeclarationPage
    {
        [FindsBy(How = How.Id, Using = "Applications_selectAllBtn")]
        private IWebElement applications_selectAllBtn { get; set; }

        [FindsBy(How = How.Id, Using = "Applications_SubmitBtn")]
        private IWebElement applications_SubmitBtn { get; set; }

        [FindsBy(How = How.Id, Using = "interactionsTab")]
        private IWebElement interactionsTab { get; set; }

        [FindsBy(How = How.Id, Using = "EditInteraction")]
        private IWebElement editInteraction { get; set; }

        public void selectApplications()
        {
            Helpers.explicitWait(AppDriver.Driver, "Applications_selectAllBtn");
            applications_selectAllBtn.Click();
        }

        public void signDeclarationBtn()
        {
            applications_SubmitBtn.Click();
        }

        public void assertInteraction()
        {
            interactionsTab.Click();
            Helpers.explicitWait(AppDriver.Driver, "EditInteraction");
            var sActualValue = editInteraction.Text;
            Assert.True(sActualValue.Contains("Annual declaration"));
        }

        public void assertRfiCreated()
        {
            interactionsTab.Click();
            Helpers.explicitWait(AppDriver.Driver, "EditInteraction");
            var sActualValue = editInteraction.Text;
            Assert.True(sActualValue.Contains("RFI"));
        }
    }
}