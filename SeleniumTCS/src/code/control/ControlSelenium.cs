﻿using OpenQA.Selenium;
using SeleniumTCS.code.session;

namespace SeleniumTCS.code.control
{
    public class ControlSelenium
    {
        protected By Locator;
        protected IWebElement Control;

        public ControlSelenium(By Locator)
        {
            this.Locator = Locator;
        }

        protected void FindControl()
        {
            Control = Session.Instance().GetBrowser().FindElement(Locator);

        }
        public void Click()
        {
            FindControl();
            Control.Click();
        }

        public Boolean IsControlDisplayed()
        {
            try
            {
                FindControl();
                return Control.Displayed;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
