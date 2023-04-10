using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutmationAssignment.Common
{
    public class Locators
    {
        // Home Page
        public static string SearchBox_id => "twotabsearchtextbox";
        public static string SuggestionsResult_xpath => "//div[@class='s-suggestion s-suggestion-ellipsis-direction']";
        public static string SuggestionsResultIndex_xpath(string val) => "(//div[@class='s-suggestion s-suggestion-ellipsis-direction'])["+val+"]";
        public static string SearchButton_id => "nav-search-submit-button";

        // Product Page
        public static string validateProduct_xpath => "//span[contains(text(),'Gel')]";
        public static string sortBy_id => "a-autoid-0-announce";
        public static string sortByLowToHigh_xpath => "*//a[contains(text(),'Price: Low to High')]";

        public static string lowestPriceFirstItem => "(//span[@class='a-price-whole'])[1]";

        public static string quantity_xpath => "//select[@name='quantity']";

        public static string addToCartButton_id => "add-to-cart-button";

        // Cart Page
        public static string cartBtn_id => "nav-cart";
        public static string deleteAddedItemFromCart_xpath => "//*[@value='Delete']";

        public static string clearCartText_xpath => "//*[@id='sc-active-cart']//h1";
    }
}
