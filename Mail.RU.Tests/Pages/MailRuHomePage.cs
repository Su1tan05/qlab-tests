using OpenQA.Selenium;
using TestCommonLib.Elements;
using TestCommonLib.Pages;
using Mail.RU.Tests.Pages.Popups;

namespace Mail.RU.Tests.Pages;

public class MailRuHomePage : BasePage
{
    private static readonly By LoginButtonLocator = By.XPath(".//button[@data-testid='enter-mail-primary']");

    public MailRuHomePage() : base(LoginButtonLocator, "Mail.ru home page")
    {
    }

    private Button LoginButton => new Button(LoginButtonLocator, "Login button"); 

    public LoginPopup LoginPopup()
    {
        LoginButton.Click();
        return new LoginPopup();
    } 
}