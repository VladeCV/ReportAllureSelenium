using OpenQA.Selenium;

namespace SeleniumTCS.code.factoryBrowser
{
    public interface IBrowser
    {
        IWebDriver Create();
    }
}
