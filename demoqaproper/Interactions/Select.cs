using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoqaproper.demoqaproper.Widgets
{
    internal class Select : CorePage
    {
        By List = By.XPath("//a[@id='demo-tab-list']");
        public void ListPageSelect(string url)
        {
            driver.Url = url;

            IWebElement ulElement = driver.FindElement(By.Id("verticalListContainer"));

            // Find all the li elements within the ul element
            IList<IWebElement> liElements = ulElement.FindElements(By.TagName("li"));

            // Select the elements by their index
            liElements[0].Click();
            liElements[1].Click();
            liElements[2].Click();
            liElements[3].Click();
        }
        By Grid = By.XPath("//a[@id='demo-tab-grid']");
        By gridContainer = By.Id("gridContainer");
        By row1 = By.Id("row1");
        By row2 = By.Id("row2");
        By row3 = By.Id("row3");
        public void GridPageSelect(string url)
        {
            driver.Url = url;
            driver.FindElement(Grid).Click();

            IWebElement gridContainerElement = driver.FindElement(gridContainer);

            // Find the div elements within the grid container
            IList<IWebElement> rowElements = gridContainerElement.FindElements(By.XPath("./div"));

            // Find the li elements within each row
            IList<IWebElement> liElementsRow1 = rowElements[0].FindElements(By.TagName("li"));
            IList<IWebElement> liElementsRow2 = rowElements[1].FindElements(By.TagName("li"));
            IList<IWebElement> liElementsRow3 = rowElements[2].FindElements(By.TagName("li"));

            // Select the elements by their index
            liElementsRow1[0].Click(); // Click on the first element in row 1
            liElementsRow1[1].Click(); // Click on the second element in row 1
            liElementsRow1[2].Click(); // Click on the third element in row 1

            liElementsRow2[0].Click(); // Click on the first element in row 2
            liElementsRow2[1].Click(); // Click on the second element in row 2
            liElementsRow2[2].Click(); // Click on the third element in row 2

            liElementsRow3[0].Click(); // Click on the first element in row 3
            liElementsRow3[1].Click(); // Click on the second element in row 3
            liElementsRow3[2].Click(); // Click on the third element in row 3
        }
    }
}
