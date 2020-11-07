namespace MyntraAutomation.Base
{
    using AventStack.ExtentReports;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    public class BaseClass
    {
        public ExtentReports extent;
        public IWebDriver driver;
        [OneTimeSetUp]
        public void Setup()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("start-maximized","-incognito","--disable notification");
            driver = new ChromeDriver(options);
            driver.Url = "https://www.myntra.com/?utm_source=Google";
        }

        [TearDown]
        public void close()
        {

        }

        [OneTimeTearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}