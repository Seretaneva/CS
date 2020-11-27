using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http:www.youtube.com");
            driver.Manage().Window.Maximize();
            object p = driver.Manage().Timeouts().ImplicitWait;
            driver.FindElement(By.Name("search_query")).Click();
            driver.FindElement(By.Name("search_query")).SendKeys("computer");
            driver.FindElement(By.Id("search-icon-legacy")).Click();
            bool result = driver.FindElement(By.Id("logo-icon-container")).Displayed;
            Console.WriteLine($"The result is displayed!!! + {result}");
        }
    }
}
