using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoqaproper.demoqaproper.Widgets
{
    internal class SelectPage : CorePage
    {

        public void SelectValue(string url)
        {
            driver.Url = url;
            var dropdown = driver.FindElement(By.CssSelector("#withOptGroup"));
            dropdown.Click();
            actions.SendKeys(Keys.ArrowDown).SendKeys(Keys.Enter)
            .Build()
            .Perform();
            actions.Reset();
        }
        public void SelectOne(string url)
        {
            driver.Url = url;
            var dropdown = driver.FindElement(By.Id("selectOne"));
            dropdown.Click();
            actions.SendKeys(Keys.ArrowDown).SendKeys(Keys.Enter)
                .Build()
                .Perform();
                actions.Reset();
        }
        public void OldStyleSelectPage(string url)
        {
            driver.Url = url;
            var selectoldstyle = driver.FindElement(By.Id("oldSelectMenu"));
            var selectDropDown = new SelectElement(selectoldstyle);
            selectDropDown.SelectByText("Green");
            selectDropDown.SelectByValue("3");
            selectDropDown.SelectByIndex(5);
        }
        public void MultiSelectDropDownn(string url)
        {
            driver.Url = url;
            var dropdown = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div[7]/div/div/div"));
            dropdown.Click();
/*            var selectitems = new SelectElement(dropdown);*/
            actions.SendKeys(Keys.Enter)
            .SendKeys(Keys.Enter)
            .SendKeys(Keys.Enter)
            .SendKeys(Keys.Enter)
            .Build()
            .Perform();
            actions.Reset();
        }
        public void StandardMultiSelect(string url)
        {
            driver.Url = url;
            var dropdown = driver.FindElement(By.Id("cars"));
            dropdown.Click();
            var selectitems = new SelectElement(dropdown);
            selectitems.SelectByValue("volvo");
            selectitems.SelectByValue("saab");
            selectitems.SelectByValue("opel");
            selectitems.SelectByValue("audi");
        }
    }
}
        