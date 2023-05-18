using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace demoqaproper.demoqaproper.Elements
{
    internal class DynamicProperties : CorePage
    {
        By firstButton = By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/div[2]/div[2]/div[2]/button[1]");
        By secondButton = By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/div[2]/div[2]/div[2]/button[2]");
        By thirdButton = By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/div[2]/div[2]/div[2]/button[3]");
        public void DynamicPropertiesTest(string url)
        {
            driver.Url = url;
            driver.FindElement(firstButton).Click();
            Thread.Sleep(6000);
            driver.FindElement(thirdButton).Click();
            Thread.Sleep(6000);
            driver.FindElement(secondButton).Click();
            Thread.Sleep(6000);
        }
        }
    }

