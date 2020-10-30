using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Threading;

namespace MyntraAutomation.Pages
{
    public class SearchProduct
    {
        public IWebDriver driver;
        public SearchProduct(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//header/div[2]/div[3]/input[1]")]
        IWebElement SearchBox { get; set; }

        public void SearchPage()
        {
            Thread.Sleep(3000);
            SearchBox.SendKeys("Roadsters shoes");
        }
    }
}
