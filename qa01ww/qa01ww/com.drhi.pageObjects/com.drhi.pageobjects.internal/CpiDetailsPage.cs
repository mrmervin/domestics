using System;
using System.ComponentModel;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using qa01ww.com.drhi.support;
using qa01ww.com.drhi.utils;

namespace qa01ww.com.drhi.pageObjects
{
    public class CpiDetailsPage
    {
        #region Page Elements

        [FindsBy(How = How.Id, Using = "CpiChange_1")]
        private IWebElement CpiChange { get; set; }

        [FindsBy(How = How.Id, Using = "CpiPercentage")]
        private IWebElement CpiPercentage { get; set; }

        [FindsBy(How = How.Id, Using = "SubmitCpi")]
        private IWebElement SubmitCpi { get; set; }

        [FindsBy(How = How.Id, Using = "CpiUpdateSection_confirmPopup")]
        private IWebElement cpiUpdateSection_confirmPopup { get; set; }

        [FindsBy(How = How.Id, Using = "cpiUpdateHistoryTable")]
        private IWebElement cpiUpdateHistoryTable { get; set; }

        [FindsBy(How = How.Id, Using = "CpiUpdateSection_SaveConfirmationButton")]
        private IWebElement CpiUpdateSection_SaveConfirmationButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='cpiUpdateHistoryTable']/tbody/tr/td[3]")]
        private IWebElement actualCellValue { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='cpiUpdateHistoryTable']/tbody/tr[1]/td[5]")]
        private IWebElement actualStatusValue { get; set; }

        #endregion

        string cpiRate = "6.00";
        public void completeForm()
        {
            AppDriver.Driver.Navigate().Refresh();
            CpiChange.SendKeys(Keys.Space);
            CpiPercentage.SendKeys(cpiRate);
            SubmitCpi.Click();
        }

        public void assertCpiConfirmPopup()
        {
            Assert.IsTrue(Helpers.IsElementPresent(cpiUpdateSection_confirmPopup));
            if (Helpers.IsElementPresent(cpiUpdateSection_confirmPopup))
            {
                CpiUpdateSection_SaveConfirmationButton.Click();
            }
        }

        public void assertCpiInList()
        {
            AppDriver.Driver.Navigate().Refresh();
            if (Helpers.IsElementPresent(cpiUpdateHistoryTable))
            {
                AppDriver.Driver.Navigate().Refresh();
                String sActualCellValue = actualCellValue.Text;

                Assert.AreEqual(cpiRate + "%", sActualCellValue, "Expected string does not match ");
            }
        }

        public void assertStatusPending()
        {
            var sActualStatusValue = actualStatusValue.Text;
            Assert.AreEqual("Pending", sActualStatusValue);
        }
    }
}
