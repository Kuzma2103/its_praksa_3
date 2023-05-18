using AutomationFramework.Utils;
using NUnit.Framework;

namespace AutomationFramework.Tests
{
    public class ForgotLoginTest : BaseTest
    {
        string username = CommonMethods.GenerateRandomUsername("Dejan");
        string password = CommonMethods.GeneratePassword(10, 50).ToString();
        string firstName = "Dejan";
        string lastName = "Mitrovic";

        [SetUp]
        public void Setup()
        {
            // Register user
            Pages.HomePage.ClickOnRegisterLink();

            // Registration test
            Pages.RegisterUserPage.RegisterUser(
                firstName,
                lastName,
                TestData.TestData.RegisterUser.address,
                TestData.TestData.RegisterUser.city,
                TestData.TestData.RegisterUser.state,
                TestData.TestData.RegisterUser.zipCode,
                TestData.TestData.RegisterUser.phone,
                TestData.TestData.RegisterUser.ssn,
                username,
                password
            );

            // Logout user
            Pages.HomePage.ClickOnLogout();
        }

        [Test]
        public void ForgotLogin()
        {
            Pages.HomePage.ClickOnForgotLoginInfo();
            Pages.CustomerLookupPage.FillOutCustomerLookup(
                firstName,
                lastName,
                TestData.TestData.RegisterUser.address,
                TestData.TestData.RegisterUser.city,
                TestData.TestData.RegisterUser.state,
                TestData.TestData.RegisterUser.zipCode,
                TestData.TestData.RegisterUser.ssn
            );
            // Assertacija
        }
    }
}
