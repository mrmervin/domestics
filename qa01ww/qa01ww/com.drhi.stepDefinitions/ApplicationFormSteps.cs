using System;
using System.Security.Cryptography.X509Certificates;
using NUnit.Framework;
using TechTalk.SpecFlow;
using qa01ww.com.drhi.support;

namespace qa01ww.com.drhi.stepDefinitions
{
    [Binding]
    public class ApplicationFormSteps
    {
        [When(@"I click Sign-In button on Homepage")]
        public void WhenIClickSignIn()
        {
            Page.ApplicationFormFirstPage.clickBtnSignIn();
        }

        [When(@"I enter (.*) for a given technology")]
        public void WhenIEnterAM(string McsLetter)
        {
            Page.ApplicationFormFirstPage.McsNumber(McsLetter);
        }

        [When(@"I select No for Additional funding")]
        public void NoForadditionalfunding()
        {
            Page.ApplicationFormFirstPage.AdditionalFundingNo();
        }

        [When(@"I enter EPC number")]
        public void WhenIEnterEPC()
        {
            Page.ApplicationFormFirstPage.enterEPCNumber();
        }


        [When(@"I create a deemed application")]
        public void meteredForPayment_False()
        {
            Page.ApplicationFormFirstPage.meteredForPayment_False();
        }

        [When(@"I create a metered application")]
        public void meteredForPayment_True()
        {
            Page.ApplicationFormFirstPage.meteredForPayment_True();
        }

        [Given(@"I click on assisted application button")]
        public void WhenIClickOnAssistedApplicationButton()
        {
            Page.headerSection.clickOnAssistedApplicationBtn();
        }

        [When (@"I select system provides heat for hot water")]
        public void WhenISelectSystemProvidesheatHotwater()
        {
            Page.ApplicationFormFirstPage.DeclaredSystemCheckBoxesHotWater();
        }

        [When(@"I answer Yes for own money used")]
        public void WhenIAnswerYesForOwnMoneyUsed()
        {
         Page.ApplicationFormFirstPage.UsedOwnMoneyTrue();
        }

        [When(@"I select The property as England")]
        public void WhenISelectThePropertyAsEngland()
        {
           Page.ApplicationFormFirstPage.selectPropertyCountryEngland();
        }

        [When(@"I select what buildings are heated by the heating system")]
        public void BuildingHeatedBySystem()
        {
            Page.ApplicationFormFirstPage.PropertiesHeatingSystemSingle();
        }

        [When(@"I select Yes if anyone live in the property before commisioning date")]
        public void heatingSystemInstalled()
        {
            Page.ApplicationFormFirstPage.HeatingSystemInstalled();
        }

        [When(@"I select property as Scotland")]
        public void WhenISelectThePropertyAsScotland()
        {
            Page.ApplicationFormFirstPage.selectPropertyCountryScotland();
        }

        [When(@"I select NO for multiple MCS")]
        public void multipleMCSFalse()
        {
            Page.ApplicationFormFirstPage.MultipleMcsFalse();
        }


        [When(@"I complete the second page of the application form")]
        public void completeSecondPageOfForm()
        {
            Page.ApplicationFormSecondPage.personalDetails();
            Page.ApplicationFormSecondPage.enterPassword();
            Page.ApplicationFormSecondPage.addressDetails();
            Page.ApplicationFormSecondPage.epcRecommendations();
            Page.ApplicationFormSecondPage.meteringForPayment();
            Page.ApplicationFormSecondPage.meteringForPerformanceFalse();
            Page.ApplicationFormSecondPage.meteringAndMonitoring_Section();
            Page.ApplicationFormSecondPage.surveyQuestions();
            Page.ApplicationFormSecondPage.bankAccountDetails();
            Page.ApplicationFormSecondPage.declaration();

        }

        [Given(@"I am an individual")]
        public void Individual()
        {
            Page.ApplicationFormFirstPage.ApplicantCategoryIndividual();
        }

        [Given(@"I am a heating system sole owner")]
        public void HeatingSystemSoleOwner ()
        {
            Page.ApplicationFormFirstPage.HeatingSystemSoleOwner();
        }

