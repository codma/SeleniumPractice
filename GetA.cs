using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace selenium
{
    public class GetA
    {
        public void GetUrl(string url)
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            driver.Navigate().GoToUrl("https://www.balaan.co.kr");


            //driver.FindElement(By.ClassName("search_input")).SendKeys("구찌");


            //driver.FindElement(By.ClassName("production-feed__title__number"));



            //driver.Quit();






        }
    }
}

