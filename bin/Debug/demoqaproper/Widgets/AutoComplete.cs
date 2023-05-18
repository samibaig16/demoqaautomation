using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demoqaproper.demoqaproper.Widgets
{
    internal class AutoComplete : CorePage
    {
        By firstbox = By.Id("autoCompleteMultipleInput");
        By secondbox = By.Id("autoCompleteSingleInput");
        public void AutoCompleteMultiple(string url)
        {

            driver.Url = url;
            driver.FindElement(firstbox).Click();
            driver.FindElement(firstbox).SendKeys("Blue");
            Thread.Sleep(500);
            SendKeys.SendWait("{ENTER}");
            driver.FindElement(firstbox).SendKeys("Voilet");
            Thread.Sleep(500);
            SendKeys.SendWait("{ENTER}");
            driver.FindElement(firstbox).SendKeys("Purple");
            Thread.Sleep(500);
            SendKeys.SendWait("{ENTER}");
            driver.FindElement(firstbox).SendKeys("red");
            Thread.Sleep(500);
            SendKeys.SendWait("{ENTER}");




        }
        public void AutoCompleteSingle(string url)
        {
            driver.Url = url;
            driver.FindElement(secondbox).SendKeys("Blue");
            SendKeys.SendWait("{ENTER}");
        }

    }
}
