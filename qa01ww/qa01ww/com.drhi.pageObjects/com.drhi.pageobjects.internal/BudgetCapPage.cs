using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using qa01ww.com.drhi.support;
using qa01ww.com.drhi.utils;

namespace qa01ww.com.drhi.pageObjects.com.drhi.pageobjects
{
    public class BudgetCapPage
    {
        #region Page Elements

        [FindsBy(How = How.XPath, Using = "//*[@id='budgetCapTable']/tbody/tr/td[6]/a")]
        private IWebElement removeBtn { get; set; }

        [FindsBy(How = How.Id, Using = "budgetcap_manualReviewDate")]
        private IWebElement budgetcap_manualReviewDate { get; set; }

        [FindsBy(How = How.Id, Using = "budgetcap_softClosureDate")]
        private IWebElement budgetcap_softClosureDate { get; set; }

        [FindsBy(How = How.Id, Using = "budgetcap_hardClosureDate")]
        private IWebElement budgetcap_hardClosureDate { get; set; }

        [FindsBy(How = How.TagName, Using = "body")]
        private IWebElement changeFocus { get; set; }

        [FindsBy(How = How.Id, Using = "submitBudgetCapDates")]
        private IWebElement submitBudgetCapDates { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='budgetCapTable']/tbody/tr/td[1]")]
        private IWebElement manualReviewDateInTable { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='budgetCapTable']/tbody/tr/td[2]")]
        private IWebElement softClosureDateInTable { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='budgetCapTable']/tbody/tr/td[3]")]
        private IWebElement hardClosureDateInTable { get; set; }

        #endregion

        private string manualReviewDate = DateTime.Now.AddDays(0).ToString("dd/MM/yyyy");
        private string softClosureDate = DateTime.Now.AddDays(0).ToString("dd/MM/yyyy");
        private string hardClosureDate = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy");
        private string newManualReviewDate = DateTime.Now.AddDays(0).ToString("dd/MM/yyyy");
        private string newSoftClosureDate = DateTime.Now.AddDays(0).ToString("dd/MM/yyyy");
        private string newHardClosureDate = DateTime.Now.AddDays(0).ToString("dd/MM/yyyy");

        public void createBudgetCapDates()
        {
            createBudgetCapDates(manualReviewDate, softClosureDate, hardClosureDate);
        }

        public void updateBudgetCapDates()
        {
            createBudgetCapDates(newManualReviewDate, newSoftClosureDate, newHardClosureDate);
        }

        public void removeDates()
        {
            if (Helpers.IsElementPresent(removeBtn))
            {
                removeBtn.Click();
            }
        }

        public void assertSecondDateInTable()
        {
            AppDriver.Driver.Navigate().Refresh();
            assertDatesInTable(newManualReviewDate, newSoftClosureDate, newHardClosureDate);
        }

        public void assertFirstDatesInTable()
        {
            AppDriver.Driver.Navigate().Refresh();
            assertDatesInTable(manualReviewDate, softClosureDate, hardClosureDate);
        }

        public void assertDatesRemoved()
        {
            AppDriver.Driver.Navigate().Refresh();
            Assert.False(Helpers.IsElementDisplayedandEnabled(removeBtn));
        }

        private void createBudgetCapDates(string manualReviewDate, string softClosureDate, string hardClosureDate)
        {
            budgetcap_manualReviewDate.SendKeys(manualReviewDate);
            budgetcap_softClosureDate.SendKeys(DateTime.Today.ToString(softClosureDate));
            budgetcap_hardClosureDate.SendKeys(hardClosureDate);
            //change focus
            changeFocus.Click();
            submitBudgetCapDates.Click();
            AppDriver.Driver.Navigate().Refresh();
        }

        private void assertDatesInTable(string manualReviewDate, string softClosureDate, string hardClosureDate)
        {
            Assert.That(manualReviewDateInTable.Text,
                Is.EqualTo(manualReviewDate));
            Assert.That(softClosureDateInTable.Text,
                Is.EqualTo(softClosureDate));
            Assert.That(hardClosureDateInTable.Text,
                Is.EqualTo(hardClosureDate));
        }
    }
}