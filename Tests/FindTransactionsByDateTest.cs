using NUnit.Framework;

namespace AutomationFramework.Tests
{
    public class FindTransactionsByDateTest : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            // User login
            Pages.HomePage.Login(
                TestData.TestData.Login.username,
                TestData.TestData.Login.password
            );

            Pages.HomePage.ClickOnMenuItem("Find Transactions");            
        }

        [Test]
        public void FindTransactionByDate()
        {
            Pages.FindTransactionPage.FindTransaction(
                TestData.TestData.FindTransaction.accountNumber, 
                TestData.TestData.FindTransaction.date
            );
            
            // Assert
            Assert.IsTrue(Pages.FindTransactionPage.IsTransactionResultsDisplayed());
        }
    }
}
