using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace demoqaproper.demoqaproper.Elements
{
    internal class TextBox : CorePage
    {
        By fullnameTxt = By.Id("userName");
        By emailTxt = By.Id("userEmail");
        By curraddressTxT = By.Id("currentAddress");
        By permaddressTxT = By.Id("permanentAddress");
        By Btnn = By.Id("submit");
        public void TextBoxMethod(string url, string user, string email, string curraddress, string permaddress)
        {
            driver.Url = url;
            driver.FindElement(fullnameTxt).SendKeys(user);
            driver.FindElement(emailTxt).SendKeys(email);
            driver.FindElement(curraddressTxT).SendKeys(curraddress);
            driver.FindElement(permaddressTxT).SendKeys(permaddress);
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("window.scrollBy(0,300)");
            driver.FindElement(Btnn).Click();
        }

    }
}
