using NUnit.Framework;
using qa01ww.com.drhi.support;
using TechTalk.SpecFlow;

namespace qa01ww.com.drhi.stepDefinitions
{
    [Binding]
    public class MeteringForPerformanceSteps
    {
        [Then(@"the Metering for performace section is displayed")]
        public void ThenTheMeteringForPerformaceSectionIsDisplayed()
        {
           Assert.True(
            Page.ApplicationFormSecondPage.meteringForPerformanceDisplayed());
            
        }

        //[When(@"I complete the second page of application")]
        //public void ThenICompleteTheSecondPageOfApplication()
        //{
        //    Page.landingPage.editSecondPageOfApplication();
        //}

        [Then(@"I should see metering for performance mismatch on review message")]
        public void ThenIShouldMeteringForPerformanceMismatchOnReviewMessage()
        {
            Page.customerPage.assertReviewmessage("Metering for performance mismatch");
        }

        [Then(@"the Metering for performace section is not displayed")]
        public void ThenTheMeteringForPerformaceSectionIsNotDisplayed()
        {
          Assert.False(Page.ApplicationFormSecondPage.meteringForPerformanceDisplayed());
        }

        [Then(@"the effective date is updated in the DB")]
        public void ThenTheEffectiveDateIsUpdatedInTheDB()
        {
            SqlQueries.updateToSavedRequlationDate();
        }

        [Given(@"I am after the effective date")]
        public void GivenIAmAfterTheEffectiveDate()
        {
            SqlQueries.getRegulationDateAndSetItToToday();
        }
    }
}
