using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.IO;

namespace qa01ww.com.drhi.utils
{
    public class AppDriver
    {
        private static IWebDriver driver;
        private static readonly IDictionary<string, IWebDriver> Drivers = new Dictionary<string, IWebDriver>();

        public static IWebDriver Driver
        {
            get
            {
                if (driver == null)
                    throw new NullReferenceException(
                        "The browser instance was not initialised .you should first call the method InitBrowser");
                return driver;
            }
            private set { driver = value; }
        }

        public static void initBrowser(string browserName)
        {
            switch (browserName)
            {
                case "Firefox":
                {
                    driver = new FirefoxDriver();
                    Drivers.Add("Firefox", Driver);
                }
                    break;

                case "Chrome":
                {
                    driver = new ChromeDriver();
                    Drivers.Add("Chrome", Driver);
                }
                    break;

                case "IE":
                {
                    driver = new InternetExplorerDriver();
                    Drivers.Add("IE", Driver);
                }
                    break;
            }
            doAllBrowserSetup(driver);
        }

        public static void loadApplication(string url)
        {
            Driver.Url = url;
        }

        public static void closeAllDrivers()
        {
            foreach (var key in Drivers.Keys)
            {
                Drivers[key].Close();
                Drivers[key].Quit();
            }
        }
        
        private static void doAllBrowserSetup(IWebDriver driver)
        {
           // driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            //driver.Manage().Timeouts().ImplicitWait(TimeSpan.FromSeconds(3));
        }

        public static void takeScreenshot()
        {
            var takescreenshot = driver as ITakesScreenshot;
            if (takescreenshot != null)
            {
                var screenshot = takescreenshot.GetScreenshot();
                var tempFileName = Path.Combine(Directory.GetCurrentDirectory(),
                                       Path.GetFileNameWithoutExtension(Path.GetTempFileName())) + ".jpg";
                screenshot.SaveAsFile(tempFileName, ScreenshotImageFormat.Jpeg);
                Console.WriteLine($"SCREENSHOT[ file:///{tempFileName} ]SCREENSHOT");
            }
        }
    }
}
