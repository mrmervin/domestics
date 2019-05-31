using qa01ww.com.drhi.support;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using qa01ww.com.drhi.utils;
using System;

namespace qa01ww.com.drhi.pageObjects.com.drhi.pageobjects.external
{

    public class ApplicationSubmittedPage
    {
        [FindsBy(How = How.Id, Using = "unsuccessfulMessage")]
        private IWebElement unsuccessfulMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='IneligibiltyReasons']/div/div/div/div/p[2]")]
        private IWebElement IneligibilityReason { get; set; }

        public void assertHardClosurePage()
        {
            Assert.True(AppDriver.Driver.Title.Contains("Sorry the scheme is now closed to new applications"));
        }

        public void assertRejectionMessageNoIMQS()
        {
            Helpers.explicitWait(AppDriver.Driver, "page");
            {
                Assert.True(unsuccessfulMessage.Text.Contains(
                    "We have determined that your installation needs to be metered for payment. However, you do not have a copy of the 'Installer Metering Questions' which must be submitted as part of your application."));
            }
        }

        public void assertRejectionMessageNoEpc()
        {
            Helpers.explicitWait(AppDriver.Driver, "page");
            {
                Assert.True(unsuccessfulMessage.Text.Contains(
                    "We have determined that your Energy Performance Certificate (EPC) has requirements for loft or cavity wall insulation to be installed."));
            }
        }

        public void assertInreviewPage()
        {
            Helpers.explicitWait(AppDriver.Driver, "page");
            {
                Assert.True(AppDriver.Driver.Title.Contains("Almost there! Your application is in review"));
            }
        }

        public void assertTrueCongratulationsPage()
        {
            Helpers.explicitWait(AppDriver.Driver, "page");

            Assert.True(AppDriver.Driver.Title.Contains("Congratulations"));

        }

        public void assertFalseCongratulationsPage()
        {
            Helpers.explicitWait(AppDriver.Driver, "page");

            Assert.False(AppDriver.Driver.Title.Contains("Congratulations"));
        }

        public void assertFalseRejectionPage()
        {
            Assert.False(AppDriver.Driver.Title.Contains("sorry to say"));
        }

        public void assertsSoftClosurePage()
        {
            Assert.True(AppDriver.Driver.Title.Contains("sorry to say"));
            Assert.True(IneligibilityReason.Text.Contains(
                "(BEIS) recently introduced regulations which restricted eligibility" +
                " to apply for the Domestic RHI to those renewable heating systems " +
                "commissioned before the scheme closure deadline"));
        }
    }
}

