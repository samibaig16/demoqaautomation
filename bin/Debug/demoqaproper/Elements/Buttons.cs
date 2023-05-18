using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Security.Policy;
using System.Threading;

namespace demoqaproper.demoqaproper.Elements
{
    internal class Buttons : CorePage
    {
        By doubleClickBtn = By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/div[2]/div[2]/div[2]/div[1]/button[1]");
        By rightClickBtn = By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/div[2]/div[2]/div[2]/div[2]/button[1]");
        By singleClick = By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/div[2]/div[2]/div[2]/div[3]/button[1]");

        public void ButtonsMethod(string url)
        {
            driver.Url = url;
            Actions actions = new Actions(driver);

            IWebElement doubleClickButton = driver.FindElement(doubleClickBtn);
            actions.DoubleClick(doubleClickButton).Perform();

            IWebElement rightClickButton = driver.FindElement(rightClickBtn);
            actions.ContextClick(rightClickButton).Perform();

            driver.FindElement(singleClick).Click();
        }
    }
}
