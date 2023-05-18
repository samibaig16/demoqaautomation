using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace demoqaproper.demoqaproper.Widgets
{
    internal class Tabs : CorePage
    {
        By firsttab = By.XPath("//a[@id='demo-tab-what']");
        By secondtab = By.XPath("//a[@id='demo-tab-origin']");
        By thirdtab = By.XPath("//a[@id='demo-tab-use']");
        By fourthtab = By.XPath("//a[@id='demo-tab-more']");
        public void TabsPage(string url)
        {
            driver.Url = url;
            driver.FindElement(firsttab).Click();
            driver.FindElement(secondtab).Click();
            driver.FindElement(thirdtab).Click();
            actions.Click(driver.FindElement(fourthtab)).Click();
        }
    }
}
