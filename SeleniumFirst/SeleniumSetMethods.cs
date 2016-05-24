using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;


namespace SeleniumFirst
{
    public static class SeleniumSetMethods
    {
        //Enter Text 
        //Extended method for entering text in the control

        

        /// <summary>
        /// Extended method for entering text in the control
        /// </summary>
        /// <param name="element"></param>
        /// <param name="value"></param>
        public static void EnterText(this IWebElement element, string value)
        {
            element.SendKeys(value);
        }

        /// <summary>
        /// Extended method for clicking the button
        /// </summary>
        /// <param name="element"></param>
        public static void btnClick(this IWebElement element)
        {
            element.Submit();
        }

        /// <summary>
        /// Exteneded method for selecting drop down control
        /// </summary>
        /// <param name="element"></param>
        /// <param name="value"></param>
        public static void SelectDropDown(this IWebElement element, string value)
        {
                new SelectElement(element).SelectByText(value);
        }


    }
}
