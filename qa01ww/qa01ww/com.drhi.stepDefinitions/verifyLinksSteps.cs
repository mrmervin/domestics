using qa01ww.com.drhi.support;
using qa01ww.com.drhi.utils;
using TechTalk.SpecFlow;

namespace qa01ww.com.drhi.stepDefinitions
{
    [Binding]
    public  class VerifyLinksSteps {

        [Then(@"all links present should work")]
        public void ThenAllLinksPresentShouldWork()
        {
            Helpers.verifyAllLinks(AppDriver.Driver);
            
        }

    }
}
