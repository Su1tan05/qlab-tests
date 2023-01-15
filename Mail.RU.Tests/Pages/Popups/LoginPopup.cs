using OpenQA.Selenium;
using TestCommonLib.Elements;
using TestCommonLib.BrowserConfig;
using Mail.RU.Tests.Enums;
using Mail.RU.Tests.Models;
using TestCommonLib.DataProvider;

namespace Mail.RU.Tests.Pages.Popups;

public class LoginPopup
{
    public LoginPopup()
    {
    }

    private Spinner Spinner => new Spinner(By.XPath(".//div[@class='ag-popup__frame__layout__loader']"), "Login pupup spinner"); 

    private TextBox UserNameTextBox => new TextBox(By.XPath(".//input[@name='username']"), "UserName TextBox"); 

    private TextBox PasswordTextBox => new TextBox(By.XPath(".//input[@name='password']"), "Password TextBox"); 
    
    private Button NextButton => new Button(By.XPath(".//button[@data-test-id='next-button']"), "Next button"); 

    private Button SubmitButton => new Button(By.XPath(".//button[@data-test-id='submit-button']"), "Submit button"); 

    private IWebElement PopupFrame = Browser.GetDriver().FindElement(By.XPath("//iframe[contains(@class,'popup')]"));

    private TestData TestData = TestDataProvider.GetData<TestData>("TestData.json");

    public InboxMailsPage AuthorizeUser(string username, string password)
    {
        Browser.GetDriver().SwitchTo().Frame(PopupFrame);
        this.inputUserName(username);
        this.ClickNextButton();
        this.inputPassword(password);
        this.ClickSubmitButton();
        Browser.GetDriver().SwitchTo().DefaultContent();
        return new InboxMailsPage();
    }

    public InboxMailsPage AuthorizeUser(User user) => user switch
    {
        User.DefaultUser => this.AuthorizeUser(TestData.Users.DefaultUser.Username, 
                                                TestData.Users.DefaultUser.Password),
        _ => throw new Exception("User is not defined")
    };

    public void inputUserName(string username)
    {
        Spinner.WaitElementDisappear();
        UserNameTextBox.SendKeys(username);
    }

    public void inputPassword(string password)
    {
        PasswordTextBox.SendKeys(password);
    }

    public void ClickNextButton()
    {
        NextButton.ClickAndWait(SubmitButton.GetLocator());
    }

    public void ClickSubmitButton()
    {
        SubmitButton.Click();
    }

}