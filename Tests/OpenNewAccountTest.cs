using NUnit.Framework;

namespace AutomationFramework.Tests
{
    public class OpenNewAccountTest : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            // User login
            Pages.HomePage.Login(
                TestData.TestData.Login.username,
                TestData.TestData.Login.password
            );

            Pages.OverviewPage.OpenNewAccountLink();
        }

        [Test]
        public void OpenNewAcc()
        {
            Pages.OpenAccountPage.OpenNewAccount(TestData.TestData.OpenAccount.savings);

            // Assert - Provera da li smo uspesno otvorili racun
            string resultMessage = Pages.OpenAccountPage.GetNewAccountMessage();
            Assert.AreEqual(AppConstants.Constants.GenericMessage.openedAccountTitle, resultMessage);

            // get account number
            string accountNumber = Pages.OpenAccountPage.GetAccountNumber();
            // Assert - Provera da li je ispravan tip racuna
            Pages.OpenAccountPage.ClickOnAccountNumber();
            string accountNumberNew = Pages.ActivityPage.GetAccountNumber();
            string accountType = Pages.ActivityPage.GetAccountType();

            Assert.AreEqual(accountNumber, accountNumberNew);
            Assert.AreEqual(TestData.TestData.OpenAccount.savings, accountType);
        }
    }
}
