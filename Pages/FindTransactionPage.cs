using AutomationFramework.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace AutomationFramework.Pages
{
    public class FindTransactionPage : BasePage
    {
        public FindTransactionPage()
        {
            driver = null;
        }

        public FindTransactionPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        By accountDropdown = By.Id("accountId");
        By dateInputField = By.Id("criteria.onDate");
        By findTransactionButton = By.XPath("(//button[@class='button'][contains(@ng-click, 'DATE')])[1]");
        By transactionTable = By.Id("transactionTable");

        /// <summary>
        /// Metoda koja bira account u dropdown-u
        /// </summary>
        /// <param name="account">broj racuna</param>
        private void SelectAccount(string account)
        {
            SelectElement select = new SelectElement(driver.FindElement(accountDropdown));
            select.SelectByValue(account);
        }

        /// <summary>
        /// Metoda koja upisuje vrednost u polje Find By Date
        /// </summary>
        /// <param name="date">datum - e.g. 05-19-2023</param>
        private void EnterFindByDate(string date)
        {
            WriteText(dateInputField, date);
        }

        /// <summary>
        /// Metoda koja klikne na dugme Find transactions - By DATE
        /// </summary>
        private void ClickOnFindTransaction()
        {
            ClickElement(findTransactionButton);
        }

        public bool IsTransactionResultsDisplayed()
        {
            return CommonMethods.IsElementPresented(driver, transactionTable);
        }

        /// <summary>
        /// Metoda koja vrsi pretragu racuna po datumu
        /// </summary>
        /// <param name="account">racun</param>
        /// <param name="date">datum</param>
        public void FindTransaction(string account, string date)
        {
            SelectAccount(account);
            EnterFindByDate(date);
            ClickOnFindTransaction();
            Thread.Sleep(1000);
        }
    }
}
