using qa01ww.com.drhi.support;
using System;
using System.Threading;
using qa01ww.com.drhi.pageObjects;
using TechTalk.SpecFlow;

namespace qa01ww
{
    [Binding]
    public class ApplyingThroughAnInvestorSteps
    {

       
        [When(@"I apply as an Investor with (.*) as URIR")]
        public void WhenIApplyAsAnInvestorWuthAsURIR(string URIR)
        {
           // Page.landingPage.applyingThroughAnInvestorQuestion_True ();
            Page.ApplicationFormFirstPage.getWithInvestor(URIR);
        }

        [When(@"I answer NO for own money used")]
        public void WhenIAnswerNOForOwnMoneyUsed()
        {
            Page.ApplicationFormFirstPage.ownMoneyUsedQuestion_False();
        }


        [Then(@"I should get an error message")]
        public void ThenIShouldGetAnErrorMessage()
        {
            Page.ApplicationFormFirstPage.assertUrirFormatValidationMessage();
        }

        [Then(@"applicant should not be rejected")]
        public void ThenApplicantShouldNotBeRejected()
        {
            Page.ApplicationSubmittedPage.assertFalseRejectionPage();
        }

        [When(@"I click Yes to metering and monitoring")]
        public void WhenIClickYesToMeteringAndMonitoring()
        {
            Page.ApplicationFormSecondPage.meteringAndMonitoring_Yes();
            }

        [Then(@"Bank details section should be visible")]
        public void ThenBankDetailsSectionShouldBeVisible()
        {
            Page.investorPage.assertBankdetailssectionIsVisible();
        }

        [Then(@"If I click No to metering and monitoring")]
        public void ThenIfIClickNoToMeteringAndMonitoring()
        {
            Thread.Sleep(2000);
            Page.ApplicationFormSecondPage.meteringAndMonitoring_Section();
        }

        [Then(@"Bank details section should not be visible")]
        public void ThenBankDetailsSectionShouldNotBeVisible()
        {
            Page.investorPage.assertBankdetailssectionIsNotVisible();
        }

        [When(@"the product is eligible for MMSP")]
        public void WhenTheProductIsEligibleForMMSP()
        {
            SqlQueries.updateIsMMSPeligible_True();
        }
     
        [Then(@"the Bank details button should be disabled")]
        public void ThenTheBankDetailsButtonShouldBeDisabled()
        {
            Page.customerPage.assertBankdetailsbuttonNotPresent();
        }

        [When(@"I register for mmsp")]
        public void WhenIRegisterForMmsp()
        {
         Page.customerPage.assertMMSP();
         Page.customerPage.completeMMSPquestion();
        }

        [Then(@"bank details button should be enabled")]
        public void ThenBankDetailsButtonShouldBeEnabled()
        {
            Page.customerPage.assertupdateBankdetailsbuttonPresent();
        }

        [Then(@"I should see new message to enter bank details")]
        public void ThenIShouldSeeNewMessageToEnterBankDetails()
        {
            Page.customerPage.assertchangeBankdetailsbuttonNonAorPresent();
            Page.customerPage.assertBankdetailsMsg();
        }

    }
}
