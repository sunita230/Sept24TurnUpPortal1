using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V127.LayerTree;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAProgramme.Utilities
{
    public class Wait
    {
        //Generic fuction to wait for an element to be clickable

        //Static method - dont need to create an object to be able to use it
        public static void WaitToBeClickable(IWebDriver driver, string locatorType, string locatorValue, int seconds) 
        {
            //Make the method reusable
            var wait = new WebDriverWait(driver, new TimeSpan(0,0,seconds));
  

            if (locatorType == "XPath") 
            {
               wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue)));
            }

            if (locatorType == "Id") 
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue)));
            }
        }

        public static void WaitToBeVisible(IWebDriver driver, string locatorType, string locatorValue, int seconds)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));


            if (locatorType == "XPath")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue)));
            }

            if (locatorType == "Id")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue)));
            }

        }

    }
}
