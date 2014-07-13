using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;

namespace TestingProject.Pages
{
    public class RegionPage 
    {
        [FindsBy(How = How.XPath, Using = REGION_TEXT_FIELD)]
        public IWebElement RegionTextField;

        public static RegionPage GetRegionPage()
        {
            RegionPage RegionPage = new RegionPage();
            return RegionPage;
        }

        public RegionPage TypeRegion(string userName)
        {
            RegionTextField.SendKeys( Region);
            return GetRegionPage();
        }

        public const string REGION_TEXT_FIELD = "//input[@id='gorod']";
        private string Region;
    }
}