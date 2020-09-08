using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace TADesignPattern
{
    /*Single tone Design Patten for Test automation Project 
     * 
     * */
    public class BaseTest
    {
        public static IWebDriver driver = null;

        public static void Initialize()
        {
            if (driver == null)
            {
                if (Constants.browserName == "chrome")
                {
                    driver = new ChromeDriver();
                }
            }
            //driver.Manage().Cookies.DeleteAllCookies();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(Constants.googleUrl);
            System.Threading.Thread.Sleep(5000);
        }


        public static void QuitBowser()
        {
            driver.Quit();
            driver = null;
        }

        public static void CloseBowser()
        {
            driver.Close();
            driver = null;
        }


    }
}
