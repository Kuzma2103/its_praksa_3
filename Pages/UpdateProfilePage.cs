using AutomationFramework.Utils;
using OpenQA.Selenium;
using System.Threading;

namespace AutomationFramework.Pages
{
    public class UpdateProfilePage : BasePage
    {
        /// <summary>
        /// Konstruktor bez paramtra
        /// </summary>
        public UpdateProfilePage()
        {
            driver = null;
        }

        /// <summary>
        /// Konstruktor sa parametrima
        /// </summary>
        /// <param name="webDriver">driver</param>
        public UpdateProfilePage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        // Locators

        By firstNameField = By.Id("customer.firstName");
        By lastNameField = By.Id("customer.lastName");
        By addressField = By.Id("customer.address.street");
        By cityField = By.Id("customer.address.city");
        By stateField = By.Id("customer.address.state");
        By zipCodeField = By.Id("customer.address.zipCode");
        By phoneField = By.Id("customer.phoneNumber");
        By updateProfileButton = By.XPath("//input[contains(@value, 'Update Profile')]");
        By profileTitle = By.XPath("//div[@class='ng-scope']/h1");
        

        /// <summary>
        /// Metoda koja unosi vrednost u polje First Name
        /// </summary>
        /// <param name="firstName">First name</param>
        private void EnterFirstName(string firstName)
        {
            WriteText(firstNameField, firstName);
        }

        /// <summary>
        /// Metoda koja unosi vrednost u polje Last Name
        /// </summary>
        /// <param name="lastName">Last name</param>
        private void EnterLastName(string lastName)
        {
            WriteText(lastNameField, lastName);
        }

        /// <summary>
        /// Metoda koja unosi vrednost u polje Address
        /// </summary>
        /// <param name="address">Address</param>
        private void EnterAddress(string address)
        {
            WriteText(addressField, address);
        }

        /// <summary>
        /// Metoda koja unosi vrednost u polje City
        /// </summary>
        /// <param name="city">City</param>
        private void EnterCity(string city)
        {
            WriteText(cityField, city);
        }

        /// <summary>
        /// Metoda koja unosi vrednost u polje State
        /// </summary>
        /// <param name="state">State</param>
        private void EnterState(string state)
        {
            WriteText(stateField, state);
        }

        /// <summary>
        /// Metoda koja unosi vrednost u polje Zip Code
        /// </summary>
        /// <param name="zipCode">Zip code</param>
        private void EnterZipCode(string zipCode)
        {
            WriteText(zipCodeField, zipCode);
        }

        /// <summary>
        /// Metoda koja unosi vrednost u polje Phone
        /// </summary>
        /// <param name="phone">Phone</param>
        private void EnterPhone(string phone)
        {
            WriteText(phoneField, phone);
        }

        /// <summary>
        /// Metoda koja klikne na dugme update profile
        /// </summary>
        private void ClickOnUpdateProfile()
        {
            ClickElement(updateProfileButton);
        }

        /// <summary>
        /// Metoda koja vraca vrednost profile title-a
        /// </summary>
        /// <returns>vraca vrednost profile title-a</returns>
        public string GetUpdateProfileTitle()
        {
            return CommonMethods.ReadTextFromElement(driver, profileTitle);
        }

        /// <summary>
        /// Metoda koja popunjava formu za update contact info
        /// </summary>
        public void UpdateContactInfo(
            string firstName,
            string lastName,
            string address,
            string city,
            string state,
            string zipCode,
            string phone
        )
        {
            EnterFirstName(firstName);
            EnterLastName(lastName);
            EnterAddress(address);
            EnterCity(city);
            EnterState(state);
            EnterZipCode(zipCode);
            EnterPhone(phone);
            ClickOnUpdateProfile();
            Thread.Sleep(500);
        }
    }
}
