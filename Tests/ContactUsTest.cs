using NUnit.Framework;

namespace AutomationFramework.Tests
{
    public class ContactUsTest : BaseTest
    {
        [Test]
        public void ContactUs()
        {
            Pages.HomePage.ClickOnContact();
            Pages.ContactPage.ContactUs(
                TestData.TestData.ContactUs.name,       
                TestData.TestData.ContactUs.email,       
                TestData.TestData.ContactUs.phone,       
                TestData.TestData.ContactUs.message      
            );

            // Assert
            string successMessage = Pages.ContactPage.GetSuccessMessage();
            Assert.AreEqual(AppConstants.Constants.GenericMessage.successContactUs, successMessage);
        }
    }
}
