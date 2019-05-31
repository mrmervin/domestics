using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using qa01ww.com.drhi.support;
using qa01ww.com.drhi.utils;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace qa01ww.com.drhi.pageObjects.com.drhi.pageobjects
{
    public class AorInternalPage
    {
        [FindsBy(How = How.Id, Using = ("UploadRECCSection"))]
        private IWebElement UploadRECCSection { get; set; }

        [FindsBy(How = How.ClassName, Using = ("browseButton"))]
        private IWebElement reccFileInput { get; set; }

        [FindsBy(How = How.Id, Using = ("ReccComments"))]
        private IWebElement ReccComments { get; set; }

        [FindsBy(How = How.Id, Using = ("UploadReccBtn"))]
        private IWebElement UploadReccBtn { get; set; }

        [FindsBy(How = How.ClassName, Using = ("successHeader"))]
        private IWebElement successHeader { get; set; }

        [FindsBy(How = How.XPath, Using = ("//*[@id='UploadRECCSection']/div[5]/div/table/tbody/tr/td[3]"))]
        private IWebElement errorHeader { get; set; }

        [FindsBy(How = How.Id, Using = ("ReccOrHiesNo"))]
        private IWebElement ReccHiesNo { get; set; }

        [FindsBy(How = How.Id, Using = ("ModelContractName"))]
        private IWebElement ModelContractName { get; set; }

        [FindsBy(How = How.Id, Using = ("GenerateContractIdButton"))]
        private IWebElement GenerateContractIdButton { get; set; }

        [FindsBy(How = How.Id, Using = ("ModelContractIdGeneratorResult"))]
        private IWebElement ModelContractIdGeneratorResult { get; set; }

        [FindsBy(How = How.Id, Using = ("UrirGeneratorTabLink"))]
        private IWebElement UrirGeneratorTabLink { get; set; }

        [FindsBy(How = How.Id, Using = ("UrirGeneratorButton"))]
        private IWebElement UrirGeneratorButton { get; set; }

        [FindsBy(How = How.Id, Using = ("UrirGeneratorResult"))]
        private IWebElement UrirGeneratorResult { get; set; }

        [FindsBy(How = How.Id, Using = ("InvBankDetails"))]
        private IWebElement InvBankDetails { get; set; }

        [FindsBy(How = How.Id, Using = ("InvestorId"))]
        private IWebElement InvestorId { get; set; }

        [FindsBy(How = How.Id, Using = ("BankAccountName"))]
        private IWebElement BankAccountName { get; set; }

        [FindsBy(How = How.Id, Using = ("AccountNumber"))]
        private IWebElement AccountNumber { get; set; }

        [FindsBy(How = How.Id, Using = ("SortCode"))]
        private IWebElement SortCode { get; set; }

        [FindsBy(How = How.Id, Using = ("VerifyBankDetailsAreCorrect"))]
        private IWebElement VerifyBankDetailsAreCorrect { get; set; }

        [FindsBy(How = How.Id, Using = ("BankName"))]
        private IWebElement BankName { get; set; }

        [FindsBy(How = How.Id, Using = ("SaveInvBankDetailsButton"))]
        private IWebElement SaveInvBankDetailsButton { get; set; }

        [FindsBy(How = How.Id, Using = ("InvestorMessageGreen"))]
        private IWebElement InvestorMessageGreen { get; set; }

        [FindsBy(How = How.Id, Using = ("InvestorMessageRed"))]
        private IWebElement InvestorMessageRed { get; set; }


        public void AssertUploadReccPage()
        {
            if (Helpers.IsElementDisplayedandEnabled(UploadRECCSection))
            {
                Assert.True(UploadRECCSection.Text.Contains("Upload RECC file"));
            }
        }

        public void uploadReccFile(string filePath)
        {
            Helpers.explicitWait(AppDriver.Driver, "reccFileInput");
            reccFileInput.SendKeys(filePath);
            ReccComments.SendKeys("add some comments");
            UploadReccBtn.Click();
        }

        public void assertUploadSuccesfull()
        {
            Helpers.IsElementDisplayedandEnabled(successHeader);
            Thread.Sleep(2000); //remove later
            Assert.True(successHeader.Text.Equals("Success!"));
        }

        public void enterActiveReccId(string reccNo)
        {
            ReccHiesNo.SendKeys(reccNo);
        }

        public void assertUploadErrorIncorrectFormat()
        {
            Thread.Sleep(2000); //remove later
            Assert.True(errorHeader.Text.Equals(
                "The document is not in the correct format. RECC file must be of excel format (*.xlsx, *.xls)"));
        }

        public void assertUploadErrorIncorrectTitles()
        {
            Thread.Sleep(2000); //remove later
            Assert.True(errorHeader.Text.Equals("Incorrect column titles"));
        }

        public void assertUploadErrorDuplicateIDs()
        {
            Thread.Sleep(2000); //remove later
            Assert.True(errorHeader.Text.Equals("RECC register has duplicate RECC IDs"));
        }

        public void enterContractName(string contractName)
        {
            ModelContractName.SendKeys(contractName);
        }

        public void clickOnGenerateContractId()
        {
            GenerateContractIdButton.Click();
        }

        public void assertContractIdGenerated()
        {
            var text = ModelContractIdGeneratorResult.Text;
            Assert.True(text.Contains("Contract Id"));
        }

        public void ReccIdDoesNotExist()
        {
            Thread.Sleep(2000); //remove later
            Assert.True(errorHeader.Text.Equals("RECC/HIES Id provided does not exist, please provide a valid Id"));
        }



        public void contractAlreadyExists()
        {
            Thread.Sleep(2000); //remove later
            Assert.True(errorHeader.Text.Equals("Contract already exists"));
        }

        public bool clickOnUrirInvestorIdTab()
        {
            if (Helpers.IsElementDisplayedandEnabled(UrirGeneratorTabLink))
            {
                UrirGeneratorTabLink.Click();
                return true;
            }

            return false;
        }

        public void clickUrirGeneratorButton()
        {
            UrirGeneratorButton.Click();
        }

        public void assertUrirGenerated()
        {
            if (Helpers.IsElementDisplayedandEnabled(UrirGeneratorResult))
            {
                Assert.True(UrirGeneratorResult.Displayed);
            }
        }

        public void UrirGeneratedError(string error)
        {
            if (Helpers.IsElementDisplayedandEnabled(UrirGeneratorResult))
            {
                Assert.True(UrirGeneratorResult.Text.Contains(error));
            }
        }

        internal void assertInvestorFormDisplayed()
        {
            Assert.True(Helpers.IsElementPresent(InvBankDetails), "Investor form not displayed");
        }

        internal void clickOnInvestorIdDrpdwn()
        {
            InvestorId.clickOnIt();
            SelectElement Investordrpdwn = new SelectElement(InvestorId);
            Investordrpdwn.SelectByIndex(2);
        }

        internal void assertInvestorIdsPresent()
        {
            SelectElement Investordrpdwn = new SelectElement(InvestorId);
            IList<IWebElement> allOptions = Investordrpdwn.Options;
            var InvestorIdText = InvestorId.Text;
            if (allOptions.FirstOrDefault().Text.StartsWith("NA"))
            {

                Assert.True(InvestorIdText.StartsWith("NA"));
                Investordrpdwn.SelectByIndex(2);
            }
        }

        internal void completeInvestorForm()
        {
            SelectElement BankNamedrpdn = new SelectElement(BankName);
            BankNamedrpdn.SelectByIndex(2);
            BankAccountName.SendKeys("TestBankAccountName");
            AccountNumber.SendKeys("12345678");
            SortCode.SendKeys("123456");
            VerifyBankDetailsAreCorrect.SendKeys(Keys.Space);
        }

        internal void clickOnUpdateInvestorBankDetailsBtn()
        {
            SaveInvBankDetailsButton.clickOnIt();

        }

        public void assertBankdetailsAddedText()
        {
           
         //     Assert.That(InvestorMessageGreen.Text.Contains("Investor bank details saved"));
                Assert.That(InvestorMessageRed.Text.Contains("Investor bank details already updated"));
         }
    }
}

