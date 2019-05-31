using NUnit.Framework;
using qa01ww.com.drhi.support;
using TechTalk.SpecFlow;

namespace qa01ww.com.drhi.stepDefinitions
{
    [Binding]
    public class AorInRhitaSteps
    {
        [When(@"I click on RECC")]
        public void WhenIClickOnRECC()
        {
            Page.administrationPage.clickOnReccBtn();
        }

        [Then(@"I see the upload file section")]
        public void ThenISeeTheUploadFileSection()
        {
            Page.AorInternalPage.AssertUploadReccPage();
        }

        [Then(@"I am able to Upload a file ""(.*)"" into Rhita")]
        public void ThenIAmAbleToUploadAFileIntoRhita(string filepath)
        {
            Page.AorInternalPage.uploadReccFile(filepath);
        }

        [Then(@"the file should be uploaded successfully")]
        public void ThenTheFileShouldBeUploadedSuccessfully()
        {
            Page.AorInternalPage.AssertUploadReccPage();
        }

        [Then(@"I should be shown an error message for incorrect format")]
        public void ThenIShouldBeShownAnErrorMessage()
        {
            Page.AorInternalPage.assertUploadErrorIncorrectFormat();
        }

        [Then(@"I should be shown an error message for incorrect columns")]
        public void ThenIShouldBeShownAnErrorMessageForIncorrectTitle()
        {
            Page.AorInternalPage.assertUploadErrorIncorrectTitles();
        }

        [Then(@"I should be shown an error message for duplicate IDS")]
        public void ThenIShouldBeShownAnErrorMessageForDuplicateIDS()
        {
            Page.AorInternalPage.assertUploadErrorDuplicateIDs();
        }

        [When(@"I click on Contract Id")]
        public void WhenIClickOnContractId()
        {
            Page.administrationPage.clickOnContractId();
        }

        [When(@"I enter (.*) as  a valid Recc/Heis Id")]
        public void WhenIEnterAsAValidReccHeisId(string ReccNo)
        {
            Page.AorInternalPage.enterActiveReccId(ReccNo);
        }

        [When(@"I enter (.*) as a Contract Name")]
        public void WhenIEnterAsARandomContractName(string contractName)
        {
            Page.AorInternalPage.enterContractName(contractName);
        }

        [When(@"I click on generate Urir and Investor Id")]
        public void WhenIClickOnGenerateUrirAndInvestorId()
        {
           Page.AorInternalPage.clickUrirGeneratorButton();
        }

        [When(@"I click on Generate Contract Id")]
        public void WhenIClickOnGenerateContractId()
        {
            Page.AorInternalPage.clickOnGenerateContractId();
        }

        [Then(@"contract Id should be generated")]
        public void ThenContractIdShouldBeGenerated()
        {
            Page.AorInternalPage.assertContractIdGenerated();
        }

        [Then(@"I should see the ReccId does not exist error message")]
        public void ThenIShouldSeeTheReccIdDoesNotExistErrorMessage()
        {
            Page.AorInternalPage.ReccIdDoesNotExist();
        }

        [Then(@"I should see the contract already exists error")]
        public void ThenIShouldSeeTheContractAlreadyExistsError()
        {
            Page.AorInternalPage.contractAlreadyExists();
        }

        [When(@"I click URIR & Investor ID")]
        public void WhenIClickURIRInvestorID()
        {
            Page.AorInternalPage.clickOnUrirInvestorIdTab();
        }

        [Then(@"I should not see the Urir Investor Tab")]
        public void ThenIShouldNotSeeTheUrirInvestorTab()
        {
            Assert.False(Page.AorInternalPage.clickOnUrirInvestorIdTab());
        }

        [Then(@"Urir should be generated")]
        public void ThenUrirShouldBeGenerated()
        {
            Page.AorInternalPage.assertUrirGenerated();
        }

        [Then(@"I should see a validation error (.*)")]
        public void ThenIShouldSeeAValidationError(string error)
        {
           Page.AorInternalPage.UrirGeneratedError(error);
        }

        [When(@"I click the Inv bank details")]
        public void WhenIClickTheInvBankDetails()
        {
            Page.administrationPage.clickOnInvBankDetails();
        }


        [Then(@"I should see the Investor form")]
        public void ThenIShouldSeeTheInvestorForm()
        {
            Page.AorInternalPage.assertInvestorFormDisplayed();
        }

        [When(@"I click on the dropdown InvestorID")]
        public void WhenIClickOnTheDropdownInvestorID()
        {
            Page.AorInternalPage.clickOnInvestorIdDrpdwn();
        }

        [Then(@"I should see a list of Investors")]
        public void ThenIShouldSeeAListOfInvestors()
        {
           Page.AorInternalPage.assertInvestorIdsPresent();
        }

        [When(@"I complete the Investor form")]
        public void WhenICompleteTheInvestorForm()
        {
           Page.AorInternalPage.completeInvestorForm();
        }

        [When(@"I click on Update Investor bank details")]
        public void WhenIClickOnUpdateInvestorBankDetails()
        {
            Page.AorInternalPage.clickOnUpdateInvestorBankDetailsBtn();
        }

        [Then(@"the Investor Bank details should be added successfully")]
        public void ThenTheInvestorBankDetailsShouldBeAddedSuccessfully()
        {
            Page.AorInternalPage.assertBankdetailsAddedText();
        }
    }
}


