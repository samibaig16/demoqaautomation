using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoqaproper.demoqaproper.Widgets
{
    internal class ToolTips : CorePage
    {
        By button1 = By.Id("toolTipButton");
        By button2 = By.XPath("//input[@id='toolTipTextField']");
        By button3 = By.PartialLinkText("Contrary");
        public void tooltips(string url)
        {
            driver.Url = url;
            actions.MoveToElement(driver.FindElement(button1))
                .Build()
                .Perform();
            actions.Reset();
            actions.MoveToElement(driver.FindElement(button2))
                .Build()
                .Perform();
            actions.Reset();
            actions.MoveToElement(driver.FindElement(button3))
                .Build()
                .Perform();

        }
    }
}
