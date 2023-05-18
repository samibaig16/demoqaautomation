using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoqaproper.demoqaproper.Widgets
{
    internal class Resizable : CorePage
    {
        By sizecorner = By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div[1]/div/span");
        By secondsizecorner = By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div[2]/div/span");
        public void ResizablePage(string url)
        {
            driver.Url = url;
            actions.ClickAndHold(driver.FindElement(sizecorner))
                .MoveByOffset(150, 0)
                .Build()
                .Perform();
            actions.Reset();

            actions.ClickAndHold(driver.FindElement(secondsizecorner))
                .MoveByOffset(150, 0)
                .Build()
                .Perform();
            actions.Reset();

        }
    }
}
