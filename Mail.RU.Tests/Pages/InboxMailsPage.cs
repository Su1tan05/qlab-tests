using Mail.RU.Tests.Pages.Popups;
using OpenQA.Selenium;
using TestCommonLib.BrowserConfig;
using TestCommonLib.Elements;
using TestCommonLib.Pages;

namespace Mail.RU.Tests.Pages;

public class InboxMailsPage : BasePage
{
    public static By WriteMailButtonLocator = By.XPath(".//div[contains(@class, 'sidebar__header')]//a");

    public InboxMailsPage() : base(WriteMailButtonLocator, "Inbox page")
    {
    }

    private Button WriteMailButton => new Button(WriteMailButtonLocator, "Write mail button");

    public WriteMailPopup WriteMail()
    {
        this.ClosePromoTabs();
        this.WriteMailButton.Click();
        return new WriteMailPopup();
    }

    public void ClosePromoTabs()
    {
        var promoTabs = Browser.GetDriver().FindElements(By.XPath(".//div[@data-click-counter]"));
        foreach (var promoTab in promoTabs)
        {
            promoTab.Click();
        }
    }
}