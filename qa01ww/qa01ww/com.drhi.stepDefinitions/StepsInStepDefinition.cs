
using TechTalk.SpecFlow;

namespace qa01ww.com.drhi.stepDefinitions
{
    [Binding]
    class StepsInStepDefinition:Steps
    {   

        [Given(@"I have completed the first page of the application form")]
        [When(@"I have completed the first page of the application form")]
        public void WhenIHaveCompletedTheFirstPageOfTheApplicationForm()
        {
            Given(@"I am on homepage");
            Given(@"I am an individual");
            Given(@"I am a heating system sole owner");
            Given(@"I am an owner occupier");
            When(@"I select NO for multiple MCS");
            When(@"I answer Yes for own money used");
            When(@"I select No for Additional funding");
            When(@"I enter EPC number");
            When(@"I select what buildings are heated by the heating system");
            When(@"I select system provides heat for hot water");
            When(@"I select Yes if anyone live in the property before commisioning date");
            When(@"I select property as Scotland");

        }

        [Given(@"I am completing the ""(.*)"" application process")]
        public void GivenIAmCompletingTheAApplicationProcess(string technology)
        {
            Given(@"I have completed the first page of the application form");
            Given(@"I am not with an Investor");
          //  When(@"I create a deemed application");
            When(@"I create a metered application");
            When(string.Format(@"I enter {0} for a given technology", technology));
            When(@"I click on Start application");
            When(@"I complete the second page of the application form");
        }

        [Given(@"I am completing the ""(.*)"" application process as an organisation")]
        public void GivenIAmCompletingTheApplicationProcessAsAnOrganisation(string technology)
        {
            Given(@"I have completed the first page of the application form");
            Given(@"I am not with an Investor");
            When(@"I apply as an organisation");
            When(@"I create a metered application");
            When(string.Format(@"I enter {0} for a given technology", technology));
            When(@"I select The property as England");
            When(@"I click on Start application");
            When(@"I complete the second page of the application form");

        }


        [Given(@"I have created a ""(.*)"" application and logged in")]
        public void GivenIHaveCreatedAApplicationAndLoggedIn(string technology)
        {
            Given(@"I have completed the first page of the application form");
            Given(@"I am not with an Investor");
            When(@"I create a metered application");
            When(string.Format(@"I enter {0} for a given technology", technology));
            When(@"I select what buildings are heated by the heating system");
            When(@"I click on Start application");
            When(@"I complete the second page of the application form");
            When(@"I click submit");
            When(@"I click Sign-In button on Homepage");
            When(@"I enter Username and Password");
            When(@"I click Sign-In into MyRhi");
            Then(@"I should be logged into the application");
            
        }

    }
}
