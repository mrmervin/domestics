using System;
using OpenQA.Selenium;
using System.Configuration;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using qa01ww.com.drhi.support;

namespace qa01ww.com.drhi.pageObjects
{
    public class LoginPage
    {
        #region Page Elements

        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement emailAddress { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement password { get; set; }
        
        [FindsBy(How = How.Id, Using = "btnSignIn")]
        private IWebElement signInToMyRhi{ get; set; }

        #endregion

        public void enterCredentials()
        {
            var emailId = SqlQueries.retrieveLastApplicationEmailId();
            emailAddress.SendKeys(emailId);
            password.SendKeys(ConfigurationManager.AppSettings["admin.password"]);
        }

        public void clickBtnSignInToMyRHI()
        {
            signInToMyRhi.Click();
        }
    }
}

