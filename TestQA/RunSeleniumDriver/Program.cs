using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.PhantomJS;
using OpenQA.Selenium.Support;

namespace RunSeleniumDriver
{
    class Program
    {
        static void Main(string[] args)
        {
           
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://japonskie.ru/puzzle/");
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(2));
            IWebElement element = driver.FindElement(By.LinkText("Японские кроссворды"));
            element.Click();
            Console.Write(element);
            if (element != null)
            {
                element.Click();
            }

            
            
        }
    }
}
