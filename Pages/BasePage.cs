using AutomationFramework.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Threading;

namespace AutomationFramework.Pages
{
    public class BasePage
    {
        // Driver
        public IWebDriver? driver;
        public WebDriverWait wait;


        /// <summary>
        /// Metoda koja ceka vidljivost elementa
        /// </summary>
        private void WaitElementVisibility(By elementBy)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(elementBy));
        }

        /// <summary>
        /// Metoda koja klikne na element
        /// </summary>
        public void ClickElement(By element)
        {
            WaitElementVisibility(element);
            CommonMethods.ClickOnElement(driver, element);
        }

        /// <summary>
        /// Metoda koja upisuje vrednost u polje
        /// </summary>
        public void WriteText(By element, string text)
        {
            WaitElementVisibility(element);
            CommonMethods.WriteTextToElement(driver, element, text);
        } 
        
        /// <summary>
        /// Metoda koja klikne na odredjeni link u meniju
        /// </summary>
        /// <param name="menuItem">Link u meniju</param>
        public void ClickOnMenuItem(string menuItem)
        {
            Thread.Sleep(1000);
            string menuItemXpath = $"//a[contains(., '{menuItem}')]";
            By menuItemLocator = By.XPath(menuItemXpath);
            driver.FindElement(menuItemLocator).Click();
        }
    }    
}
