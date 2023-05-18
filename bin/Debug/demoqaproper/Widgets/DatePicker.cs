using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace demoqaproper.demoqaproper.Widgets
{
    internal class DatePicker : CorePage
    {

        public void DatePickerFirstMethod(string url)
        {
            driver.Url = url;
            IWebElement datepickerInput = driver.FindElement(By.Id("datePickerMonthYearInput"));

            // Input field par click karein
            datepickerInput.Click();

            // Year dropdown element ko dhoondein
            IWebElement yearDropdown = driver.FindElement(By.CssSelector(".react-datepicker__year-select"));

            // Year dropdown se "2022" select karein
            SelectElement yearSelect = new SelectElement(yearDropdown);
            yearSelect.SelectByText("2002");

            // Month dropdown element ko dhoondein
            IWebElement monthDropdown = driver.FindElement(By.CssSelector(".react-datepicker__month-select"));

            // Month dropdown se "June" select karein
            SelectElement monthSelect = new SelectElement(monthDropdown);
            monthSelect.SelectByText("June");

            // Days mein se "16" select karein
            IWebElement dayCell = driver.FindElement(By.CssSelector(".react-datepicker__day--016"));
            dayCell.Click();

    
        }
        public void DatePickerSecondMethodd(string url)
        {
            driver.Url = url;
            driver.FindElement(By.Id("dateAndTimePickerInput")).Click();
            var DateInput = driver.FindElement(By.Id("dateAndTimePickerInput"));
            DateInput.Click();

            // Wait for 2 seconds to see the selected options
            Thread.Sleep(2000);
            IWebElement monthDropdown = driver.FindElement(By.CssSelector(".react-datepicker__month-read-view"));
            monthDropdown.Click();

            // Find the specific month option (e.g., June) and click it
            IWebElement monthOption = driver.FindElement(By.XPath("//div[@class='react-datepicker__month-option' and text()='June']"));
            monthOption.Click();

            // Find the year dropdown and click it
            IWebElement yearDropdown = driver.FindElement(By.CssSelector(".react-datepicker__year-read-view"));
            yearDropdown.Click();

            // Find the previous navigation button
            IWebElement previousButton = driver.FindElement(By.CssSelector(".react-datepicker__navigation--years-previous"));

            // Click the previous button until the desired year (2002) is visible
            while (!driver.PageSource.Contains("2002"))
            {
                previousButton.Click();
            }

            // Find the specific year option (e.g., 2002) and click it
            IWebElement yearOption = driver.FindElement(By.XPath("//div[@class='react-datepicker__year-option' and text()='2002']"));
            yearOption.Click();
            // Find the day row containing the desired day (e.g., 16)
            IWebElement dayRow = driver.FindElement(By.CssSelector(".react-datepicker__week"));

            // Find the specific day option (e.g., 16) and click it
            IWebElement dayOption = dayRow.FindElement(By.XPath("//div[text()='16']"));
            dayOption.Click();

            IWebElement timeContainer = driver.FindElement(By.CssSelector(".react-datepicker__time-container"));

            // Find the specific time option (e.g., 07:00) and click it
            IWebElement timeOption = timeContainer.FindElement(By.XPath("//li[text()='17:15']"));
            timeOption.Click();

            /*            DateInput.Clear();
                        actions.KeyDown(Keys.Control).SendKeys("a").KeyUp(Keys.Control).SendKeys(Keys.Backspace).Perform();  // Clear the text field
                        actions.SendKeys("June 16 2002").Perform();  // Enter the desired value

                        driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div[1]/div[2]/div[2]/div[2]/div/div/div[2]/div[1]/div[2]/div[2]/select")).SendKeys("2002");*/

        }

    }
}
