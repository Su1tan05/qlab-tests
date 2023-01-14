using TestCommonLib.BrowserConfig;

namespace TestCommonLib.Utils;

public static class AlertUtil
{
    public static bool AlertTextIsDisplayed(string message)
    {
        LogUtils.Info($"Check is displayed text: '{message}' in js alert");
        return Browser.GetDriver().SwitchTo().Alert().Text.Contains(message);
    }
    public static void AcceptAlert()
    {
        LogUtils.Info($"Accept alert");
        Browser.GetDriver().SwitchTo().Alert().Accept();
    }
    public static void InputTextInAlert(string text)
    {
        LogUtils.Info($"Input text: '{text}' in js alert");
        Browser.GetDriver().SwitchTo().Alert().SendKeys(text);
    }
    public static string GetAlertText()
    {
        LogUtils.Info($"Get js alert text");
        return Browser.GetDriver().SwitchTo().Alert().Text;
    }
}
