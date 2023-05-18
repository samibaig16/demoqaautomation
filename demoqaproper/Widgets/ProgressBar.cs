using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace demoqaproper.demoqaproper.Widgets
{
    internal class ProgressBar : CorePage
    {
/*        By startstopbutton = By.XPath("//button[@id='startStopButton']");*/

        public void ProgressBarMethod(string url)
        {
            driver.Url = url;
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            // Click the start button
            IWebElement startButton = driver.FindElement(By.Id("startStopButton"));
            startButton.Click();

            // Wait for the progress bar to reach 100%
            wait.Until(driver => driver.FindElement(By.XPath("//div[@role='progressbar']")).GetAttribute("aria-valuenow") == "100");

            // Click the reset button
            IWebElement resetButton = driver.FindElement(By.Id("resetButton"));
            resetButton.Click();
        }
    }
}








