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

        //CREATE A "TIME" RECORD

        //Navigate to Adminstration tab 
        IWebElement adminstrationTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a/span"));
        //Click on the Adminstration tab
        adminstrationTab.Click();

        //Navigate to Time and Material tab
        IWebElement timeAndMaterialOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
        //Click on the Time and Material tab
        timeAndMaterialOption.Click();

        //Navigate to the "Create New" button
        IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
        //Click on "Create New" button
        createNewButton.Click();

        //Find the TypeCode dropdown 
        IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
        typeCodeDropdown.Click();
        //Select "Time" from the dropdown TypeCode
        IWebElement timeOption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
        timeOption.Click();

        //Type the code into the Code textbox
        IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
        codeTextbox.SendKeys("Test Code");

        //Type description into the Description textbox
        IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
        descriptionTextbox.SendKeys("Test Description");

        //Type price into the Price textbox
        IWebElement priceTagOverLap = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
        priceTagOverLap.Click();
        
        IWebElement priceTextbox = driver.FindElement(By.Id("Price"));
        priceTextbox.SendKeys("200");

        //Click on "Save" button
        IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
        saveButton.Click();
        Thread.Sleep(3000);

        //CHECK IF THE TIME RECORD HAS BEEN CREATED SUCCESSFULLY

        //Navigate to the last page of Time and Material
        IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
        goToLastPageButton.Click();

        IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

        if (newCode.Text == "Test Code")
        {
            Console.WriteLine("Time record created successfully");
        }
        else
        {
            Console.WriteLine("Time record have not been created");
        };


    }
}