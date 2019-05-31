using qa01ww.com.drhi.support;
using TechTalk.SpecFlow;

namespace qa01ww.com.drhi.stepDefinitions
{
    [Binding]
    public class CustomerLoginSteps
    {
        [When(@"I click Sign-In into MyRhi")]
        public void GivenIClickOnSign_In()
        {
            Page.loginPage.clickBtnSignInToMyRHI();
        }

        [When(@"I enter Username and Password")]
        public void WhenIEnterUsernameAndPassword()
        {
            Page.loginPage.enterCredentials();
        }
        
        [Then(@"I should be logged into the application")]
        public void ThenIShouldBeLoggedIntoTheApplication()
        {
            Page.customerPage.assertUserLoggedIn();
        }

        [Then(@"I Sign out from MyRHI successfully")]
        public void ThenISignOutFromMyRHI()
        {
           Page.customerPage.clickOnSignout();

        }

        [Then(@"I expect to see all CTAS present")]
        public void ThenIExpectToSeeTenCTASOnTheSidebar()
        {
            Page.customerPage.assertmyRhi();
            Page.customerPage.assertMyApplications();
            Page.customerPage.assertPaymentSchedule();
            Page.customerPage.assertPersonalDetails();
            Page.customerPage.assertAddressDetails();
            Page.customerPage.assertMyPassword();
            Page.customerPage.assertBankDetails();
            Page.customerPage.assertAdditionalApplication();
            Page.customerPage.assertsubmitMeterReading();
            Page.customerPage.assertMMSP();
            Page.customerPage.assertAnualDeclaration();
        }
    }
}
