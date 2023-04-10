using AutmationAssignment.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutmationAssignment.TestCases
{
    public class Tests
    {
        IWebDriver driver;
        [OneTimeSetUp]
        public void Setup()
        {

            driver = new ChromeDriver(CommonBaseClass.BaseClass.GetChromeOptions());
            driver.Navigate().GoToUrl("https://www.amazon.in");
            Console.WriteLine("Browser Started in Headless mode");

        }

        [Test, Order(1)]
        public void SearchValidateAndAddToCart()
        {
            HomePage.Search(driver, "Gel Pen");
            HomePage.ValidateAllSuggestedResultsAndClickLast(driver, "Gel Pen"); 
            ProductPage.ValidateAllSearchResults(driver, "Gel");
            ProductPage.SortPriceBy(driver, "Price: Low to High");
            ProductPage.PickLowestPriceItem(driver);
            ProductPage.ChangeQuantity(driver, "2");
            ProductPage.AddToCart(driver);
           // Assert.Pass();
        }

        [Test, Order(2)]
        public void ClearCartAndValidate()
        {
            CartPage.OpenCart(driver);

            CartPage.DeleteItemFromCart(driver);

            // Validate if cart is empty
            Assert.IsTrue(CartPage.isCartEmpty(driver));
        }
    }
}