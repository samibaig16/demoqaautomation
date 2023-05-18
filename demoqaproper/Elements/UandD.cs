using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoqaproper.demoqaproper.Elements
{
    internal class UandD : CorePage
    {
        By clickOnChooseFile = By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/div[2]/div[2]/div[2]/div[2]/form[1]/div[1]/input[1]");
/*        By clickOnDownload = By.Id("downloadButton");*/

        public void ChooseFile(string url, string filePath)
        {
            driver.Url = url;
            driver.FindElement(clickOnChooseFile).SendKeys(filePath);
        }
    }
}

