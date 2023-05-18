using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoqaproper.demoqaproper.Elements
{
    internal class WebTables : CorePage
    {

        #region locators
        By AddnewRecord = By.Id("addNewRecordButton");
        By firstnameTxt = By.Id("firstName");
        By lastnameTxt = By.Id("lastName");
        By emailTxt = By.Id("userEmail");
        By ageTxt = By.Id("age");
        By SalaryTxt = By.Id("salary");
        By departmentTxt = By.Id("department");
        By SubmitBtn = By.Id("submit");
        #endregion
        public void WebTablesMethod(string url, string firstname, string lastname, string email, string age, string Salary, string department)
        {
            driver.Url = url;
            driver.FindElement(AddnewRecord).Click();
            driver.FindElement(firstnameTxt).SendKeys(firstname);
            driver.FindElement(lastnameTxt).SendKeys(lastname);
            driver.FindElement(emailTxt).SendKeys(email);
            driver.FindElement(ageTxt).SendKeys(age);
            driver.FindElement(SalaryTxt).SendKeys(Salary);
            driver.FindElement(departmentTxt).SendKeys(department);
            driver.FindElement(SubmitBtn).Click();
        }
    
    }
}
