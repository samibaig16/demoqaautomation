using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoqaproper.demoqaproper.AFW
{
    internal class NestedFrames : CorePage
    {
        public void nested_frames(string url)
        {
            driver.Url = url;
            IWebElement iframe1 = driver.FindElement(By.XPath("//iframe[@src='/sampleiframe']"));
            // Switch to the iframe
            driver.SwitchTo().Frame(iframe1);
            IWebElement iframe2 = driver.FindElement(By.XPath("//iframe[@srcdoc='<p>Child Iframe</p>']"));

            // Switch to the iframe
            driver.SwitchTo().Frame(iframe2);

            /*            IWebElement iframe = driver.FindElement(By.XPath("/html/body/p"));
                        driver.SwitchTo().Frame(iframe);

                        actions.DoubleClick().Perform();*/
            /*            driver.SwitchTo().Frame("frame1");

                        // Switch to the child frame
                        driver.SwitchTo().Frame(0); // Assuming the nested iframe is the first one inside the parent frame

                        // Perform actions in the child frame

                        // Switch back to the parent frame
                        driver.SwitchTo().ParentFrame();*/
            /*            driver.SwitchTo().Frame("frame1");

                        // Double click in the parent frame
                        IWebElement parentFrameElement = driver.FindElement(By.XPath("//iframe[@id='frame1']"));
                        actions.DoubleClick(parentFrameElement).Perform();

                        // Switch to the child frame
                        driver.SwitchTo().Frame(0); // Assuming the nested iframe is the first one inside the parent frame

                        // Double click in the child frame
                        IWebElement childFrameElement = driver.FindElement(By.TagName("body")); // Replace "body" with the actual element in the child frame to double click
                        actions.DoubleClick(childFrameElement).Perform();

                        // Switch back to the parent frame
                        driver.SwitchTo().ParentFrame();

                        // Double click in the parent frame
                        actions.DoubleClick(parentFrameElement).Perform();*/
        }
    }
}
