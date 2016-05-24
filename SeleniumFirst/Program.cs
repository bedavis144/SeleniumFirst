using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SeleniumFirst
{
    class Program
    {

        static void Main(string[] args)
        {
        }

        [SetUp]
        public void Initialize()
        {
            //Create the reference for our browser
            PropertiesCollection.driver = new ChromeDriver();
            
            //Navigate to Google page
            PropertiesCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
            Console.WriteLine("Opened Browser");
        }

        [Test]
        public void ExecuteTest()
        {
            ExcelLib.PopulateInCollection(@"C:\Users\bdavis2\Documents\FormAutomation.xlsx");

            //Login to Application
            LoginPageObject pageLogin = new LoginPageObject();
            EAPageObjects pageEA = pageLogin.Login(ExcelLib.ReadData(1, "UserName"), ExcelLib.ReadData(1, "Password"));

            //Fill form
            pageEA.FillUserForm(ExcelLib.ReadData(1, "Initial"), ExcelLib.ReadData(1, "FirstName"), ExcelLib.ReadData(1, "MiddleName"));

            
            
        }

        [Test]
        public void NextTest()
        {
            Console.WriteLine("Next Test");
        }

        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.driver.Close();
            Console.WriteLine("Closed Browser");
        }
    }
}
