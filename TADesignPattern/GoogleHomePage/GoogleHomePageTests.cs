using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TADesignPattern.GoogleHomePage
{
    [TestClass]
    public class GoogleHomePageTests 
    {
        [TestInitialize]
        public void TestInit()
        {
            BaseTest.Initialize();

        }

        [TestMethod]
        public void VerifyGooleHomePageTitle()
        {
            string title = BaseTest.driver.Title;
            Assert.IsTrue(title.Equals(Constants.title), "Title is not Matching");
        }

        [TestCleanup]
        public void Cleaning()
        {
            BaseTest.QuitBowser();
        }
    }
}
