using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace demoqaproper.demoqaproper.Widgets
{
    internal class Droppable : CorePage
    {
        By dragme = By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div/div[1]/div/div[1]");
        By source = By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div/div[1]/div/div[2]");
        By acceptbar = By.XPath("//a[@id='droppableExample-tab-accept']");
        By preventbar = By.XPath("//a[@id='droppableExample-tab-preventPropogation']");
        By acceptable = By.XPath("//div[@id='acceptable']");
        By notacceptable = By.XPath("//div[@id='notAcceptable']");
        /*        By notacceptable = By.XPath("//div[@id='notAcceptable']");*/
        By dropbox = By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div/div[2]/div/div[2]");
        public void SimpleBar(string url)
        {
            driver.Url = url;
            IWebElement oneElement = driver.FindElement(dragme);
            IWebElement twoElement = driver.FindElement(source);
            actions.DragAndDrop(driver.FindElement(dragme), driver.FindElement(source))
                .Build()
                .Perform();
        }
        public void AcceptBar(string url)
        {
            driver.Url = url;
            driver.FindElement(acceptbar).Click();
            IWebElement acceptablebox = driver.FindElement(acceptable);
            IWebElement notacceptablebox = driver.FindElement(notacceptable);
            IWebElement dropherebox = driver.FindElement(dropbox);
            int xOffset = 0;
            int yOffset = acceptablebox.Size.Height + 10;
            actions.ClickAndHold(acceptablebox)
                   .MoveToElement(dropherebox)
                   .Release()
                   .Build()
                   .Perform();

            // Calculate the offset to position the notacceptable box below the acceptable box// Adjust the yOffset as desired

            // Move the notacceptable box below the acceptable box in the container
            actions.ClickAndHold(notacceptablebox)
                   .MoveToElement(dropherebox)
                   .MoveByOffset(xOffset, yOffset)
                   .Release()
                   .Build()
                   .Perform();
        }
        By DragmeBox = By.XPath("//div[@id='dragBox']"); 
        By firstouterbox = By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div/div[3]/div/div[2]/div[1]/p");
        By firstinnerbox = By.XPath("//div[@id='notGreedyInnerDropBox']");
        By secondouterbox = By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div/div[3]/div/div[2]/div[2]/p");
        By secondinnerbox = By.XPath("//div[@id='greedyDropBoxInner']");
        public void PreventPropogation(string url)
        {
            driver.Url = url;
            driver.FindElement(preventbar).Click();
            IWebElement dragmebox = driver.FindElement(DragmeBox);
            IWebElement firstouter = driver.FindElement(firstouterbox);
            IWebElement firstinner = driver.FindElement(firstinnerbox);
            IWebElement secondinner = driver.FindElement(secondinnerbox);
            IWebElement secondouter = driver.FindElement(secondouterbox);
            actions.ClickAndHold(dragmebox)
                   .MoveToElement(firstouter)
                   .Release()
                   .Build()
                   .Perform();
            actions.Reset();
            actions.ClickAndHold(dragmebox)
                   .MoveToElement(firstinner)
                   .Release()
                   .Build()
                   .Perform();
            actions.Reset();
            actions.ClickAndHold(dragmebox)
                    .MoveToElement(secondouter)
                    .Release()
                    .Build()
                    .Perform();
            actions.Reset();
            actions.ClickAndHold(dragmebox)
        .MoveToElement(secondinner)
        .Release()
        .Build()
        .Perform();
            actions.Reset();



        }
        By reverttab = By.XPath("//a[@id='droppableExample-tab-revertable']");
        By willrevert = By.XPath("//div[@id='revertable']");
        By notrevert = By.XPath("//div[@id='notRevertable']");
        By Revertdropbox = By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div/div[4]/div/div[2]");
        public void RevertDraggAble(string url)
        {
            driver.Url = url;
            driver.FindElement(reverttab).Click();
            IWebElement Willrevert = driver.FindElement(willrevert);
            IWebElement WillnotRevert = driver.FindElement(notrevert);
            IWebElement RevertDropBox = driver.FindElement(Revertdropbox);
            actions.ClickAndHold(Willrevert)
                   .MoveToElement(RevertDropBox)
                   .Release()
                   .Build()
                   .Perform();
            actions.Reset();
            Thread.Sleep(2000);
            actions.ClickAndHold(WillnotRevert)
                   .MoveToElement(RevertDropBox)
                   .Release()
                   .Build()
                   .Perform();
            actions.Reset();
            Thread.Sleep(1000);

        }
    }
}

    
