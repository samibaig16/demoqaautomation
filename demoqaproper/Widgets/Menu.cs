using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoqaproper.demoqaproper.Widgets
{
    internal class Menu : CorePage

    {
        By firstmenu = By.XPath("//*[@id=\"nav\"]/li[1]/a");
        By secondmenu = By.XPath("//*[@id=\"nav\"]/li[2]/a");
        By firstsubmenu = By.XPath("//*[@id=\"nav\"]/li[2]/ul/li[1]/a");
        By secondsubmenu = By.XPath("//*[@id=\"nav\"]/li[2]/ul/li[2]/a");
        By sublist = By.XPath("//*[@id=\"nav\"]/li[2]/ul/li[3]/a");
        By firstsublistitem = By.XPath("//*[@id=\"nav\"]/li[2]/ul/li[3]/ul/li[1]/a");
        By secondsublistitem = By.XPath("//*[@id=\"nav\"]/li[2]/ul/li[3]/ul/li[2]/a");
        By thirdmenu = By.XPath("//*[@id=\"nav\"]/li[3]/a");
        public void MenuPageFirst(string url)
        {
            driver.Url = url;
            driver.FindElement(firstmenu).Click();
        }
        public void MenuPageSecond(string url)
        {
            driver.Url = url;
            actions.MoveToElement(driver.FindElement(secondmenu))
                .Build()
                .Perform();
            actions.Reset();
            actions.Click(driver.FindElement(firstsubmenu)).Click()
                .Build().Perform();
            actions.Reset();
        }
        public void MenuPageThird(string url)
        {
            driver.Url = url;
            actions.MoveToElement(driver.FindElement(secondmenu))
                .Build()
                .Perform();
            actions.Reset();
            actions.Click(driver.FindElement(secondsubmenu)).Click()
                .Build().Perform();
        }
        public void MenuPageFourth(string url)
        {
            driver.Url = url;
            actions.MoveToElement(driver.FindElement(secondmenu))
                .Build()
                .Perform();
            actions.Reset();
            actions.MoveToElement(driver.FindElement(sublist)).Build().Perform();
            actions.Reset();
            actions.Click(driver.FindElement(firstsublistitem)).Click()
                .Build().Perform();
            actions.Reset();
        }
        public void MenuPageFiveth(string url)
        {
            driver.Url = url;
            actions.MoveToElement(driver.FindElement(secondmenu))
                .Build()
                .Perform();
            actions.Reset();
            actions.MoveToElement(driver.FindElement(sublist)).Build().Perform();
            actions.Reset();
            actions.Click(driver.FindElement(secondsublistitem)).Click()
       .Build().Perform();
            actions.Reset();
        }
        public void MenuPageSixth(string url)
        {
            driver.Url = url;
            driver.FindElement(thirdmenu).Click();
        }
    }
}
