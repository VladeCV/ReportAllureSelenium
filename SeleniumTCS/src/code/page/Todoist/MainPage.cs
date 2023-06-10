using OpenQA.Selenium;
using SeleniumTCS.code.control;

namespace SeleniumTCS.code.page.Todoist
{
    public class MainPage
    {
        public Button loginButton = new(By.XPath("//nav/div//a[text()='Log in']"));
    }
}
