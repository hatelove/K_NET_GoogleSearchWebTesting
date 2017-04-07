using FluentAutomation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GoogleSearchWebTesting
{
    [TestClass]
    public class UnitTest1 : FluentTest
    {
        public UnitTest1()
        {
            SeleniumWebDriver.Bootstrap(SeleniumWebDriver.Browser.Firefox);
        }

        [TestMethod]
        public void TestMethod1()
        {
            I.Open("https://www.google.com/")
                .Enter("skilltree").In("input[name='q']")
                .Press("{ENTER}")
                .Assert.Exists("a[href='https://skilltree.my/']");
        }
    }
}