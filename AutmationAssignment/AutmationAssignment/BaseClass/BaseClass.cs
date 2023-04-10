using NUnit.Framework.Internal;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutmationAssignment.CommonBaseClass
{
    public class BaseClass
    {
      
        public static ChromeOptions GetChromeOptions() 
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("start-maximized");
            options.AddArgument("--headless");
            Console.WriteLine("Using headless chrome options");
            return options;
        } 
    }
}
