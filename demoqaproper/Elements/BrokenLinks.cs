using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demoqaproper.demoqaproper.Elements;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace demoqaproper.demoqaproper.Elements
{
    internal class BrokenLinks : CorePage
    {
        By ValidLink = By.CssSelector("div.body-height:nth-child(2) div.container.playgound-body div.row div.col-12.mt-4.col-md-6:nth-child(2) div:nth-child(2) > a:nth-child(10)");
        By Brokenlink = By.CssSelector("div.body-height:nth-child(2) div.container.playgound-body div.row div.col-12.mt-4.col-md-6:nth-child(2) div:nth-child(2) > a:nth-child(14)");
        [TestMethod]
        public void BrokenValidLink(string url)
        {
            driver.Url = url;
            driver.FindElement(ValidLink).Click();

        }
        [TestMethod]
        public void BrokenLink(string url)
        {
            driver.Url= url;
            driver.FindElement(Brokenlink).Click();
        }
    }
}
