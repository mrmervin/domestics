using System.Threading.Tasks;
using qa01ww.com.drhi.support;
using TechTalk.SpecFlow;

namespace qa01ww.com.drhi.stepDefinitions
{
    [Binding]
    public class BulkDeclarationSteps
    {
        [Given(@"the first annual declaration is due")]
        public void GivenTheAnnualDeclarationIsDue()
        {
           SqlQueries.updateAnnualdeclaration();
        }

        [When(@"I sign as complaint via bulk sign declaration page")]
        public void WhenISignDeclarationAsComplaintViaBulkSignAdminPage()
        {
            SqlQueries.cleanBulkDeclarationsNotCreatedToday();
            Page.headerSection.clickOnAdministrationBtn();
            Page.administrationPage.clickOnBulkDeclaration();
            Page.bulkDeclarationPage.selectApplications();
            Page.bulkDeclarationPage.signDeclarationBtn();
        }

        [Then(@"a new Interaction is created")]
        public void ThenANewInteractionIsCreated()
        {
            for (int row = 1; row <= 3; row++)
            {
                var emailId = SqlQueries.getRowResult(row);
                Page.administrationPage.searchApplication(emailId);
                Task.Delay(2000);
                Page.bulkDeclarationPage.assertInteraction();
            }
        }
    }
}

