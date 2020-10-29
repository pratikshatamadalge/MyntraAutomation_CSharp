using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyntraAutomation.Base
{
    public class BaseClass
    {
        public IWebDriver driver;
        [OneTimeSetUp]
        public void Setup()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("start-maximized","--incognito","disable notification");
            driver = new ChromeDriver(options);
            driver.Url = "https://www.myntra.com/?utm_source=Google";
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
