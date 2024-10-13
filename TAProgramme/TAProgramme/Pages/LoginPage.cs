using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using TAProgramme.Utilities;

namespace TAProgramme.Pages
{
    public class LoginPage
    {
        //Functions that allow users to login to TurnUp portal

        //Not going to return any value
        public void LoginActions(IWebDriver driver)
        {
            //2. Launch TurnUp portal
            //navigate to a URL using the driver variable
            driver.Navigate().GoToUrl("http://horse.industryconnect.io");
            //Fit the browser window according to the screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);

            //EXPLICIT WAIT
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("UserName")));

            //3. Identify username textbox and enter valid username
            //find the ID of the element from the website
            IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
            //enter a value in the username Textbox
            usernameTextbox.SendKeys("hari");

            Wait.WaitToBeVisible(driver, "Id", "Password", 7);

            //4. Identify password textbox and enter valid password
            //find the ID of the element from the website
            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            //enter a value in the passwprd Textbox
            passwordTextbox.SendKeys("123123");

            //5. Identify login button and click on it

            //If there is no ID, find the element -> right click -> copy -> copy XPath
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            //Click the button
            loginButton.Click();
            Thread.Sleep(2000);
            }

    }
}
