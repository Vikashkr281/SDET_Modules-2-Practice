using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_14nov
{
    internal class SearchBrowser
    {
        IWebDriver driver;
        public void WebBrowser()
        {
            driver=new ChromeDriver();
            driver.Url = "http://google.com";
            Thread.Sleep(3000);
            driver.Navigate().GoToUrl("http://Yohoo.com");
            Thread.Sleep(3000);
            driver.Navigate().Back();
            Thread.Sleep(3000);
            driver.Navigate().Forward();
            Thread.Sleep(3000);
            driver.Navigate().Back();
            Thread.Sleep(3000);

        }
        public void SearchResultForDiwali()
        {
            IWebElement googleSearchBok = driver.FindElement(By.Id("APjFqb"));
            googleSearchBok.SendKeys("What's new For Diwali 2023");
            Thread.Sleep(3000);
            IWebElement gsButton = driver.FindElement(By.Name("btnK"));
            gsButton.Click();
            Thread.Sleep(3000);
            driver.Navigate().Refresh();
            Thread.Sleep(3000);

        }
        
        
        public void Closebrowser()
        {
            driver.Close();
        }
    }
}
