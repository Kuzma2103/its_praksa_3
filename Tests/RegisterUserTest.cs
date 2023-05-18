using AutomationFramework.Utils;
using NUnit.Framework;

namespace AutomationFramework.Tests
{
    public class RegisterUserTest : BaseTest
    {
        string _username = CommonMethods.GenerateRandomUsername();

        [Test]
        public void RegisterUser()
        {
            Pages.HomePage.ClickOnRegisterLink();

            // Registration test
            Pages.RegisterUserPage.RegisterUser(
                TestData.TestData.RegisterUser.firstName,
                TestData.TestData.RegisterUser.lastName,
                TestData.TestData.RegisterUser.address,
                TestData.TestData.RegisterUser.city,
                TestData.TestData.RegisterUser.state,
                TestData.TestData.RegisterUser.zipCode,
                TestData.TestData.RegisterUser.phone,
                TestData.TestData.RegisterUser.ssn,
                _username,
                TestData.TestData.RegisterUser.password
            );
            
            // Asertacija testa - Assert test
            string registerUsername = Pages.RegisterUserPage.GetUsername();
            Assert.AreEqual(
                $"{AppConstants.Constants.GenericMessage.usernameTitle} {_username}", 
                registerUsername,
                $"Poruka treba da bude {AppConstants.Constants.GenericMessage.usernameTitle} {_username}"
            );

        }
    }
}
