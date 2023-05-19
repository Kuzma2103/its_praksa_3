using AutomationFramework.Utils;
using OpenQA.Selenium;

namespace AutomationFramework.Pages
{
    public class ActivityPage : BasePage
    {
        /// <summary>
        /// Konstruktor bez paramtra
        /// </summary>
        public ActivityPage()
        {
            driver = null;
        }

        /// <summary>
        /// Konstruktor sa parametrima
        /// </summary>
        /// <param name="webDriver">driver</param>
        public ActivityPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        // locators

        By accountNumberElement = By.Id("accountId");
        By accountTypeElement = By.Id("accountType");


        /// <summary>
        /// Metoda koja vraca broj racuna
        /// </summary>
        /// <returns></returns>
        public string GetAccountNumber()
        {
            return CommonMethods.ReadTextFromElement(driver, accountNumberElement);
        }
        
        /// <summary>
        /// Metoda koja vraca tip racuna
        /// </summary>
        /// <returns></returns>
        public string GetAccountType()
        {
            return CommonMethods.ReadTextFromElement(driver, accountTypeElement);
        }

    }
}
