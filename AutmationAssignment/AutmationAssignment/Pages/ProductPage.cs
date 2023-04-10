using AutmationAssignment.Common;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AutmationAssignment.Pages
{
    public class ProductPage
    {
        public static void ValidateAllSearchResults(IWebDriver driver, string TextToBeValidate)
        {
            List<string> matchingLinks = new List<string>();

            ReadOnlyCollection<IWebElement> links = driver.FindElements(By.XPath(Locators.validateProduct_xpath));

            foreach (IWebElement link in links)
            {
                string text = link.Text;
                //if (Regex.IsMatch(TextToBeValidate, text))
                if (text.Contains(TextToBeValidate))
                {
                    matchingLinks.Add(text);
                }
            }
            Console.WriteLine("Validated All the Searched Results that Contains :" + TextToBeValidate);

        }

        public static void ValidateEverySearchResultsTitle(IWebDriver driver, string TextToBeValidate)
        {
            List<string> matchingLinks = new List<string>();

            ReadOnlyCollection<IWebElement> links = driver.FindElements(By.XPath(Locators.validateProduct_xpath));

            foreach (IWebElement link in links)
            {
                string text = link.Text;
                //if (Regex.IsMatch(TextToBeValidate, text))
                if (text.Contains(TextToBeValidate))
                {
                    matchingLinks.Add(text);
                }
            }
            Console.WriteLine("Validated All the Searched Results that Contains :"+TextToBeValidate);

        }

        public static void SortPriceBy(IWebDriver driver, string SortBy)
        {
            driver.FindElement(By.Id(Locators.sortBy_id)).Click();
            Console.WriteLine("Clicked Sort By");
            driver.FindElement(By.XPath(Locators.sortByLowToHigh_xpath)).Click();
            Console.WriteLine("Sorted By Low To High");

        }

        public static void PickLowestPriceItem(IWebDriver driver)
        {
            Thread.Sleep(5000);
            driver.FindElement(By.XPath(Locators.lowestPriceFirstItem)).Click();
            Console.WriteLine("Selected Lowest Price First Item");
        }

        public static void ChangeQuantity(IWebDriver driver, string qty)
        {
            Thread.Sleep(15000);
            string newWindowHandle = driver.WindowHandles.Last();
            var newWindow = driver.SwitchTo().Window(newWindowHandle);
            var quantity = driver.FindElement(By.XPath(Locators.quantity_xpath));
            var selectQuantity = new SelectElement(quantity);
            selectQuantity.SelectByText(qty);
            Console.WriteLine("Changed Quantity to +"+ qty);

        }

        public static void AddToCart(IWebDriver driver)
        {
            driver.FindElement(By.Id(Locators.addToCartButton_id)).Click();
            Thread.Sleep(5000);
            Console.WriteLine("Clicked Add To Cart Button");
        }
    }
}
