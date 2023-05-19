using NUnit.Framework;

namespace AutomationFramework.Tests
{
    public class TransferFundsTest : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            // User login
            Pages.HomePage.Login(
                TestData.TestData.Login.username,
                TestData.TestData.Login.password
            );

            Pages.ActivityPage.ClickOnMenuItem(AppConstants.Constants.MenuItems.transferFunds);
        }

        [Test]
        public void TransferFunds()
        {
            Pages.TransferPage.TransferFunds(
                TestData.TestData.TransferFunds.amount, 
                TestData.TestData.TransferFunds.fromAccount, 
                TestData.TestData.TransferFunds.toAccount
            );

            // Assert
            string amountTransfered = Pages.TransferPage.GetAmountTransfered();
            string fromAccount = Pages.TransferPage.GetFromAccountTransfered();
            string toAccount = Pages.TransferPage.GetToAccountTransfered();
            string accountTransferCompleteMessage = $"${amountTransfered} has been transferred from account #{fromAccount} to account #{toAccount}.";
            Assert.AreEqual(
                $"${amountTransfered} has been transferred from account #{fromAccount} to account #{toAccount}.", 
                accountTransferCompleteMessage
            );
        }
    }
}
