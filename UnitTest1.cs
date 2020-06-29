using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace Unit.Test
{
    class UnitTest
    {
        protected IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver(".");

            // Launch the Form WebSite
            driver.Url = ("https://subline-test.artsrn.ualberta.ca/Registration/Create/54?eventItemDef=399");
          
        }
        [Test]
        public void SValue()
        {
            // Verifying subtotal value "0.00"
            IWebElement SubTotal = driver.FindElement(By.Id("subTotal"));
            string GetSValue = SubTotal.GetAttribute("value");
            Assert.AreEqual(GetSValue, "0.00");

            // Click on the "Opt 1 - $100"
            IWebElement element = driver.FindElement(By.Id("Elements_1__ExtendedValue_0_"));
            element.Click();

            // Verifying subtotal value "100.00"
            IWebElement SubTotal1 = driver.FindElement(By.Id("subTotal"));
            string GetSValue1 = SubTotal1.GetAttribute("value");
            Assert.AreEqual(GetSValue1, "100.00");
        }
    }
}