using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace selenium
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            driver.Navigate().GoToUrl("https://www.balaan.co.kr");


            driver.FindElement(By.ClassName("search_input")).SendKeys("구찌" + Keys.Enter);

            Thread.Sleep(300);

            var element = driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div[2]/div[2]/div[3]/ul/li[1]/div[1]"));
          

            element.Click();
            Console.ReadKey();

            //driver.Quit();
        }

    }

}

