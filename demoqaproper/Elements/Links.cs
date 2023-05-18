using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoqaproper.demoqaproper.Elements
{
    internal class Links : CorePage
    {
        /*      By ClickonElementsTab = By.CssSelector(".avatar.mx-auto.white");*/
        /*        By LinkOptionClick = By.Id("item-5");*/
        By secondlink = By.CssSelector("#created");
        By simplelinkClick = By.CssSelector("#simpleLink");
        public void LinksMethodPage(string url)
        {
            driver.Url= url;
/*            driver.FindElement(ClickonElementsTab).Click();*/
/*            driver.FindElement(LinkOptionClick).Click();*/
            driver.FindElement(simplelinkClick).Click();
        }
        public void LinksMethodPageMethodTwo(string url)
        {
            driver.Url= url;
            driver.FindElement(secondlink).Click();
        }
    }
}
