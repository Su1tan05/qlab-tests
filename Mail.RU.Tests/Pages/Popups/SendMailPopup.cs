
using OpenQA.Selenium;
using TestCommonLib.Elements;
using TestCommonLib.Pages;

namespace Mail.RU.Tests.Pages.Popups;

public class SendMailPopup : BasePage
{
    public static By SendMailInfoLocator = By.XPath(".//*[text()[contains(.,'Письмо')]]");

    public SendMailPopup() : base(SendMailInfoLocator, "Write mail popup")
    {
        
    }

    public TextBox SendMailInfo => new TextBox(SendMailInfoLocator, "Send mail info");

    public string GetInfo() => SendMailInfo.GetText();
}