using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoqaproper.demoqaproper.Widgets
{

    internal class Sortable : CorePage
    {
        By List = By.XPath("//a[@id='demo-tab-list']");
        By One = By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div/div[1]/div/div[1]");
        By Two = By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div/div[1]/div/div[2]");
        By Three = By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div/div[1]/div/div[3]");
        By Four = By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div/div[1]/div/div[4]");
        By Five = By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div/div[1]/div/div[5]");
        By Six = By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div/div[1]/div/div[6]");

        public void List_Sortablee(string url)
        {
            driver.Url = url;
            IWebElement oneElement = driver.FindElement(One);
            IWebElement twoElement = driver.FindElement(Two);
            IWebElement threeElement = driver.FindElement(Three);
            IWebElement fourElement = driver.FindElement(Four);
            IWebElement fiveElement = driver.FindElement(Five);
            IWebElement sixElement = driver.FindElement(Six);
            actions.ClickAndHold(sixElement)
                .MoveToElement(oneElement)
                .Release()
                .Perform();
            actions.Reset();

            actions.ClickAndHold(sixElement)
                .MoveToElement(twoElement)
                .Release()
                .Perform();
            actions.Reset();    

            actions.ClickAndHold(sixElement)
                .MoveToElement(threeElement)
                .Release()
                .Perform();
            actions.Reset();     
            actions.ClickAndHold(sixElement)
                .MoveToElement(fourElement)
                .Release()
                .Perform();
            actions.Reset(); 
            actions.ClickAndHold(sixElement)
                .MoveToElement(fiveElement)
                .Release()
                .Perform();
            actions.Reset();



           
        }
        By Grid = By.XPath("//a[@id='demo-tab-grid']");
        By GridOne = By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div/div[2]/div/div/div[1]");
        By GridTwo = By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div/div[2]/div/div/div[2]");
        By GridThree = By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div/div[2]/div/div/div[3]");
        By GridFour = By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div/div[2]/div/div/div[4]");
        By GridFive = By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div/div[2]/div/div/div[5]");
        By GridSix = By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div/div[2]/div/div/div[6]");
        By GridSeven = By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div/div[2]/div/div/div[7]");
        By GridEight = By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div/div[2]/div/div/div[8]");
        By GridNine = By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div/div[2]/div/div/div[9]");
        public void Grid_Sortablee(string url)
        {
            driver.Url=url;
            driver.FindElement(Grid).Click();
            IWebElement oneElement = driver.FindElement(GridOne);
            IWebElement twoElement = driver.FindElement(GridTwo);
            IWebElement threeElement = driver.FindElement(GridThree);
            IWebElement fourElement = driver.FindElement(GridFour);
            IWebElement fiveElement = driver.FindElement(GridFive);
            IWebElement sixElement = driver.FindElement(GridSix);
            IWebElement sevenElement = driver.FindElement(GridSeven);
            IWebElement eightElement = driver.FindElement(GridEight);
            IWebElement nineElement = driver.FindElement(GridNine);

            actions.ClickAndHold(nineElement)
               .MoveToElement(oneElement)
               .Release()
               .Perform();
            actions.Reset();  
            actions.ClickAndHold(nineElement)
               .MoveToElement(twoElement)
               .Release()
               .Perform();
            actions.Reset();   
            actions.ClickAndHold(nineElement)
               .MoveToElement(threeElement)
               .Release()
               .Perform();
            actions.Reset(); 
            actions.ClickAndHold(nineElement)
               .MoveToElement(fourElement)
               .Release()
               .Perform();
            actions.Reset(); 
            actions.ClickAndHold(nineElement)
               .MoveToElement(fiveElement)
               .Release()
               .Perform();
            actions.Reset();  
            actions.ClickAndHold(nineElement)
               .MoveToElement(sixElement)
               .Release()
               .Perform();
            actions.Reset();
            actions.ClickAndHold(nineElement)
               .MoveToElement(sevenElement)
               .Release()
               .Perform();
            actions.Reset();
            actions.ClickAndHold(nineElement)
               .MoveToElement(eightElement)
               .Release()
               .Perform();
            actions.Reset();

        }
    }
}
