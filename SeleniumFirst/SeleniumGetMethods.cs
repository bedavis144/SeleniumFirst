using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace SeleniumFirst
{
    public static class SeleniumGetMethods
    {
        /// <summary>
        /// Extended command for reading text
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public static string GetText(this IWebElement element)
        {
                return element.GetAttribute("value");
        }

        /// <summary>
        /// Extended command for reading DropDown Text
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public static string GetTextfromDDL(this IWebElement element)
        {
                return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;
        }
    }
}
