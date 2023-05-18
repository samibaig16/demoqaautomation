using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoqaproper.demoqaproper.AFW
{
    
    internal class BrowserWIndows : CorePage
    {
        By firstbtn = By.Id("tabButton");
        By secondBtn = By.Id("windowButton");
        By thirdBtn = By.Id("messageWindowButton");
        public void BrowserWindowsFirstButton(string url)
        {
            driver.Url = url;
            driver.FindElement(firstbtn).Click();

        }   
        public void BrowserWindowsSecondButton(string url)
        {
            driver.Url = url;
            driver.FindElement(secondBtn).Click();

        } 
        public void BrowserWindowsThirdButton(string url)
        {
            driver.Url = url;
            driver.FindElement(thirdBtn).Click();

        }
       
    }
}
