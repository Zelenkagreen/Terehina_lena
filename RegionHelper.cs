using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestingProject.Pages;
using NUnit.Framework;
using TestingProject.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;

namespace TestingProject.TestHelpers
{
    public class RegionHelper
    {
        private RegionPage RegionPage = new RegionPage();

        public RegionHelper DoRegion(string region)
        {
            BaseObject.InitPage(RegionPage);
              TypeRegion(region);
                
            return this;
        }

        public RegionHelper AssertRegion(string region)
        {
            TypeRegionPage.AssertRegion(region);
            return this;
        }
    }
}
