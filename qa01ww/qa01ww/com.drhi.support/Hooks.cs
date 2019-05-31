using qa01ww.com.drhi.utils;
using System.Configuration;
using System.Security.Cryptography.X509Certificates;
using TechTalk.SpecFlow;

namespace qa01ww.com.drhi.stepDefinitions.setup
{
    [Binding]
    public class BaseStepDef
    {
        [BeforeTestRun]
        public static void doSetup()
        {
            AppDriver.initBrowser(ConfigurationManager.AppSettings["browser"]);
        }

        [AfterScenario()]
        public void afterScenarioHook()
        {
            if (ScenarioContext.Current.TestError != null)
            {
               AppDriver.takeScreenshot();
            }
        }

      
        [AfterTestRun]
        public static void closeAllDrivers()
        {
            AppDriver.closeAllDrivers();
        }
    }
}
