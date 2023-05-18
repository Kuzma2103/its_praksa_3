using AutomationFramework.Utils;
using OpenQA.Selenium;

namespace AutomationFramework.Pages
{
    public class RegisterUserPage : BasePage
    {
        /// <summary>
        /// Kontstruktor bez parametra
        /// </summary>
        public RegisterUserPage()
        {
            driver = null;
        }

        /// <summary>
        /// Konstruktor sa parametrom
        /// </summary>
        /// <param name="webDriver">driver</param>
        public RegisterUserPage(IWebDriver webDriver)
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
        By ssnField = By.Id("customer.ssn");
        By usernameField = By.Id("customer.username");
        By passwordField = By.Id("customer.password");
        By confirmPasswordField = By.Id("repeatedPassword");
        By registerButton = By.XPath("//input[@value='Register']");
        By usernameTitle = By.XPath("//div[@id='rightPanel']/h1");

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
        /// Metoda koja unosi vrednost u polje SSN
        /// </summary>
        /// <param name="ssn">SSN</param>
        private void EnterSsn(string ssn)
        {
            WriteText(ssnField, ssn);
        }
        
        /// <summary>
        /// Metoda koja unosi vrednost u polje Username
        /// </summary>
        /// <param name="username">Username</param>
        private void EnterUsername(string username)
        {
            WriteText(usernameField, username);
        }
        
        /// <summary>
        /// Metoda koja unosi vrednost u polje Password
        /// </summary>
        /// <param name="password">Password</param>
        private void EnterAndConfirmPassword(string password)
        {
            WriteText(passwordField, password);
            WriteText(confirmPasswordField, password);
        }   
        
        /// <summary>
        /// Metoda koja klikne na dugme Register
        /// </summary>
        private void ClickOnRegisterButton()
        {
            ClickElement(registerButton);
        }

        /// <summary>
        /// Metoda koja vraca ime usera
        /// </summary>
        /// <returns></returns>
        public string GetUsername()
        {
            return CommonMethods.ReadTextFromElement(driver, usernameTitle);
        }

        /// <summary>
        /// Metoda koja popunjava formu za registraciju korisnika
        /// </summary>
        public void RegisterUser(
            string firstName, 
            string lastName, 
            string address, 
            string city, 
            string state, 
            string zipCode, 
            string phone, 
            string ssn, 
            string username, 
            string password
        )
        {
            EnterFirstName(firstName);
            EnterLastName(lastName);
            EnterAddress(address);
            EnterCity(city);
            EnterState(state);
            EnterZipCode(zipCode);
            EnterPhone(phone);
            EnterSsn(ssn);
            EnterUsername(username);
            EnterAndConfirmPassword(password);
            ClickOnRegisterButton();
        }
    }
}
