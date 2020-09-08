using OpenQA.Selenium;

namespace TADesignPattern
{
    /*Single tone Design Patten for Test automation Project 
     * 
     * */
    class BaseTest
    {
        public static IWebElement driver = null;

        public static void Initialize()
        {
            if (driver == null)
            {
                
            }
        }


    }
}
