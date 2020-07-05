﻿using OpenQA.Selenium;

namespace HomeworkSeleniumAdvanced
{
    public static class DriverExtensions
    {
        public static void ScrollTo(this IWebDriver driver, IWebElement element)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }
    }
}
