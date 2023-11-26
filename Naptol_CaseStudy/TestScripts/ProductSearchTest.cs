﻿using Naptol_CaseStudy.Pageobjects;
using Naptol_CaseStudy.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naptol_CaseStudy.TestScripts
{
    [TestFixture]    
    
    internal class ProductSearchTest:Corecodes
    {

        [Test, Order(1)]
        public void SearchTest()
        {
            var naptolhomepage = new NaptolHomePages(driver);

            if (!driver.Url.Equals("https://www.naaptol.com/"))
            {
                driver.Navigate().GoToUrl("https://www.naaptol.com/");
            }
            naptolhomepage.SearchTextFunction("eyewear");
            var enterkey = naptolhomepage.EnterFunction();
            // Assert.That(driver.Url.Contains(""))

            var selectPage = enterkey.SelectProduct();

            List<string> lswindow = driver.WindowHandles.ToList();
            driver.SwitchTo().Window(lswindow[1]);

            Thread.Sleep(2000);
            selectPage.Sizeselect();

            Thread.Sleep(2000);

            selectPage.BuyNowButtonClicked();
            Thread.Sleep(2000);
            selectPage.CloseButtonClicked();
            Thread.Sleep(2000);



        }
    }
}