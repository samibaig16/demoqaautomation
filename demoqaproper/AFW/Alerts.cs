using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demoqaproper.demoqaproper.AFW
{
    internal class Alerts : CorePage
    {
        By firstButton = By.Id("alertButton");
        By secondButton = By.Id("timerAlertButton");
        By thirdButton = By.Id("confirmButton");
        By fourthButton = By.Id("promtButton");

        public void AlertfirstButtonMethod(string url)
        {
            driver.Url = url;
            driver.FindElement(firstButton).Click();
            SendKeys.SendWait("{ENTER}");
        }
        public void AlertsecondButtonMethod(string url)
        {
            driver.Url = url;
            driver.FindElement(secondButton).Click();
            Thread.Sleep(6000);
            SendKeys.SendWait("{ENTER}");
        }
        public void AlertthirdButtonMethod(string url)
        {
            driver.Url = url;
            driver.FindElement(thirdButton).Click();
            SendKeys.SendWait("{ENTER}");
            Thread.Sleep(1000);
        }
        public void AlertfourthButtonMethod(string url)
        {
            driver.Url = url;
            driver.FindElement(fourthButton).Click();
            IAlert promptDialog = driver.SwitchTo().Alert();

            // Enter the desired input
            promptDialog.SendKeys("samibaig");

            // Accept the prompt dialog (click OK)
            promptDialog.Accept();
            Thread.Sleep(1000);
            /*            SendKeys.SendWait("{ENTER}");*/

        }
    }
}
