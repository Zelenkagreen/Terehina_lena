using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;


namespace TestingProject.Tests
{
    [TestFixture]
    public class YandexTests 
    {
 [TestFixtureSetUp]
        public void beforeClass();
       Driver = new FirefoxDriver();
        Selenium = new WebDriverBackedSelenium(Driver, Utils.baseUrl);
            
 }
       
        [SetUp]
        public void beforeTest()
        {
            Driver.Navigate().GoToUrl(Utils.baseUrl);
        }
    
       [Test]
        public static void AssertRegion()
        {
            string REGION = "Пенза";
            
            RegionHelper.
                DoRegion(region).
                AssertRegion(displayedregion)
            Assert.IsTrue(TypeRegionPage.Contains("Пенза"));
       }
    }
