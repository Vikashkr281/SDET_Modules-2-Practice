using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Amazone
    {
        IWebDriver driver;
        public void ChromeInsilizerTest()
        {
          driver=new ChromeDriver();
            driver.Url = "https://www.amazon.com/";
            
        }
        public void TestTitle()
        {
            Assert.AreEqual("Amazon.com. Spend less. Smile more.", driver.Title);
          
        }
        public void Close()
        {
            driver.Close();
        }
        public void TestUrl() 
        {
            Assert.That(driver.Url.Contains (".com"));
        }
    }
}
