using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace qa01ww.com.drhi.pageObjects
{
    public class UserAdminPage
    {
        #region Page Elements

        [FindsBy(How = How.Id, Using = "userName")]
        private IWebElement currentUserName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='existingUsersList_filter']/label/input")]
        private IWebElement searchForUser { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='existingUsersList']/tbody/tr/td[4]/a[1]")]
        private IWebElement editUserRole { get; set; }

        [FindsBy(How = How.Id, Using = "SelectedRole")]
        private IWebElement selectedRole { get; set; }

        [FindsBy(How = How.Id, Using = "saveUser")]
        private IWebElement btn_saveUser { get; set; }

        #endregion

        public void changeRole(int value)
        {
            var welcomeText= currentUserName.Text;
            //Get username from displayed text
            //trims out the last character from username
            var getUsername = welcomeText.Substring(welcomeText.IndexOf(@"\") + 1);
            var lastName = getUsername.Substring(0, getUsername.Length - 1);
            searchForUser.SendKeys(lastName);
            editUserRole.Click();
            var title = new SelectElement(selectedRole);
            title.SelectByIndex(value);
            btn_saveUser.Click();
        }
    }
}



