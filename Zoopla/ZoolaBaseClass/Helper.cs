using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Threading;


namespace Zoopla.ZoolaBaseClass
{
    public class Helper
    {
        private static IWebDriver driver;
        private static Actions action;
        private static SelectElement select;
        private static WebDriverWait wait;
        private static ICapabilities capability;

        static Helper()
        { // Our component declaration are null at this moment
            driver = null;
            action = null;
            select = null;
            wait = null;
        }

        private static IWebDriver initialiseChrome()
        { // its private static cos we want to do cross browser testing 

            driver = new ChromeDriver();
            return driver;
        }

        private static IWebDriver initialiseFirefox()
        {
            driver = new FirefoxDriver();
            return driver;
        }


        // initialise browser(IwebDriver) for our automation. At this point driver is not null

        public static void launchBrowser(string browser)
        {
            switch (browser)
            {
                case "Chrome":
                    driver = initialiseChrome();
                    break;
                case "Firefox":
                    driver = initialiseFirefox();
                    break;
                default:
                    Console.WriteLine(browser + "is not recorgnsed: so Chrome is launch instead");
                    driver = initialiseChrome();
                    break;
            }
        }

        //Browser method will return chromedrive or FirefoxDriver 
        public static void launchUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        // delete all cookies in browser, close all browser and quite after finishin execution

        public static void closeBrowser()
        {
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Close();
            driver.Quit();
        }

        // use this method to select element by index. Firstly, select the element and then select the element index

        public static void selectByIndex(IWebElement element, int index)
        {
            select = new SelectElement(element);
            select.SelectByIndex(index);
        }

        public static void selectByValue(IWebElement element, string value)
        {
            select = new SelectElement(element);
            select.SelectByValue(value);
        }

        public static void selectByVisibleText(IWebElement element, string text)
        {
            select = new SelectElement(element);
            select.SelectByText(text);
        }

        // generic web element method for all element we need for web browser automation

        private static IWebElement getElement(By locator)
        {
            IWebElement element = null;

            // count the number of element, which is 0 atthis point
            int tryCount = 0;

            while (element == null)
            {
                // paerform this operation if it fails come out and wait for some second
                try
                {
                    element = driver.FindElement(locator);
                }

                // if it cannot find element at first time catch exeption
                catch (Exception e)
                {
                    // if element cannot be found 3 time throw an error mesage

                    if (tryCount == 3)
                    {
                        throw e;
                    }
                }
                var waitTime = new TimeSpan(0, 0, 2);
                Thread.Sleep(waitTime);

                tryCount++;
            }
            Console.WriteLine(element.ToString() + "is now retrived");
            return element;
        }

        // do the same thing for List of web element
        private static IList<IWebElement> getElements(By locator)
        {
            IList<IWebElement> element = null;
            int tryCount = 0;

            while (element == null)
            {
                try
                {
                    element = driver.FindElements(locator);
                }
                catch (Exception e)
                {
                    if (tryCount == 3)
                    {
                        throw e;
                    }

                }

                var waitTime = new TimeSpan(0, 0, 2);
                Thread.Sleep(waitTime);

                tryCount++;
            }
            Console.WriteLine(element.ToString() + " is now retrieved");
            return element;

        }

        // use these method to find element 
        public static IWebElement getElementById(string id)
        {
            By locator = By.Id(id);
            return getElement(locator);
        }

        public static IWebElement getElementByName(string name)
        {
            By locator = By.Name(name);
            return getElement(locator);
        }

        public static IWebElement getElementByCss(string cssSelector)
        {
            By locator = By.CssSelector(cssSelector);
            return getElement(locator);
        }

        public static IWebElement getElementByXPath(string xpath)
        {
            By locator = By.XPath(xpath);
            return getElement(locator);
        }

        public static IWebElement getElementByLink(string link)
        {
            By locator = By.LinkText(link);
            return getElement(locator);
        }

        public static IWebElement getElementByClassName(string className)
        {
            By locator = By.ClassName(className);
            return getElement(locator);
        }

        public static IList<IWebElement> getElementsById(string id)
        {
            By locator = By.Id(id);
            return getElements(locator);
        }

        public static IList<IWebElement> getElementsByName(string name)
        {
            By locator = By.Name(name);
            return getElements(locator);
        }

        public static IList<IWebElement> getElementsByCss(string cssSelector)
        {
            By locator = By.CssSelector(cssSelector);
            return getElements(locator);
        }

        public static IList<IWebElement> getElementsByXPath(string xpath)
        {
            By locator = By.XPath(xpath);
            return getElements(locator);
        }

        public static IList<IWebElement> getElementsByClassName(string className)
        {
            By locator = By.ClassName(className);
            return getElements(locator);
        }

        public static IList<IWebElement> getElementsByLink(string link)
        {
            By locator = By.LinkText(link);
            return getElements(locator);
        }

        public static void hover(IWebElement element)
        {
            action = new Actions(driver);
            action.MoveToElement(element).Perform();
        }


        public static void moveToElement(IWebElement element)
        {
            action = new Actions(driver);
            action.MoveToElement(element).Build().Perform();
        }
        //public static ZooplaHomePage  GivenINavigateToZooplaHomePage()
        //{
        //    launchUrl("http://www.zoopla.co.uk/");

        //    return new ZooplaHomePage();
        //}


    }
}
