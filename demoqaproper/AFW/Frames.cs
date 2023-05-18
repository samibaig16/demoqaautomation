using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace demoqaproper.demoqaproper.AFW
{
    internal class Frames : CorePage
    {
        By element = By.Id("sampleHeading");
        /*       By heading = By.XPath("//h1[@id='sampleHeading']");*/
        public void FramesPage(string url)
        {
            driver.Url = url;
            // Find the element by its ID
            // Switch to the iframe
            // Switch to the iframe
            IWebElement frame = driver.FindElement(By.Id("frame1"));
/*            By element = By.Id("sampleHeading");*/
            driver.SwitchTo().Frame(frame);

            // Find the element within the iframe
            IWebElement element = driver.FindElement(By.Id("sampleHeading"));

            // Perform a right-click on the element
            actions.DoubleClick(element).Perform();
            actions.KeyDown(Keys.Control).SendKeys("a").KeyUp(Keys.Control).Perform();

            // Switch back to the default content
            // Select the text from right-click to the left
            /*            actions.SendKeys(Keys.Shift).SendKeys(Keys.Home).Perform();*/

            // Switch back to the default content
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(1000);
            IWebElement frame2 = driver.FindElement(By.Id("frame2"));
            driver.SwitchTo().Frame(frame2);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0, 300);");

            IWebElement element2 = driver.FindElement(By.Id("sampleHeading"));

            // Perform a right-click on the element
            actions.DoubleClick(element2).Perform();

            /*            actions.ClickAndHold(driver.FindElement(element))
                              *//* .MoveByOffset(0, 70)*//*
                               .MoveByOffset(0, 100)
                               .Build()
                               .Perform();
                        actions.Reset();*/



        }
    }
}