        [Given(@"I am an owner occupier")]
        public void ownerOccupier()
        {
            Page.ApplicationFormFirstPage.ApplicantTypeOwnerOccupier();
        }

        [When(@"I click on Start application")]
        public void WhenIClickOnStartApplication()
        {
            Page.ApplicationFormFirstPage.clickStartBtnOnFirstPage();
        }

        [When(@"I click submit")]
        public void WhenIClickSubmit()
        {
            Page.ApplicationFormSecondPage.submitForm();
        }

        [Then(@"application should be Auto-accredited")]
        public void ThenApplicationShouldBeAuto_Accredited()
        {
            Page.ApplicationSubmittedPage.assertTrueCongratulationsPage();
        }

        [Then(@"application should not be Auto accredited")]
        public void ThenApplicationShouldNotBeAutoAccredited()
        {
            Page.ApplicationSubmittedPage.assertFalseCongratulationsPage();
        }

        [Given(@"I am not with an Investor")]
        [When(@"I am not with an Investor")]
        public void WhenIAmNotWithAnInvestor()
        {
            Page.ApplicationFormFirstPage.withoutInvestor(); 
        }

        [Then(@"application should be rejected for No IMQ's")]
        public void ThenApplicationShouldBeRejectedForNoIMQS()
        {
            Page.ApplicationSubmittedPage.assertRejectionMessageNoIMQS();
        }

        [Then(@"application  should be rejected for No Epc")]
        public void ThenApplicationShouldBeRejectedForNoEpc()
        {
            Page.ApplicationSubmittedPage.assertRejectionMessageNoEpc();
        }
    
        [Then(@"application  In-Review message should be displayed")]
        public void ThenApplicationSuccessfullAndInReviewMessageShouldBeDisplayed()
        {
            Page.ApplicationSubmittedPage.assertInreviewPage();
        }
        
        [When(@"I apply as an organisation")]
        public void WhenIApplyAsAnOrganisation()
        {
           Page.ApplicationFormFirstPage.ApplicantCategoryOrganisation();
           Page.ApplicationFormFirstPage.ApplicantType_LocalAuthority();
           Page.ApplicationFormFirstPage.PropertyOwnership_OwnOccupy();
   
        }

        [When(@"I answer NO for IMQs")]
        public void WhenIAnswerNOForIMQs()
        {
            Page.ApplicationFormSecondPage.clickNoForIMQS();
        }

        [When(@"I select No for  Epc recommendation")]
        public void WhenISelectNoForEpcRecommendation()
        {
            Page.ApplicationFormSecondPage.clickNoForEpc();
        }

        [Then(@"new Epc question should not be present")]
        public void ThenNewEpcQuestionShouldNotBePresent()
        {
          Assert.False(Page.ApplicationFormSecondPage.clickNoForEpc());
        }

        #region Additonal application

        [When(@"I create a deemed ""(.*)"" additional application")]
        public void WhenICreateADeemedAAdditionalApplication(string technology)
        {
            Page.customerPage.clickOnAdditionalApplication();
            Page.additionalApplicationPage.enterMcsLetter(technology);
            Page.additionalApplicationPage.createDeemedAdditionalApplication();
            Page.additionalApplicationPage.completeFirstPageAdditionalApplication();
            Page.additionalApplicationPage.completeSecondPageOfadditionalApplication();
        }

        [When(@"I create a metered ""(.*)"" additional application")]
        public void WhenICreateAMeteredAdditionalApplication(string technology)
        {
            Page.customerPage.clickOnAdditionalApplication();
            Page.additionalApplicationPage.enterMcsLetter(technology);
            Page.additionalApplicationPage.createMeteredAdditionalApplication();
            Page.additionalApplicationPage.completeFirstPageAdditionalApplication();
            Page.additionalApplicationPage.completeSecondPageOfadditionalApplication();
        }

        [When(@"I click submit additional application")]
        public void WhenIClickSubmitAdditionalApplication()
        {
            Page.additionalApplicationPage.submitAdditionalApplication();
        }
    }
    #endregion

}
