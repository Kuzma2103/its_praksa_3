using OpenQA.Selenium;

namespace AutomationFramework.Pages
{
    public class CustomerLookupPage : BasePage
    {
        /// <summary>
        /// Konstruktor bez paramtra
        /// </summary>
        public CustomerLookupPage()
        {
            driver = null;
        }

        /// <summary>
        /// Konstruktor sa parametrima
        /// </summary>
        /// <param name="webDriver">driver</param>
        public CustomerLookupPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        // Locators

        By firstNameField = By.Id("firstName");
        By lastNameField = By.Id("lastName");
        By addressField = By.Id("address.street");
        By cityField = By.Id("address.city");
        By stateField = By.Id("address.state");
        By zipCodeField = By.Id("address.zipCode");
        By ssnField = By.Id("ssn");
        By findMyLoginInfoButton = By.XPath("//input[@value='Find My Login Info']");

        /// <summary>
        /// Metoda koja upisuje vrednost u polju First Name
        /// </summary>
        /// <param name="firstName">First Name</param>
        private void EnterFirstName(string firstName)
        {
            WriteText(firstNameField, firstName);
        }

        /// <summary>
        /// Metoda koja upisuje vrednost u polju Last Name
        /// </summary>
        /// <param name="lastName">Last Name</param>
        private void EnterLastName(string lastName)
        {
            WriteText(lastNameField, lastName);
        }

        /// <summary>
        /// Metoda koja upisuje vrednost u polju Address
        /// </summary>
        /// <param name="address">Address</param>
        private void EnterAddress(string address)
        {
            WriteText(addressField, address);
        }

        /// <summary>
        /// Metoda koja upisuje vrednost u polju City
        /// </summary>
        /// <param name="city">City</param>
        private void EnterCity(string city)
        {
            WriteText(cityField, city);
        }

        /// <summary>
        /// Metoda koja upisuje vrednost u polju State
        /// </summary>
        /// <param name="state">State</param>
        private void EnterState(string state)
        {
            WriteText(stateField, state);
        }

        /// <summary>
        /// Metoda koja upisuje vrednost u polju Zip Code
        /// </summary>
        /// <param name="zipCode">Zip Code</param>
        private void EnterZipCode(string zipCode)
        {
            WriteText(zipCodeField, zipCode);
        }

        /// <summary>
        /// Metoda koja upisuje vrednost u polju SSN
        /// </summary>
        /// <param name="ssn">SSN</param>
        private void EnterSsn(string ssn)
        {
            WriteText(ssnField, ssn);
        }

        /// <summary>
        /// Metoda koja klikne na dugme Find login info
        /// </summary>
        private void ClickOnFindByLoginInfoButton()
        {
            ClickElement(findMyLoginInfoButton);
        }

        /// <summary>
        /// Metoda koja popunjava formu Customer Lookup
        /// </summary>
        public void FillOutCustomerLookup(
            string firstName,
            string lastName,
            string address,
            string city,
            string state,
            string zipCode,
            string ssn
        )
        {
            EnterFirstName(firstName);
            EnterLastName(lastName);
            EnterAddress(address);
            EnterCity(city);
            EnterState(state);
            EnterZipCode(zipCode);
            EnterSsn(ssn);
            ClickOnFindByLoginInfoButton();
        }
    }
}
