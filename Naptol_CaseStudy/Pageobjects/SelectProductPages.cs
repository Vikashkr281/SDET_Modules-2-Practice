using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naptol_CaseStudy.Pageobjects
{
    internal class SelectProductPages
    {
        IWebDriver? driver;
        public SelectProductPages(IWebDriver driver)
        {
            this.driver = driver ?? throw new ArgumentException(nameof(driver));
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//div[@id='productItem5' and @pid='12612074']")]
        public IWebElement Productselect { get; set; }

        public SelectedProductPages SelectProduct()
        {
            Productselect?.Click();
            return new SelectedProductPages(driver);
        }
    }
}
