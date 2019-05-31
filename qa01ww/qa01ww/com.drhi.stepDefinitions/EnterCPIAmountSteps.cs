using System.Threading.Tasks;
using qa01ww.com.drhi.support;
using TechTalk.SpecFlow;

namespace qa01ww
{
    [Binding]
    public class AllowPaymentManagerToEnterCPIAmountSteps
    {
        [When(@"I click the CPI tab")]
        public void WhenIClickTheCPITab()
        {
            SqlQueries.deleteCpiUpdates();
            Task.Delay(1000);
            Page.administrationPage.clickOnCpi();
          }

        [When(@"I complete the  CPI details form")]
        public void WhenICompleteTheCPIDetailsForm()
        {
            Page.CpiDetailsPage.completeForm();
            Page.CpiDetailsPage.assertCpiConfirmPopup();
        }

        [Then(@"It should be added to the list successfully")]
        public void ThenItShouldBeAddedToTheListSuccessfully()
        {
            Page.CpiDetailsPage.assertCpiInList();
        }

        [Then(@"the state should be pending")]
        public void ThenTheStateShouldBePending()
        {
            Page.CpiDetailsPage.assertStatusPending();
            SqlQueries.deleteCpiUpdates();
        }
    }
}