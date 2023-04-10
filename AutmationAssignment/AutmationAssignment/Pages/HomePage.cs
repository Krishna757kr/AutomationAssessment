using AutmationAssignment.Common;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AutmationAssignment.Pages
{
    public class HomePage
    {
        public static void Search(IWebDriver driver, string SearchText )
        {
            driver.FindElement(By.Id(Locators.SearchBox_id)).SendKeys(SearchText);
            Console.WriteLine("Searched Text :"+ SearchText);

        }

        public static void ValidateAllSuggestedResultsAndClickLast(IWebDriver driver, string TextToBeValidate)
        {
            List<string> matchingLinks = new List<string>();
            Thread.Sleep(5000);
            ReadOnlyCollection<IWebElement> links = driver.FindElements(By.XPath(Locators.SuggestionsResult_xpath));
            Console.WriteLine("Suggested Items are: ");
            foreach (IWebElement link in links)
            {
                string text = link.Text.ToLower();
                if(text.Contains(TextToBeValidate.ToLower()))
                {
                    matchingLinks.Add(text);
                    Console.WriteLine(text);
                }
            }

            // Click Last Option from the suggestions
            int totalSuggestios = 1;
            foreach (string linkText in matchingLinks)
            {
               
                if (matchingLinks.Count ==totalSuggestios)
                {
                    IWebElement element = driver.FindElement(By.XPath(Locators.SuggestionsResultIndex_xpath(totalSuggestios.ToString())));
                    element.Click();
                    Console.WriteLine("Total Suggested Result Displayed :"+ matchingLinks.Count);
                    Console.WriteLine("Last Suggested Result Clicked");
                }
                totalSuggestios++;
            }

        }
    }
}
