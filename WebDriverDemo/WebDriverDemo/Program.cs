using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Remote;

namespace WebDriverDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ////1) WebDriver Basics
            //// GeckoDriver added to PATH var
            //using (IWebDriver driverFF = new FirefoxDriver())
            //{
            //    driverFF.Navigate().GoToUrl("http://www.google.com");

            //    // find an element tied to google's search box
            //    IWebElement searchBox = driverFF.FindElement(By.Name("q"));
            //    // send a key string to the search box.
            //    searchBox.SendKeys("pluralsight");

            //    searchBox.Submit();

            //    //Explicit Wait
            //    WebDriverWait wait = new WebDriverWait(driverFF, TimeSpan.FromSeconds(5));
            //    //wrap our call with a wait.
            //    IWebElement imagesLink = wait.Until(d =>
            //    {
            //        var elements = driverFF.FindElements(By.ClassName("hdtb-mitem"));
            //        if (elements.Count > 0)
            //        {
            //            return elements[0];
            //        }
            //        return null;
            //    });

            // click the Images link to view pluralsight images
            //IWebElement elem = driverFF.FindElements(By.ClassName("hdtb-mitem"))[4];
            //IWebElement imagesLink = elem.FindElement(By.TagName("a"));
            //imagesLink.Click();
            //}

            //// MicrosoftDriver located in libraryPath
            //string libraryPath = "C:\\Libraries\\";
            //using (IWebDriver driverEdge = new EdgeDriver(@libraryPath))
            //{
            //    driverEdge.Navigate().GoToUrl("http://youtube.com");
            //}

            //// ChromeDriver located in libraryPath
            //using (IWebDriver driverChrome = new ChromeDriver(@libraryPath))
            //{
            //    driverChrome.Navigate().GoToUrl("http://www.cnn.com");
            //}

            //2) WebDriver Advanced + Selenium Server
            string libraryPath = "C:\\Libraries\\";
            IWebDriver driver = new ChromeDriver(libraryPath);
            //For Chrome and other web browsers not in PATH, locate the location of the driver when calling selenium server jar.
            //IWebDriver driver = new RemoteWebDriver(new Uri(@"http://localhost:4444/wd/hub"), DesiredCapabilities.Firefox());
            
            // Load TestPage.html
            driver.Url = @"file:///C:/Users/raman/Dropbox/SeleniumDemo/WebDriverDemo/WebDriverDemo/TestPage.html";

             // Get data by selecting the radio buttons
             // Cannot iterate over IWebElements
            var radioBtns = driver.FindElements(By.Name("color"));
            foreach (var radioBtn in radioBtns)
            {
                if (radioBtn.Selected)
                {
                    // get the value attribute of the radio button in the collection of buttons
                    Console.WriteLine(radioBtn.GetAttribute("value"));
                }
            }

            // Wait for the page to load, timeout after 10 seconds
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //DEBUGGING THE CODE ALSO HELPS WALKTHROUGH IT.

            IWebElement checkbox = driver.FindElement(By.Id("check1"));
            checkbox.Click();
            checkbox.Click();

            IWebElement select = driver.FindElement(By.Id("select"));

            IWebElement tomOption = select.FindElements(By.TagName("option"))[2];
            tomOption.Click();

            // Wrapper for the Select Element, in order to easily select the option to test
            // without utilizing the index
            var selectElem = new SelectElement(select);
            selectElem.SelectByText("Frank");

            IWebElement outTable = driver.FindElement(By.TagName("table"));
            IWebElement innerTable = outTable.FindElement(By.TagName("table"));
            IWebElement row = innerTable.FindElements(By.TagName("td"))[1];
            Console.WriteLine(row.Text);

            //Using XPATH - added more complexity, but lessened the code
            IWebElement rowSecond = driver.FindElement(By.XPath("/html/body/table/tbody/tr/td[2]/table/tbody/tr[2]/td"));
            Console.WriteLine(rowSecond.Text);
        }
    }
}
