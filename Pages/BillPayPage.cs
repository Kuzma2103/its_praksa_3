using AutomationFramework.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace AutomationFramework.Pages
{
    public class BillPayPage : BasePage
    {
        public BillPayPage()
        {
            driver = null;
        }

        public BillPayPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        By payeeNameField = By.Name("payee.name");
        By addressField = By.Name("payee.address.street");
        By cityField = By.Name("payee.address.city");
        By stateField = By.Name("payee.address.state");
        By zipCodeField = By.Name("payee.address.zipCode");
        By phoneField = By.Name("payee.phoneNumber");
        By accountField = By.Name("payee.accountNumber");
        By verifyAccountField = By.Name("verifyAccount");
        By amountField = By.Name("amount");
        By fromAccountDropdown = By.Name("fromAccountId");
        By sendPaymentButton = By.XPath("//input[contains(@value, 'Send Payment')]");
        By payeeNameComplete = By.Id("payeeName");
        By amountComplete = By.Id("amount");
        By fromAccountComplete = By.Id("fromAccountId");


        /// <summary>
        /// Metoda koja unosi vrednost u polje First Name
        /// </summary>
        /// <param name="payeeName">First name</param>
        private void EnterPayeeName(string payeeName)
        {
            WriteText(payeeNameField, payeeName);
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
        /// Metoda koja unosi vrednost u polje Account
        /// </summary>
        /// <param name="account">Account</param>
        private void EnterAccount(string account)
        {
            WriteText(accountField, account);
        }

        /// <summary>
        /// Metoda koja unosi vrednost u polje Verify Account
        /// </summary>
        /// <param name="account">Verify account</param>
        private void EnterVerifyAccount(string account)
        {
            WriteText(verifyAccountField, account);
        }

        /// <summary>
        /// Metoda koja unosi vrednost u polje Amount
        /// </summary>
        /// <param name="amount">amount</param>
        private void EnterAmount(string amount)
        {
            WriteText(amountField, amount);
        }

        /// <summary>
        /// Metoda koja bira vrednost u polju From Account
        /// </summary>
        /// <param name="fromAccount">broj racuna sa kog se prebacuje novac</param>
        private void SelectFromAccount(string fromAccount)
        {
            SelectElement select = new SelectElement(driver.FindElement(fromAccountDropdown));
            select.SelectByText(fromAccount);
        }

        /// <summary>
        /// Metoda koja klikne na dugme Send payment
        /// </summary>
        private void ClickOnSendPayment()
        {
            CommonMethods.ClickOnElement(driver, sendPaymentButton);
        }

        /// <summary>
        /// Metoda koja vraca vrednost payee name
        /// </summary>
        /// <returns>vraca vrednost payee name</returns>
        public string GetPayeeName()
        {
            return CommonMethods.ReadTextFromElement(driver, payeeNameComplete);
        }

        /// <summary>
        /// Metoda koja vraca vrednost from account
        /// </summary>
        /// <returns>vraca vrednost from account</returns>
        public string GetFromAccount()
        {
            return CommonMethods.ReadTextFromElement(driver, fromAccountComplete);
        }
        
        /// <summary>
        /// Metoda koja vraca vrednost amount
        /// </summary>
        /// <returns>vraca vrednost amount</returns>
        public string GetAmount()
        {
            return CommonMethods.ReadTextFromElement(driver, amountComplete);
        }



        public void BillPay(
            string payeeName,
            string address,
            string city,
            string state,
            string zipCode,
            string phone,
            string account,
            string verifyAccount,
            string amount,
            string fromAccount
        )
        {
            EnterPayeeName(payeeName);
            EnterAddress(address);
            EnterCity(city);
            EnterState(state);
            EnterZipCode(zipCode);
            EnterPhone(phone);
            EnterAccount(account);
            EnterAccount(account);
            EnterVerifyAccount(verifyAccount);
            EnterAmount(amount);
            SelectFromAccount(fromAccount);
            ClickOnSendPayment();
            Thread.Sleep(500);
        }
    }
}
