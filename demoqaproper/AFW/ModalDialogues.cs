using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace demoqaproper.demoqaproper.AFW
{
    internal class ModalDialogues : CorePage
    {
        By firstBtn = By.Id("showSmallModal");
        By secondBtn = By.Id("showLargeModal");

        public void ModalDialoguessFirstButton(string url)
        {
            driver.Url = url;
            driver.FindElement(firstBtn).Click();
            By modalFooterLocator = By.CssSelector(".modal-footer");
            IWebElement modalFooter = driver.FindElement(modalFooterLocator);

            // Find the Close button within the modal footer
            By closeButtonLocator = By.Id("closeSmallModal");
            IWebElement closeButton = modalFooter.FindElement(closeButtonLocator);

            // Use JavaScript Executor to click the Close button
            Thread.Sleep(1000);
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
            jsExecutor.ExecuteScript("arguments[0].click();", closeButton);

        }  
        public void ModalDialoguessSecondButton(string url)
        {
            driver.Url = url;
            driver.FindElement(secondBtn).Click();
            By modalFooterLocator = By.CssSelector(".modal-footer");
            IWebElement modalFooter = driver.FindElement(modalFooterLocator);

            // Find the Close button within the modal footer
            By closeButtonLocator = By.Id("closeLargeModal");
            IWebElement closeButton = modalFooter.FindElement(closeButtonLocator);
            Thread.Sleep(1000);
            // Use JavaScript Executor to click the Close button
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
            jsExecutor.ExecuteScript("arguments[0].click();", closeButton);
        }

        }
    }

