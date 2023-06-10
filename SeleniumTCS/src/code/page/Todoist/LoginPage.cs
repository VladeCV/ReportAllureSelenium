using OpenQA.Selenium;
using SeleniumTCS.code.control;

namespace SeleniumTCS.code.page.Todoist
{
    public class LoginPage
    {
        public TextBox emailTxtBox = new TextBox(By.XPath("//input[@id='element-0']"));
        public TextBox pwdTxtBox = new TextBox(By.XPath("//input[@id='element-3']"));
        public Button loginBtn = new Button(By.XPath("//div[2]//div/form/button"));

    }
    
}
