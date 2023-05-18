using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoqaproper.demoqaproper.Elements
{
    internal class RadioButton : CorePage
    {
        By ClickonElementsTab = By.CssSelector(".avatar.mx-auto.white");
        By RadioBtn = By.CssSelector("#app > div > div > div.row > div.col-12.mt-4.col-md-6 > div:nth-child(2) > div:nth-child(2) > label");
        public void RadioButtonPage(string url)
        {
            driver.Url = url;
            driver.FindElement(RadioBtn).Click();
        }
    }
}
