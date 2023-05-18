using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;

namespace demoqaproper.demoqaproper.Forms
{
    internal class Forms : CorePage
    {
        By firstName = By.Id("firstName");
        By lastName = By.Id("lastName");
        By emailTxt = By.Id("userEmail");
        By genderradiobtn = By.CssSelector("#genterWrapper > div.col-md-9.col-sm-12 > div:nth-child(1) > label");
        By phonenumberTxt = By.Id("userNumber");
        By dobTxt = By.Id("dateOfBirthInput");
        By SubjectTxt = By.Id("subjectsInput");
        By hobbiesradiobtn1 = By.CssSelector("#hobbiesWrapper > div.col-md-9.col-sm-12 > div:nth-child(1)");
        By clickonChooseFile= By.ClassName("form-control-file");
        By currentaddress = By.Id("currentAddress");
        By SelectState = By.Id("react-select-3-input");
        By SelectCity = By.CssSelector("#react-select-4-input");
        By Btnn = By.Id("submit");
        public void FormsEvaluation(string url,string fname, string lname, string email, string phonenumber, string dob, string subject, string filePath, string currentaddres, string state, string city)
        {
            driver.Url = url;
            driver.FindElement(firstName).SendKeys(fname);
            driver.FindElement(lastName).SendKeys(lname);
            driver.FindElement(emailTxt).SendKeys(email);
            driver.FindElement(genderradiobtn).Click();
            driver.FindElement(phonenumberTxt).SendKeys(phonenumber);
            driver.FindElement(phonenumberTxt).SendKeys(Keys.Tab);
            driver.FindElement(dobTxt).SendKeys(dob);
            driver.FindElement(dobTxt).SendKeys(Keys.Enter);
            driver.FindElement(SubjectTxt).SendKeys(subject);
            driver.FindElement(SubjectTxt).SendKeys(Keys.Enter);
            driver.FindElement(hobbiesradiobtn1).Click();
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("window.scrollBy(0,800)");
            Thread.Sleep(3000);
            driver.FindElement(clickonChooseFile).SendKeys(filePath);
            driver.FindElement(currentaddress).SendKeys(currentaddres);
            driver.FindElement(SelectState).SendKeys(state);
            driver.FindElement(SelectState).SendKeys(Keys.Enter);
            driver.FindElement(SelectCity).SendKeys(city);
            driver.FindElement(SelectCity).SendKeys(Keys.Enter);
            driver.FindElement(SelectCity).SendKeys(Keys.Tab);
            driver.FindElement(SelectCity).SendKeys(Keys.Enter);
/*            IJavaScriptExecutor jsee = (IJavaScriptExecutor)driver;
            IWebElement footerElement = driver.FindElement(By.XPath("/ html / body / div[2] / footer"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].style.display = 'none';", footerElement);*/
        }
    }
}
