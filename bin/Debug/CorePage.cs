using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using Microsoft.Extensions.Options;
using System;
using OpenQA.Selenium.Support.UI;

namespace demoqaproper
{

    internal class CorePage 
    {

        public static IWebDriver driver;
        public static Actions actions;
        public static void SeleniumInit(string browser)
        {
            if (browser == "Chrome")
            {
                var chromeOptions = new ChromeOptions();
                chromeOptions.AddExtension("C:\\Users\\shahr\\Downloads\\AdBlock-—-best-ad-blocker.crx");
                chromeOptions.AddArguments(@"C:\Users\shahr\Downloads\AdBlock-—-best-ad-blocker.crx");
                chromeOptions.AddArguments("--start-maximized");
                chromeOptions.AddArguments("--incognito");
                chromeOptions.AddArgument("--force-device-scale-factor=0.6");
                /*                chromeOptions.AddArgument("--window-size=1280,800");*/
                chromeOptions.AddArgument("--disable-blink-features=AutomationControlled");
                chromeOptions.AddArgument("--disable-blink-features=AutomationControlled");
                chromeOptions.AddUserProfilePreference("credentials_enable_service", false);
                chromeOptions.AddUserProfilePreference("profile.password_manager_enabled", false);
                chromeOptions.AddArgument("--test-type");


                IWebDriver chromeDriver = new ChromeDriver(chromeOptions);


                
                driver = chromeDriver;

                actions = new Actions(driver);
                driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(240);
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            }
            else if (browser == "FireFox")
            {
                FirefoxOptions options = new FirefoxOptions();
                options.AddArguments("");

                driver = new FirefoxDriver(options);
            }
            else if (browser == "MicrosoftEdge")
            {
                var options = new EdgeOptions();
                var service = EdgeDriverService.CreateDefaultService(@"C:\Users\shahr\source\repos\demoqaproper\bin\Debug", @"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe");

                driver = new EdgeDriver(service, options);
            }
        }
    }
}
