using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using NUnit.Framework;
using qa01ww.com.drhi.support;
using qa01ww.com.drhi.utils;
using TechTalk.SpecFlow;

namespace qa01ww.com.drhi.stepDefinitions
{
    [Binding]
    public class AutomateRfiSteps
    {

        [Then(@"an Rfi should be sent out automatically")]
        public void ThenAnRfiShouldBeSentOutAutomatically()
        {
            var rhinumber = SqlQueries.retrieveLastApplicationrhiNumber();
            var checkRfiExists = Helpers.emailExists("Domestic RHI " + rhinumber +" - Your next steps");
            Assert.True(checkRfiExists, "Automatic Rfi has failed");
        }

        [Then(@"an Rfi should not be sent out automatically")]
        public void ThenAnRfiShouldNotBeSentOutAutomatically()
        {
            var rhinumber = SqlQueries.retrieveLastApplicationrhiNumber();
            var checkRfiExists = Helpers.emailExists("Domestic RHI " + rhinumber + " - Your next steps");
            Assert.False(checkRfiExists, "Automatic Rfi has been sent");
        }

        [Then(@"Maureen status should change to With Member")]
        public void ThenMaureenStatusShouldChangeToWithMember()
        {
            AppDriver.loadApplication(ConfigurationManager.AppSettings["backend.environment.url"]);
            var emailId = SqlQueries.retrieveLastApplicationEmailId();
            Page.administrationPage.searchApplication(emailId);
            Page.bulkDeclarationPage.assertRfiCreated();
        }

    }
}
