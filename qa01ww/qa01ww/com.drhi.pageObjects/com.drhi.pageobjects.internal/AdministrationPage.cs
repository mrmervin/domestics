using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace qa01ww.com.drhi.pageobjects
{
    public class AdministrationPage
    {
        #region Page Elements

        [FindsBy(How = How.Id, Using = "ThirdPartyTabLink")]
        private IWebElement thirdPartyTabLink { get; set; }

        [FindsBy(How = How.Id, Using = "RpiCpiTabLink")]
        private IWebElement rpiCpiTabLink { get; set; }

        [FindsBy(How = How.Id, Using = "searchText")]
        private IWebElement searchText { get; set; }

        [FindsBy(How = How.Id, Using = "BulkSignTabLink")]
        private IWebElement bulkSignTabLink { get; set; }

        [FindsBy(How = How.Id, Using = "search")]
        private IWebElement search { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='SearchResults']/tbody/tr[1]/td[1]/a")]
        private IWebElement searchBox { get; set; }

        [FindsBy(How = How.Id, Using = "BudgetCapLink")]
        private IWebElement BudgetCapLink { get; set; }

        [FindsBy(How = How.Id, Using = "ReccTabLink")]
        private IWebElement ReccTab { get; set; }

        [FindsBy(How = How.Id, Using = "ModelContractIdGeneratorTabLink")]
        private IWebElement ContractIdTab { get; set; }

        [FindsBy(How = How.Id, Using = "InvBankDetailsTabLink")]
        private IWebElement InvBankDetailsTabLink { get; set; }

        #endregion

        public void clickOn3rdPartyList()
        {
            thirdPartyTabLink.Click();
        }

        public void clickOnCpi()
        {
            rpiCpiTabLink.Click();
        }

        public void clickOnBulkDeclaration()
        {
            bulkSignTabLink.Click();
        }

        public void searchApplication(string resultValue)
        {
            searchText.SendKeys(resultValue);
            search.Click();
            searchBox.Click();
        }

        public void clickOnBudgetCap()
        {
            BudgetCapLink.Click();
        }

        public void clickOnReccBtn()
        {
            ReccTab.Click();
        }

        public void clickOnContractId()
        {
            ContractIdTab.Click();
        }

        internal void clickOnInvBankDetails()
        {
            InvBankDetailsTabLink.Click();
        }
    }
}

