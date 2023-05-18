using NUnit.Framework;

namespace AutomationFramework.Tests
{
    public class LoginTest : BaseTest
    {

        [Test]
        public void LoginUser()
        {
            Pages.HomePage.Login(
                TestData.TestData.Login.username, 
                TestData.TestData.Login.password
            );

            // Assert
            Assert.IsTrue(Pages.HomePage.IsAccountOverviewPresented());
        }
    }
}
