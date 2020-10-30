using NUnit.Framework;
using MyntraAutomation.Base;
using MyntraAutomation.Pages;
namespace MyntraAutomation
{
    public class Tests : BaseClass
    {
        [Test]
        public void SearchProductTest()
        {
            SearchProduct search = new SearchProduct(driver);
            search.SearchPage();
            Assert.Pass();
        }
    }
}