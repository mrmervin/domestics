using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Net;
using NUnit.Framework;
using System.IO;

namespace qa01ww.com.drhi.support
{
    public static class Helpers
    {
        static string queryResult;

        public static bool emailExists(string text)
        {
            return emailResponseFor(text)!=null;
        }

        public static string emailResponseFor(string email)
        {
            return Directory.GetFiles(ConfigurationManager.AppSettings["EmailPickupDirectory"], "*.eml")
                .Select(File.ReadAllText).FirstOrDefault(readFile => readFile.Contains(email));
        }

        public static String generateRandom(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max).ToString();
        }

        public static String connectingDB(String query, String DbConnection)
        {
            var connection = ConfigurationManager.ConnectionStrings[DbConnection].ConnectionString;
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            object result = cmd.ExecuteScalar();
          
            return result == null || result == DBNull.Value ? null : result.ToString();

            conn.Close();
        }

        public static void verifyAllLinks(IWebDriver driver)
        {
            var urls = driver.FindElements(By.TagName("a")).Take(30);

            foreach (var url in urls)
            {
                //get url 
                //declare webrequest
                HttpWebRequest re = null;
                re = (HttpWebRequest)WebRequest.Create(url.GetAttribute("href"));
                try
                {
                    HttpWebResponse response = (HttpWebResponse)re.GetResponse();
                    //prints response in logs generated
                    Console.WriteLine($"URL:{url.GetAttribute("href")}status  is:{response.StatusCode}");
                    Assert.IsTrue(response.StatusCode.ToString().Contains("OK"));
                }
                catch (WebException e)
                {
                    var errorresponse = (HttpWebResponse)e.Response;
                    Debug.Print($"URL:{url.GetAttribute("href")} status is :{errorresponse.StatusCode}");
                }
            }
        }

        public static void connectingDBwithParameter(String query, String DbConnection, String regulationDate)
        {
            var connection = ConfigurationManager.ConnectionStrings[DbConnection].ConnectionString;
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@regulationDate", regulationDate);
            cmd.ExecuteNonQuery();
        }

      


        public static Boolean IsElementDisplayedandEnabled(IWebElement element)
        {
            try
            {
                return element.Displayed && element.Enabled;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static Boolean IsElementPresent(IWebElement element)
        {
            try
            {
                return element.Enabled;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static void explicitWait(IWebDriver driver, String text)
        {
            (new WebDriverWait(driver, TimeSpan.FromSeconds(5))).Until(ExpectedConditions.ElementIsVisible(By.Id(text)));
        }

        public static void clickOnIt(this IWebElement element)
        {
            try
            {
                element.Click();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                element.SendKeys(Keys.Space);
            }
        }
    }
}



