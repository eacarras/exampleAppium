using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Remote;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        // Line to declare Appium driver 
        AppiumDriver<AndroidElement> driver;

        [TestMethod]
        public void TestMethod1()
        {
            DesiredCapabilities cap = new DesiredCapabilities();
            cap.SetCapability("deviceName", "osprey_umn");
            cap.SetCapability("platformVersion", "6.0.1");
            cap.SetCapability("browserName", "chrome");
            cap.SetCapability("platformName", "android");
            driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723"), cap);
            driver.Navigate().GoToUrl("http://m.youtube.com");
        }
    }
}
