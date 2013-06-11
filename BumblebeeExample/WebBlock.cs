﻿using System;
using Bumblebee.Extensions;
using Bumblebee.Implementation;
using Bumblebee.Setup;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace BumblebeeExample
{
    public class WebBlock : Block
    {
        public WebBlock(Session session) : base(session)
        {
            Tag = Session.Driver.GetElement(By.TagName("body"));
        }
    }
}