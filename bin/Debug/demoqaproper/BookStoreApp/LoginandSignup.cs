using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demoqaproper.demoqaproper.BookStoreApp
{
    internal class LoginandSignup : CorePage
    {
        By registerbtn = By.Id("newUser");
        By userName = By.Id("userName");
        By password = By.Id("password");
        By loginbtn = By.Id("login");
        //For signup
        By signupfirstname = By.XPath("//input[@placeholder='First Name']");
        By signuplastname = By.XPath("//input[@placeholder='Last Name']");
        By signupusername = By.XPath("//input[@placeholder='UserName']");
        By signuppassword = By.XPath("//input[@placeholder='Password']");
  /*      By checkbox = By.XPath("//div[@class='recaptcha-checkbox-checkmark']");*/
        By frameSelector = By.CssSelector("iframe[title='reCAPTCHA']");
        By accountregister = By.Id("register");
        public void Login_Bookstore(string url)
        {
            driver.Url = url;
            driver.FindElement(userName).SendKeys("samibaig17821106216199");
            driver.FindElement(password).SendKeys("Samisami@16");
            driver.FindElement(loginbtn).Click();
        }
        public void Signup_Bookstore(string url)
        {
            driver.Url = url;
            driver.FindElement(signupfirstname).SendKeys("Sami");
            driver.FindElement(signuplastname).SendKeys("Baig");
            driver.FindElement(signupusername).SendKeys("samibaig17821106216199117771");
            driver.FindElement(signuppassword).SendKeys("Samisami@16");
            IWebElement frameElement = driver.FindElement(frameSelector);
            driver.SwitchTo().Frame(frameElement);
            IWebElement checkbox = driver.FindElement(By.XPath("//span[@role='checkbox']"));
            checkbox.Click();
            Thread.Sleep(25000);
            driver.SwitchTo().DefaultContent();
            driver.FindElement(By.Id("register")).Click();
            Thread.Sleep(1000);
            SendKeys.SendWait("{ENTER}");
        }


    }
    }

