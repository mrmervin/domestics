using qa01ww.com.drhi.utils;
using System.Configuration;
using TechTalk.SpecFlow;
using qa01ww.com.drhi.support;
using NUnit.Framework;

namespace qa01ww.com.drhi.stepDefinitions
{
    [Binding]
    public class BaseStepDefinition
    {
        [Given(@"I am on Rhita")]
        public void GivenIAmOnRhita()
        {
            AppDriver.loadApplication(ConfigurationManager.AppSettings["backend.environment.url"]);
        }

        [Given(@"I am logged in as DA")]
        public void GivenIAmLoggedInAsDA()
        {
            AppDriver.loadApplication(ConfigurationManager.AppSettings["admin.backend.environment.url"]);
            Page.userAdminPage.changeRole(4);
        }
        
        [Given(@"I am logged in as PM")]
        public void GivenIAmLoggedInAsPM()
        {
            AppDriver.loadApplication(ConfigurationManager.AppSettings["admin.backend.environment.url"]);
            Page.userAdminPage.changeRole(3);
        }

        [Given(@"I am logged in as QA")]
        public void GivenIAmLoggedInAsQA()
        {
            AppDriver.loadApplication(ConfigurationManager.AppSettings["admin.backend.environment.url"]);
            Page.userAdminPage.changeRole(1);
        }

        [Given(@"I am logged in as CSA")]
        public void GivenIAmLoggedInAsCSA()
        {
            AppDriver.loadApplication(ConfigurationManager.AppSettings["admin.backend.environment.url"]);
            Page.userAdminPage.changeRole(0);
        }

        [Given(@"I am on homepage")]
        public void GivenIAmOnHomepage()
        {
            AppDriver.loadApplication(ConfigurationManager.AppSettings["environment.url"]);
        }

        [Given(@"the application  status is accredited")]
        public void GivenTheApplicationStatusIsAccredited()
        {
            SqlQueries.changeApplicationStatus(1);
        }

        [Then(@"an email should not be sent to the applicant")]
        public void ThenNoEmailShouldBeSentToApplicant()
        {
            var email = SqlQueries.retrieveLastApplicationEmailId();
            var emailresponse = Helpers.emailResponseFor(email);
            Assert.That(emailresponse, Is.Null);
        }
    }
}
