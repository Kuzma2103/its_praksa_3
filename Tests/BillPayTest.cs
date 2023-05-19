using NUnit.Framework;

namespace AutomationFramework.Tests
{
    public class BillPayTest : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            // User login
            Pages.HomePage.Login(
                TestData.TestData.Login.username,
                TestData.TestData.Login.password
            );

            Pages.ActivityPage.ClickOnMenuItem(AppConstants.Constants.MenuItems.billPay);
        }

        [Test]
        public void BillPay()
        {
            Pages.BillPayPage.BillPay(
                TestData.TestData.Login.username,
                TestData.TestData.BillPay.address,
                TestData.TestData.BillPay.city,
                TestData.TestData.BillPay.state,
                TestData.TestData.BillPay.zipCode,
                TestData.TestData.BillPay.phone,
                TestData.TestData.BillPay.account,
                TestData.TestData.BillPay.verifyAccount,
                TestData.TestData.BillPay.amount,
                TestData.TestData.BillPay.fromAccount
            );

            // Assert
            string payeeName = Pages.BillPayPage.GetPayeeName();
            string amount = Pages.BillPayPage.GetAmount();
            string fromAccount = Pages.BillPayPage.GetFromAccount();
            string billPayCompleteMessage = $"Bill Payment to {payeeName} in the amount of ${amount} from account {fromAccount} was successful.";
            
            Assert.AreEqual(
                $"Bill Payment to {payeeName} in the amount of ${amount} from account {fromAccount} was successful.",
                billPayCompleteMessage
            );
        }

    }
}
