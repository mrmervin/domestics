using System;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using qa01ww.com.drhi.support;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using qa01ww.com.drhi.utils;

namespace qa01ww.com.drhi.pageobjects
{
    public class ThirdPartyListPage
    {
        #region Page elements

        [FindsBy(How = How.Id, Using = "companyName")]
        private IWebElement companyName { get; set; }

        [FindsBy(How = How.Id, Using = "McsNumber")]
        private IWebElement mcsNumber { get; set; }

        [FindsBy(How = How.Id, Using = "installerName")]
        private IWebElement installerName { get; set; }

        [FindsBy(How = How.Id, Using = "comments")]
        private IWebElement comments { get; set; }

        [FindsBy(How = How.Id, Using = "submitBtn")]
        private IWebElement submitBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='thirdPartyHistoryTable']/tbody/tr[2]/td[1]")]
        private IWebElement auditStatus { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='thirdPartyHistoryTable']/tbody/tr[1]/td[1]")]
        private IWebElement legalStatus { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='thirdPartyListTable']/tbody/tr[1]/td[1]/a")]
        private IWebElement thirdPartyCompanyName { get; set; }

        [FindsBy(How = How.Id, Using = "auditStatusLink")]
        private IWebElement auditStatusLink { get; set; }

        [FindsBy(How = How.Id, Using = "ThirdPartyStatusEditPopup_StatusDropDown")]
        private IWebElement ThirdPartyStatusEditPopup_StatusDropDown { get; set; }

        [FindsBy(How = How.Id, Using = "ThirdPartyStatusEditPopup_Comments")]
        private IWebElement ThirdPartyStatusEditPopup_Comments { get; set; }

        [FindsBy(How = How.Id, Using = "legalStatusLink")]
        private IWebElement legalStatusLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='thirdPartyListTable']/tbody/tr[1]/td[1]/a")]
        private IWebElement actualCellValue { get; set; }

        [FindsBy(How = How.Id, Using = "ThirdPartyStatusEditPopup_SaveBtn")]
        private IWebElement ThirdPartyStatusEditPopup_SaveBtn { get; set; }

        [FindsBy(How = How.Id, Using = "thirdPartyHistoryTable")]
        private IWebElement thirdPartyHistoryTable { get; set; }

        [FindsBy(How = How.Id, Using = "thirdPartyList")]
        private IWebElement thirdPartyList { get; set; }

        #endregion

        

        public void assertHistoryTableUpdated()
        {
            AppDriver.Driver.Navigate().Refresh();
            Assert.True(thirdPartyHistoryTable.Text.Contains("The Audit status changed from Incomplete to Complete"));
            AppDriver.Driver.Navigate().Refresh();
            Assert.True(thirdPartyHistoryTable.Text.Contains("The Legal status changed from Incomplete to Complete"));
        }

        public void assertThirdPartyDetails()
        {
            if (Helpers.IsElementPresent(thirdPartyHistoryTable))
                Assert.True(Helpers.IsElementPresent(thirdPartyHistoryTable));
        }

        public void clickOnThirdParty()
        {
            thirdPartyCompanyName.Click();
        }

        public void editAuditStatus()
        {
            auditStatusLink.Click();
            var statusDropdown = new SelectElement(ThirdPartyStatusEditPopup_StatusDropDown);
            statusDropdown.SelectByValue("Complete");
            ThirdPartyStatusEditPopup_Comments.SendKeys("Add some comments");
            ThirdPartyStatusEditPopup_SaveBtn.Click();
        }

        public void editLegalStatus()
        {
            AppDriver.Driver.Navigate().Refresh();
            legalStatusLink.Click();
            var statusDropdown = new SelectElement(ThirdPartyStatusEditPopup_StatusDropDown);
            statusDropdown.SelectByValue("Complete");
            ThirdPartyStatusEditPopup_Comments.SendKeys("Add some comments");
            ThirdPartyStatusEditPopup_SaveBtn.Click();
        }

        public void addThirdpartyInList()
        {
            var expectedCompanyName = fill3rdPartyForm();
            Task.Delay(1000).Wait(); //waits for actualCellValue to be added
            Assert.True(expectedCompanyName.Contains(actualCellValue.Text));
        }

        private String fill3rdPartyForm()
        {
            string randomCompanyName = "Company Name " + Helpers.generateRandom(1, 100);
            companyName.SendKeys(randomCompanyName);
            mcsNumber.FindElement(By.Id("McsNumber")).SendKeys("MCS123456");
            installerName.SendKeys("Installer Name");
            comments.SendKeys("Add some comments");
            submitBtn.Click();
            return (randomCompanyName);
        }
    }
}


