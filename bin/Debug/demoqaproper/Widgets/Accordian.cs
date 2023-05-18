using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace demoqaproper.demoqaproper.Widgets
{
    internal class Accordian : CorePage
    {
        By firstheader = By.Id("section1Heading");
        By secondheader = By.Id("section2Heading");
        By thirdheader = By.Id("section3Heading");

        public void AccordianMethods(string url)
        {
            driver.Url = url;
            driver.FindElement(firstheader).Click();
            driver.FindElement(secondheader).Click();
            driver.FindElement(thirdheader).Click();
            Thread.Sleep(4000);
        }
    }
}
