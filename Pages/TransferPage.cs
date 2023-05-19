using AutomationFramework.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutomationFramework.Pages
{
    public class TransferPage : BasePage
    {
        /// <summary>
        /// Konstruktor bez paramtra
        /// </summary>
        public TransferPage()
        {
            driver = null;
        }

        /// <summary>
        /// Konstruktor sa parametrima
        /// </summary>
        /// <param name="webDriver">driver</param>
        public TransferPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        // Locators

        By amountField = By.Id("amount");
        By fromAccountDropdown = By.Id("fromAccountId");
        By transferButton = By.XPath("//input[contains(@value, 'Transfer')]");
        By toAccountTransfered = By.Id("toAccountId");


        /// <summary>
        /// Metoda koja upisuje vrednost u polje Amount
        /// </summary>
        /// <param name="amount">Amount</param>
        private void EnterAmount(string amount)
        {
            CommonMethods.WriteTextToElement(driver, amountField, amount);
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
        /// Metoda koja bira vrednost u polju To Account
        /// </summary>
        /// <param name="toAccount">racun na koji se prebacuje novac</param>
        private void SelectToAccount(string toAccount)
        {
            SelectElement select = new SelectElement(driver.FindElement(fromAccountDropdown));
            select.SelectByText(toAccount);
        }

        /// <summary>
        /// Metoda koja klikne na dugme Transfer
        /// </summary>
        private void ClickOnTransferButton()
        {
            CommonMethods.ClickOnElement(driver, transferButton);
        }

        /// <summary>
        /// Metoda koja vraca koliko je novca prebaceno
        /// </summary>
        /// <returns>Vraca vrednost prebacenog novca</returns>
        public string GetAmountTransfered()
        {
            return CommonMethods.ReadTextFromElement(driver, amountField);
        }

        /// <summary>
        /// Metoda koja vraca broj racuna sa kog je prebacen novac (From account)
        /// </summary>
        /// <returns>Vraca broj racuna sa kog je prebacen novac</returns>
        public string GetFromAccountTransfered()
        {
            return CommonMethods.ReadTextFromElement(driver, fromAccountDropdown);
        }

        /// <summary>
        /// Metoda koja vraca broj racuna na koji je prebacen novac (To account)
        /// </summary>
        /// <returns>Vraca broj racuna na koji je prebacen novac</returns>
        public string GetToAccountTransfered()
        {
            return CommonMethods.ReadTextFromElement(driver, toAccountTransfered);
        }

        /// <summary>
        /// Metoda koja vrsi transfer sa jednog racuna na drugi
        /// </summary>
        /// <param name="amount">Amount</param>
        public void TransferFunds(string amount, string fromAccount, string toAccount)
        {
            EnterAmount(amount);
            SelectFromAccount(fromAccount);
            SelectToAccount(toAccount);
            ClickOnTransferButton();
        }
    }
}
