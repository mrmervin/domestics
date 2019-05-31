using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace qa01ww.com.drhi.pageobjects
{
   public  class HeaderSection
    {
        [FindsBy(How = How.Id, Using = "AssistedDigitalBtn")]
        private IWebElement asistedDigital { get; set; }

        [FindsBy(How = How.Id, Using = "AdministrationBtn")]
        private IWebElement administrationBtn { get; set; }

        [FindsBy(How = How.Id,Using= "underReviewTabLink")]
        private IWebElement underReviewTabLink { get; set; }

        public void clickOnAssistedApplicationBtn()
        {
            asistedDigital.Click();
        }
        public void clickOnAdministrationBtn()
        {
            administrationBtn.Click();
        }

        public void clickOnToReviewTab()
        {
            underReviewTabLink.Click();
        }



    }
}
