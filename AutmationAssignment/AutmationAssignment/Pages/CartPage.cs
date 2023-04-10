using AutmationAssignment.Common;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutmationAssignment.Pages
{
    public class CartPage
    {
        public static void OpenCart(IWebDriver driver)
        {
            driver.FindElement(By.Id(Locators.cartBtn_id)).Click();
            Console.WriteLine("Cart Clicked");
        }

        public static void DeleteItemFromCart(IWebDriver driver) 
        {
            Thread.Sleep(4000);
            driver.FindElement(By.XPath(Locators.deleteAddedItemFromCart_xpath)).Click();
            Console.WriteLine("Deleted Item from Cart");
        }

        public static bool isCartEmpty(IWebDriver driver)
        {
            bool isEmpty = false;
            try
            {
                 isEmpty = driver.FindElement(By.XPath(Locators.clearCartText_xpath)).Displayed;
                Console.WriteLine("Validated Cart is Empty");
            }
            catch
            {
                isEmpty=false;
            }
            return isEmpty;
        }
    }
}
