using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naptol_CaseStudy.Pageobjects
{
    internal class NaptolHomePages
    {
        IWebDriver driver;
        public NaptolHomePages(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.Id, Using = "header_search_text")]
        public IWebElement? SearchText { get; set; }
        public void SearchTextFunction(string productname)
        {
            SearchText.SendKeys(productname);

        }
        public SelectProductPages EnterFunction()
        {
            SearchText.SendKeys(Keys.Enter);
            return new SelectProductPages(driver);
        }

    }
}
