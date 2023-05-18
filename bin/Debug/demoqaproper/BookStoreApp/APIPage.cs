using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace demoqaproper.demoqaproper.BookStoreApp
{
    internal class APIPage : CorePage
    {
        /*    By postapi = By.XPath("//div[@id='operations-BookStore-BookStoreV1BooksPost']");*/
        By apitestingetab = By.XPath("/html/body/div[2]/div/div/div[2]/div[1]/div/div/div[6]/div/ul/li[4]/span");
        By textarea = By.XPath("//textarea[@class='body-param__text']");
        By tryitout = By.XPath("//button[@class='btn try-out__btn']");
        By execute = By.XPath("//button[@class='btn execute opblock-control__btn']");
        By userName = By.Id("userName");
        By password = By.Id("password");
        By loginbtn = By.Id("login");
        public void postapi_testing(string url)
        {
            driver.Url = url;
            driver.FindElement(userName).SendKeys("samibaig17821106216199");
            driver.FindElement(password).SendKeys("Samisami@16");
            driver.FindElement(loginbtn).Click();
            driver.FindElement(apitestingetab).Click();
            Thread.Sleep(6000);
            var button = driver.FindElement(By.CssSelector("button.opblock-summary-control[aria-label='post ​/Account​/v1​/Authorized']"));
            button.Click();
            int maxAttempts = 3;
            int attempt = 1;
            bool buttonClicked = false;

            while (attempt <= maxAttempts)
            {
                try
                {
                    var buttonElement = driver.FindElement(By.CssSelector("div.opblock-section button.btn.try-out__btn"));
                    buttonElement.Click();
                    buttonClicked = true;
                    break; // Exit the loop if the button is clicked successfully
                }
                catch (NoSuchElementException)
                {
                    // Element not found, continue to the next attempt
                }

                attempt++;
                Thread.Sleep(1000); // Wait for 1 second before the next attempt
            }

            if (!buttonClicked)
            {
                // Button click failed after multiple attempts
                // Handle the failure case or throw an exception
            }
            driver.FindElement(textarea).Clear();
            driver.FindElement(textarea).SendKeys("{\r\n  \"userName\": \"samibaig166\",\r\n  \"password\": \"samibaig001\"\r\n}");
            driver.FindElement(execute).Click();
            Thread.Sleep(2000);
            button.Click();
            var button2 = driver.FindElement(By.CssSelector("button.opblock-summary-control[aria-label='get ​/Account​/v1​/User​/{UUID}']"));
            button2.Click();
            while (attempt <= maxAttempts)
            {
                try
                {
                    var buttonElement = driver.FindElement(By.CssSelector("div.opblock-section button.btn.try-out__btn"));
                    buttonElement.Click();
                    buttonClicked = true;
                    break; // Exit the loop if the button is clicked successfully
                }
                catch (NoSuchElementException)
                {
                    // Element not found, continue to the next attempt
                }

                attempt++;
                Thread.Sleep(1000); // Wait for 1 second before the next attempt
            }

            if (!buttonClicked)
            {
                // Button click failed after multiple attempts
                // Handle the failure case or throw an exception
            }
            var inputElement = driver.FindElement(By.CssSelector("td.parameters-col_description input[type='text'][placeholder='UserId']"));
            inputElement.SendKeys("string");
            driver.FindElement(execute).Click();
            Thread.Sleep(2000);
            button2.Click();
            var getter = driver.FindElement(By.CssSelector("button.opblock-summary-control[aria-label='delete ​/Account​/v1​/User​/{UUID}']"));
            getter.Click();
            while (attempt <= maxAttempts)
            {
                try
                {
                    var buttonElement = driver.FindElement(By.CssSelector("div.opblock-section button.btn.try-out__btn"));

                    buttonElement.Click();
                    buttonClicked = true;
                    break; // Exit the loop if the button is clicked successfully
                }
                catch (NoSuchElementException)
                {
                    // Element not found, continue to the next attempt
                }

                attempt++;
                Thread.Sleep(1000); // Wait for 1 second before the next attempt
            }

            if (!buttonClicked)
            {
                // Button click failed after multiple attempts
                // Handle the failure case or throw an exception
            }
          /*  driver.FindElement(By.CssSelector("div.opblock-section button.btn.try-out__btn")).Click();*/
            var getElement = driver.FindElement(By.CssSelector("td.parameters-col_description input[placeholder='UserId']"));
            getElement.SendKeys("string");
            driver.FindElement(execute).Click();
            /*          driver.FindElement(By.ClassName("btn execute opblock-control__btn")).Click();*/
            /*            driver.FindElement(execute).Click();*/
        }
        }
    }

           
