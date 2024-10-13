using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAProgramme.Utilities;

namespace TAProgramme.Pages
{
    public class HomePage
    {

        public void NavigateToTMPage (IWebDriver driver) 
        {

            //CREATE A "TIME" RECORD

            //Navigate to Adminstration tab 
            IWebElement adminstrationTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a/span"));
            //Click on the Adminstration tab
            adminstrationTab.Click();

            Wait.WaitToBeClickable(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a", 10);

            //Navigate to Time and Material tab
            IWebElement timeAndMaterialOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            //Click on the Time and Material tab
            timeAndMaterialOption.Click();

        }
    }
}
