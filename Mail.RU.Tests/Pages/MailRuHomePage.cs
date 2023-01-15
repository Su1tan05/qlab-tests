using OpenQA.Selenium;
using TestCommonLib.Elements;
using TestCommonLib.Pages;
using Mail.RU.Tests.Pages.Popups;
using Mail.RU.Tests.Enums;
using TestCommonLib.DataProvider;
using Mail.RU.Tests.Models;

namespace Mail.RU.Tests.Pages;

public class MailRuHomePage : BasePage
{
    private static readonly By LoginButtonLocator = By.XPath(".//button[@data-testid='enter-mail-primary']");

    private TestData TestData = TestDataProvider.GetData<TestData>("TestData.json");

    public MailRuHomePage() : base(LoginButtonLocator, "Mail.ru home page")
    {
    }

    private Button LoginButton => new Button(LoginButtonLocator, "Login button"); 

    public LoginPopup LoginPopup()
    {
        LoginButton.Click();
        return new LoginPopup();
    }

    public void Login(User user)
    {
        switch (user)
        {
            case User.CommonUser:
                LoginPopup().Login(TestData.Users.CommonUser.Login, TestData.Users.CommonUser.Password);
                break;
        }
    }    
}