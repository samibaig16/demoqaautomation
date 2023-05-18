using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq; 
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace demoqaproper.demoqaproper.Elements
{
    internal class CheckBox : CorePage
    {
        By ClickRealBox = By.TagName("path");
        
        public void CheckBoxTest(string url)
        {
            driver.Url = url;
            driver.FindElement(ClickRealBox).Click();

        }
    }
}

