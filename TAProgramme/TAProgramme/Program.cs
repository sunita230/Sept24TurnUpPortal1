using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using TAProgramme.Pages;

public class Program
{
    private static void Main(string[] args)
    {
        //IWebDriver is a browser from Selenium library, driver is the variable, new ChromeDrive is new chrome browser window
        IWebDriver driver = new ChromeDriver();

        //IMPLICIT WAIT: Wait for certain amount of time - wait for every single element on this page
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        //Login page object initialization and definition
        LoginPage loginPageObj = new LoginPage();
        loginPageObj.LoginActions(driver);

        //Homepage object initialization and definition
        HomePage homePageObj = new HomePage();
        homePageObj.NavigateToTMPage(driver);

        //TM page object initialization and definition
        TMPage tMPage = new TMPage();
        tMPage.CreateTimeRecord(driver);
        //tMPage.EditTimeRecord(driver);
        //tMPage.DeleteTimeRecord(driver);





        ////TEST: check if the user had logged in successfully
        ////Find the element from the website and copy XPath
        //IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

        //if (helloHari.Text == "Hello hari!")
        //{
        //    Console.WriteLine("User has logged in successfully, Test passed!");
        //}
        //else 
        //{
        //    Console.WriteLine("User has not logged in successfully, Test failed!");
        //};

    
        ////CHECK IF THE TIME RECORD HAS BEEN CREATED SUCCESSFULLY

        ////Navigate to the last page of Time and Material
        //IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
        //goToLastPageButton.Click();

        //IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

        //if (newCode.Text == "Test Code")
        //{
        //    Console.WriteLine("Time record created successfully");
        //}
        //else
        //{
        //    Console.WriteLine("Time record have not been created");
        //};


    }
}