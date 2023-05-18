using demoqaproper.demoqaproper.Widgets;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V113.FedCm;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
namespace demoqaproper.demoqaproper.Widgets
{
    internal class Slider : CorePage
    {
        By slider = By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/div[2]/div[2]/form[1]/div[1]/div[1]/span[1]/input[1]");

        public void SliderPage(string url, string desiredValue)
        {
            driver.Url = url;

            // Pehle slider element ko locate karte hain
            var sliderElement = driver.FindElement(slider);

            // Slider ka width nikala jata hai
            int sliderWidth = sliderElement.Size.Width;

            // Desired value ko numeric type mein convert karte hain
            double value = double.Parse(desiredValue);

            // Slider ke boundaries ke beech mein move karne ke liye offset calculate karte hain
            int minValue = 0;
            int maxValue = 100;
            int offset = (int)Math.Round(sliderWidth * ((value - minValue) / (maxValue - minValue)));

            // Calculate the adjusted offset to ensure the slider stops at the desired value
            int adjustedOffset = offset - (sliderWidth / 2);

            // Slider ko hold karte hain aur offset ke hisaab se move karte hain
            actions.ClickAndHold(sliderElement)
                  .MoveByOffset(adjustedOffset, 0)
                  .Release()
                  .Build()
                  .Perform();
        }
    }
}






