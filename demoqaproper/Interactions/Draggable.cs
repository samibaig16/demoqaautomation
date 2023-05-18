using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoqaproper.demoqaproper.Widgets
{
    internal class Draggable : CorePage
    {
        By Simpletab = By.XPath("//a[@id='draggableExample-tab-simple']");
        By XAxis = By.XPath("//div[@id='restrictedX']");
        By YAxis = By.XPath("//div[@id='restrictedY']");
        By AxisTab = By.XPath("//a[@id='draggableExample-tab-axisRestriction']");
        By ContainerRestricted = By.XPath("//a[@id='draggableExample-tab-containerRestriction']");
        By Containerwrapper = By.XPath("//div[@id='containmentWrapper']");
        By dragableelement = By.XPath("//div[@class='draggable ui-widget-content ui-draggable ui-draggable-handle']");
        By dragme = By.XPath("//div[@id='dragBox']");
/*        public void DraggablePage(string url)
        {
            driver.Url = url;
            driver.FindElement(Simpletab).Click();
            actions.ClickAndHold(driver.FindElement(dragme))
                .MoveByOffset(150, 360)
                .Build()
                .Perform();
            actions.Reset();
        }
        public void AxisRestricted(string url)
        {
            driver.Url = url;
            driver.FindElement(AxisTab).Click();
            actions.ClickAndHold(driver.FindElement(XAxis))
                   .MoveByOffset(100, 0)
                   .Build()
                   .Perform();
            actions.Reset();
            actions.ClickAndHold(driver.FindElement(YAxis))
       .MoveByOffset(0, 100)
            .Build()
       .Perform();
            actions.Reset();

        }*/
        public void Container_Restricted(string url)
        {
            driver.Url = url;
            driver.FindElement(ContainerRestricted).Click();
            actions.ClickAndHold(driver.FindElement(dragableelement))
       .MoveByOffset(0, 70)
       .MoveByOffset(60, 0)
       .Build()
       .Perform();
            actions.Reset();
        }
    }
}
