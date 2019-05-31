using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using qa01ww.com.drhi.support;
using System.Threading;

namespace qa01ww.com.drhi.pageObjects.com.drhi.pageobjects.external
{
    public class InvestorPage
    {

        public void assertBankdetailssectionIsVisible()
        {
            Assert.True(Helpers.IsElementDisplayedandEnabled(
                bankDetailsSection));
        }
        public void assertBankdetailssectionIsNotVisible()
        {
            Assert.False(Helpers.IsElementDisplayedandEnabled(bankDetailsSection));
        }

        [FindsBy(How = How.Id, Using = "bankDetailsSection")]
        private IWebElement bankDetailsSection { get; set; }

    }
}
