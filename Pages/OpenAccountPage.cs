using AutomationFramework.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Threading;

namespace AutomationFramework.Pages
{
    public class OpenAccountPage : BasePage
    {
        /// <summary>
        /// Konstruktor bez paramtra
        /// </summary>
        public OpenAccountPage()
        {
            driver = null;
        }

        /// <summary>
        /// Konstruktor sa parametrima
        /// </summary>
        /// <param name="webDriver">driver</param>
        public OpenAccountPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        // Locators

        By dropdownElement = By.Id("type");
        By dropdownAccountElement = By.Id("fromAccountId");
        By accountSelectOptions = By.XPath("//select[@id='fromAccountId']/option");
        By openNewAccountButton = By.XPath("//input[contains(@value, 'Open New Account')]");
        By accountOpenedTitle = By.ClassName("title");
        By accountNumberElement = By.Id("newAccountId");

        /// <summary>
        /// Metoda koja bira tip racuna
        /// </summary>
        private void SelectTypeOfAccount(string typeOfAccount)
        {
            SelectElement select = new SelectElement(driver.FindElement(dropdownElement));
            Thread.Sleep(1000);
            select.SelectByText(typeOfAccount);
        }

        /// <summary>
        /// Metoda koja bira random racun 
        /// </summary>
        private void SelectRandomAccount()
        {
            // Get all values from options inside select tag (fromAccountId)
            List<string> options = CommonMethods.GetAllOptions(driver, accountSelectOptions);
            SelectElement select = new SelectElement(driver.FindElement(dropdownAccountElement));
            select.SelectByText(CommonMethods.GetRandomItemFromList(options));
        }

        /// <summary>
        /// Metoda koja klikne na dugme open new account
        /// </summary>
        private void ClickOnOpenNewAccount()
        {
            ClickElement(openNewAccountButton); 
        }

        /// <summary>
        /// Metoda koja vraca tekst iz title-a
        /// </summary>
        /// <returns></returns>
        public string GetNewAccountMessage()
        {
            return CommonMethods.ReadTextFromElement(driver, accountOpenedTitle);
        }
        
        /// <summary>
        /// Metoda koja vraca tekst broj racuna
        /// </summary>
        /// <returns></returns>
        public string GetAccountNumber()
        {
            return CommonMethods.ReadTextFromElement(driver, accountNumberElement);
        }
        
        /// <summary>
        /// Metoda koja klikne na kreirani broj racuna
        /// </summary>
        public void ClickOnAccountNumber()
        {
            ClickElement(accountNumberElement);
        }

        /// <summary>
        /// Metoda koja otvara racun
        /// </summary>
        /// <param name="typeOfAccount"></param>
        /// <param name="account"></param>
        public void OpenNewAccount(string typeOfAccount)
        {
            SelectTypeOfAccount(typeOfAccount);
            SelectRandomAccount();
            ClickOnOpenNewAccount();
            Thread.Sleep(1000);
        }
    }
}
