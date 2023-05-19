using AutomationFramework.Utils;
using NUnit.Framework;

namespace AutomationFramework.Tests
{
    public class UpdateContactInfoTest : BaseTest
    {
        string username = CommonMethods.GenerateRandomUsername("LazniMbape");
        string password = CommonMethods.GeneratePassword(1111, 5555).ToString();

        [SetUp]
        public void Setup()
        {
            // Register user
            Pages.HomePage.ClickOnRegisterLink();
            Pages.RegisterUserPage.RegisterUser(
                TestData.TestData.UpdateContactInfo.firstName,
                TestData.TestData.UpdateContactInfo.lastName,
                TestData.TestData.UpdateContactInfo.address,
                TestData.TestData.UpdateContactInfo.city,
                TestData.TestData.UpdateContactInfo.state,
                TestData.TestData.UpdateContactInfo.zipCode,
                TestData.TestData.UpdateContactInfo.phone,
                TestData.TestData.UpdateContactInfo.ssn,
                username,
                password
            );
        }

        [Test]
        public void UpdateContactInfo()
        {
            Pages.OverviewPage.ClickOnMenuItem(AppConstants.Constants.MenuItems.updateContactInfo);
            // Update contact info
            Pages.UpdateProfilePage.UpdateContactInfo(
                TestData.TestData.UpdateContactInfo.firstNameUpdated,
                TestData.TestData.UpdateContactInfo.lastNameUpdated,
                TestData.TestData.UpdateContactInfo.addressUpdated,
                TestData.TestData.UpdateContactInfo.cityUpdated,
                TestData.TestData.UpdateContactInfo.stateUpdated,
                TestData.TestData.UpdateContactInfo.zipCodeUpdated,
                TestData.TestData.UpdateContactInfo.phoneUpdated
            );

            // Assert
            string contactTitle = Pages.UpdateProfilePage.GetUpdateProfileTitle();
            Assert.AreEqual(AppConstants.Constants.GenericTitles.contactTitle, contactTitle);
        }
    }
}
