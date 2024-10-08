using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class Program
{
    private static void Main(string[] args)
    {
        //1. Open Chrome browser 
        //IWebDriver is a browser from Selenium library, driver is the variable, new ChromeDrive is new chrome browser window
        IWebDriver driver = new ChromeDriver();

        //2. Launch TurnUp portal
        //navigate to a URL using the driver variable
        driver.Navigate().GoToUrl("http://horse.industryconnect.io");
        //Fit the browser window according to the screen
        driver.Manage().Window.Maximize();

        //3. Identify username textbox and enter valid username

        //find the ID of the element from the website
        IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
        //enter a value in the username Textbox
        usernameTextbox.SendKeys("hari");

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


        //TEST: check if the user had logged in successfully
        //Find the element from the website and copy XPath
        IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

        if (helloHari.Text == "Hello hari!")
        {
            Console.WriteLine("User has logged in successfully, Test passed!");
        }
        else 
        {
            Console.WriteLine("User has not logged in successfully, Test failed!");
        };
    }
}