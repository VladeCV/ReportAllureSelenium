using SeleniumTCS.code.page.Todoist;
using SeleniumTCS.code.session;
using TechTalk.SpecFlow;

namespace SeleniumTCS.Steps;

[Binding]
public class ProjectManagement
{
    MainPage mainPage = new MainPage();
    LoginPage loginPage = new LoginPage();
    ProjectDashboard leftMenu = new ProjectDashboard();
    
    [Given(@"I have access to todoist\.com")]
    public void GivenIHaveAccessToTodoistCom()
    {
        Session.Instance().GetBrowser().Navigate().GoToUrl("https://todoist.com/");
    }

    [Given(@"I have access to login form")]
    public void GivenIHaveAccessToLoginForm()
    {
        mainPage.loginButton.Click();
    }

    [When(@"I use my credentials")]
    public void WhenIUseMyCredentials()
    {
        loginPage.emailTxtBox.SetText("vladimircvcf98@outlook.com");
        loginPage.pwdTxtBox.SetText("759153ferd123");
        loginPage.loginBtn.Click();
    }
    
    [Then(@"I should see the main page")]
    public void ThenIShouldSeeTheMainPage()
    {
        Assert.That(leftMenu.todayLabel.IsControlDisplayed(), Is.True, "Login was not successful");
        
    }

    [Given(@"I go to the left menu")]
    public void GivenIGoToTheLeftMenu()
    {
        leftMenu.addProjectBtn.Click();
    }

    [Given(@"I set the data of my project")]
    public void GivenISetTheDataOfMyProject()
    {
        leftMenu.projectName.SetText("New project blue");
        leftMenu.dropDownColorBtn.Click();
        leftMenu.projectColorBlue.Click();
    }

    [When(@"I click on add project confirmation button")]
    public void WhenIClickOnAddProjectConfirmationButton()
    {
        leftMenu.confirmAddition.Click();
        Thread.Sleep(1000);
    }

    [Then(@"My project should be displayed on the projects list")]
    public void ThenMyProjectShouldBeDisplayedOnTheProjectsList()
    {
        Assert.That(leftMenu.ProjectNameIsDisplayed("New project blue"), Is.True, "ERROR! The project was not created");
    }

    [Given(@"I go to my recently created project")]
    public void GivenIGoToMyRecentlyCreatedProject()
    {
        leftMenu.ClickProjectName("New project blue");
        leftMenu.editProjectBtn.Click();
        Thread.Sleep(1000);
    }

    [Given(@"I update the data")]
    public void GivenIUpdateTheData()
    {
        leftMenu.projectName.SetText("New project red updated");
        leftMenu.dropDownColorBtn.Click();
        leftMenu.projectColorRed.Click();
    }

    [When(@"I click on update project confirmation button")]
    public void WhenIClickOnUpdateProjectConfirmationButton()
    {
        leftMenu.confirmProjectUpdate.Click();
    }

    [Then(@"My project updated should be displayed on the projects list")]
    public void ThenMyProjectUpdatedShouldBeDisplayedOnTheProjectsList()
    {
        Assert.That(leftMenu.ProjectNameIsDisplayed("New project red updated"), Is.True, "ERROR! The project was not updated");
    }

    [Given(@"My project is updated")]
    public void GivenMyProjectIsUpdated()
    {
        leftMenu.ClickProjectName("New project blue");
    }

    [When(@"I click on delete button")]
    public void WhenIClickOnDeleteButton()
    {
        leftMenu.deleteProjectBtn.Click();
        leftMenu.deleteConfirmationBtn.Click();
    }

    [Then(@"The project should not be displayed")]
    public void ThenTheProjectShouldNotBeDisplayed()
    {
        Assert.That(leftMenu.ProjectNameIsDisplayed("New project blue"), Is.False, "ERROR! The project was not deleted");
        Session.Instance().CloseBrowser(); 
    }
}