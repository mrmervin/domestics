using qa01ww.com.drhi.support;
using TechTalk.SpecFlow;

namespace qa01ww.com.drhi.stepDefinitions
{
    [Binding]
    public class Add3rdPartyListOfInstallersSteps
    {
        [When(@"I navigate to administration page in RHITA")]
        public void GivenINavigateToAdministrationPageInRHITA()
        {
           Page.headerSection.clickOnAdministrationBtn();
        }

        [Then(@"the history table should be updated")]
        public void ThenTheHistorytableShouldBeUpdated()
        {
            Page.thirdpartyListPage.assertHistoryTableUpdated();
            SqlQueries.deleteThirdPartyList();
        }

        [When(@"I click on a third party installer")]
        public void WhenIClickOnAThirdPartyInstaller()
        {
            Page.thirdpartyListPage.clickOnThirdParty();
        }

        [Then(@"I should see a third party installer details page")]
        public void ThenIShouldSeeARdPartyInstallerDetailsPage()
        {
            Page.thirdpartyListPage.assertThirdPartyDetails();
        }

        [Then(@"I should be able to change the status for audit")]
        public void ThenIShouldBeAbleToChangeTheStatusForAudit()
        {
            Page.thirdpartyListPage.editAuditStatus();
        }

        [Then(@"I should be able to change the status  for legal")]
        public void ThenIShouldBeAbleToChangeTheStatusForLegal()
        {
            Page.thirdpartyListPage.editLegalStatus();
        }

        [When(@"I click the third party tab")]
        public void GivenIClickTheRdPartyTab()
        {
            Page.administrationPage.clickOn3rdPartyList();
        }

        [Then(@"I should be able to add third party installers")]
        public void ThenIShouldBeAbleToAddRdPartyInstallers()
        {
            Page.thirdpartyListPage.addThirdpartyInList();
        }


    }
}
