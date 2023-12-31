﻿using SeleniumTCS.code.session;

namespace SeleniumTCS.code.test.Email;

[TestFixture]
public class TestBase
{
    [SetUp]
    public void OpenBrowser()
    {
        Session.Instance().GetBrowser().Navigate().GoToUrl("https://yopmail.com/");
    }

    [TearDown]
    public void CloseBrowser()
    {
        Session.Instance().CloseBrowser();
    }
}