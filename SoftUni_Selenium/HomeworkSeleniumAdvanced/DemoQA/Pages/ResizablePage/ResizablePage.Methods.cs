﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkSeleniumAdvanced.DemoQA.Pages.ResizablePage
{
    public partial class ResizablePage : BasePage
    {
        public ResizablePage(IWebDriver driver) : base (driver)
        {
        }
        public override string Url => "http://demoqa.com/resizable";
    }
}
