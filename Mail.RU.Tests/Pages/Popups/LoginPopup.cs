using TestCommonLib.Pages;
using OpenQA.Selenium;
using TestCommonLib.Elements;
using TestCommonLib.BrowserConfig;

namespace Mail.RU.Tests.Pages.Popups;

public class LoginPopup : MailRuHomePage
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

    public void Login(string login, string password)
    {
        Browser.GetDriver().SwitchTo().Frame(PopupFrame);
        Spinner.WaitElementDisappear();
        UserNameTextBox.SendKeys(login);
        NextButton.ClickAndWait(SubmitButton.GetLocator());
        PasswordTextBox.SendKeys(password);
        SubmitButton.Click();
        Browser.GetDriver().SwitchTo().DefaultContent();
    }
}