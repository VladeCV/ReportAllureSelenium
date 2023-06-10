using OpenQA.Selenium;
using SeleniumTCS.code.control;

namespace SeleniumTCS.code.page.Todoist
{
    public class MainPage
    {
        public Button loginButton = new Button(By.XPath("//nav//a[text()='Log in']"));
    }
}
