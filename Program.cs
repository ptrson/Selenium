using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using Selenium;

namespace Selenium
{
    class Program
    {
        static void Main(string[] args)
        {
            var driver = new FirefoxDriver()
            {
                Url = "http://localhost/selenium/index.php"
            };

            Thread.Sleep(2000);
            var element = driver.FindElementByName("imie");
            element.SendKeys("Jan");
            var element3 = driver.FindElementByName("nazwisko");
            element3.SendKeys("Kowalski");
            var element2 = driver.FindElementByName("submit");
            element2.Click();
            Thread.Sleep(5000);
            driver.Close();


        }

       
    }
}
