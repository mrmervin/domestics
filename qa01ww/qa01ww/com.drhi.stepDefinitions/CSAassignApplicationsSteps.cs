using qa01ww.com.drhi.support;
using TechTalk.SpecFlow;

namespace qa01ww.com.drhi.stepDefinitions
{
    [Binding]
    public class CSAassignApplicationsSteps
    {
        [Then(@"I should be able to assign applications to a CSA")]
        public void ThenIShouldBeAbleToAssignApplicationsToACSA()
        {
            Page.toReviewPage.assignToDRO();
        }

        [Then(@"I can click on assign application")]
        public void ThenICanClickOnAssignApplication()
        {
          Page.toReviewPage.clickOnAssignedApplication();
        }
        
        [When(@"I click on To review tab")]
        public void WhenIClickOnToReviewTab()
        {
            Page.headerSection.clickOnToReviewTab();
        }
    }
}
