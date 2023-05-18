using EllipticCurve;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demoqaproper.demoqaproper.BookStoreApp
{
    internal class BookstorePage : CorePage
    {
        By firstbook = By.XPath("//a[@href='/books?book=9781449325862']");
        By secondbook = By.XPath("//a[@href='/books?book=9781449331818']");
        By thirdbook = By.XPath("//a[@href='/books?book=9781449337711']");
        By addbutton = By.XPath("//button[@id='addNewRecordButton']");
        By addtoyourcollection = By.XPath("//div[@class='text-right fullButton']");
        By returntobookstore = By.XPath("//div[@class='text-left fullButton']");
        By backtostorebtn = By.XPath("//button[@id='addNewRecordButton']");
        By userName = By.Id("userName");
        By password = By.Id("password");
        By loginbtn = By.Id("login");
        By bookstoretab = By.XPath("/html/body/div[2]/div/div/div[2]/div[1]/div/div/div[6]/div/ul/li[2]/span");
        By username2 = By.Id("userName");
        By password2 = By.Id("password");
        By login3 = By.Id("login");
        By buttonLocator = By.XPath("//div[@class='text-right button di']/button");
        By deletebuttonLocator = By.XPath("//div[@class='text-center button']/button");
        By deleteAllBooksButton = By.XPath("//button[contains(text(), 'Delete All Books')]");
        public void ProfilePage_AddBookToYourCollection(string url)
        {
            driver.Url = url;
            int maxWaitTimeInSeconds = 10;
            int waitIntervalInMilliseconds = 500;
            int elapsedTimeInMilliseconds = 0;
            while (elapsedTimeInMilliseconds < (maxWaitTimeInSeconds * 1000))
            {
                try
                {
                    IWebElement linkElement = driver.FindElement(By.CssSelector("#see-book-Git\\ Pocket\\ Guide > a"));


                    if (linkElement.Displayed)
                    {
                        linkElement.Click();
                        break; // Exit the loop if the element is clicked successfully
                    }
                }
                catch (NoSuchElementException)
                {
                    // Element not found, continue waiting
                }

                Thread.Sleep(waitIntervalInMilliseconds);
                elapsedTimeInMilliseconds += waitIntervalInMilliseconds;
            }
            driver.FindElement(loginbtn).Click();
            driver.FindElement(userName).SendKeys("samibaig17821106216199");
            driver.FindElement(password).SendKeys("Samisami@16");
            driver.FindElement(loginbtn).Click();
            Thread.Sleep(2000);
            driver.FindElement(addtoyourcollection).Click();
            Thread.Sleep(1000);
            SendKeys.SendWait("{ENTER}");
        }
        public void ClickonProfileandDeleteAllbooks(string url)
        {
            driver.Url = url;
            driver.FindElement(username2).SendKeys("samibaig17821106216199");
            driver.FindElement(password2).SendKeys("Samisami@16");
            driver.FindElement(login3).Click();
            /*            driver.FindElement(By.Id("item-3")).Click();*/
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(driver =>
            {
                try
                {
                    IWebElement button = driver.FindElement(buttonLocator);
                    return button.Displayed && button.Enabled;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            });

            // Click on the button
            driver.FindElement(buttonLocator).Click();
            By modalFooterLocator = By.CssSelector(".modal-footer");
            IWebElement modalFooter = driver.FindElement(modalFooterLocator);

            // Find the OK button within the modal footer
            By okButtonLocator = By.Id("closeSmallModal-ok");
            IWebElement okButton = modalFooter.FindElement(okButtonLocator);
            // Use JavaScript Executor to click the OK button
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
            jsExecutor.ExecuteScript("arguments[0].click();", okButton);
            Thread.Sleep(1000);
            SendKeys.SendWait("{ENTER}");
        }
        public void DeleteAccountButton(string url)
        {
            driver.Url = url;
            driver.FindElement(username2).SendKeys("samitester");
            driver.FindElement(password2).SendKeys("Samitester123456789@");
            driver.FindElement(login3).Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(driver =>
            {
                try
                {
                    IWebElement button = driver.FindElement(deletebuttonLocator);
                    return button.Displayed && button.Enabled;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            });
            driver.FindElement(deletebuttonLocator).Click();
            By modalFooterLocator = By.CssSelector(".modal-footer");
            IWebElement modalFooter = driver.FindElement(modalFooterLocator);

            // Find the OK button within the modal footer
            By okButtonLocator = By.Id("closeSmallModal-ok");
            IWebElement okButton = modalFooter.FindElement(okButtonLocator);

            // Use JavaScript Executor to click the OK button
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
            jsExecutor.ExecuteScript("arguments[0].click();", okButton);
            SendKeys.SendWait("{ENTER}");
        }
    }
}
    
