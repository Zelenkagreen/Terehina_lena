﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Remote;
using Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using OpenQA.Selenium.Support.PageObjects;

namespace TestingProject.Framework
{
    class Utils : BaseObject
    {
        public static string baseUrl = "http://pogoda.yandex.ru/penza/";
        private const int DEFAULT_TIMEOUT = 30;

        public static void WaitForElementPresent(string locator, int timeOut = DEFAULT_TIMEOUT)
        {
            for (int i = 0; i < timeOut; i++)
            {

                if (Selenium.IsElementPresent(locator))
                {
                    return;
                }
                else
                {
                    System.Threading.Thread.Sleep(1000); ;
                }
            }
            Assert.Fail("Element '" + locator + "' is not found");
        }
    }
}
