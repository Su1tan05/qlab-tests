using Mail.RU.Tests.Models;
using OpenQA.Selenium;
using TestCommonLib.Elements;
using TestCommonLib.Pages;

namespace Mail.RU.Tests.Pages.Popups;

public class WriteMailPopup : BasePage
{
    public static readonly By ToTextBoxLocator = By.XPath(".//div[@data-type='to']//input");

    public WriteMailPopup() : base(ToTextBoxLocator, "Write mail popup")
    {
    }
    
    public TextBox ToTextBox => new TextBox(ToTextBoxLocator, "To text box");

    public TextBox SubjectTextBox => new TextBox(By.XPath(".//input[@name='Subject']"), "Subject text box");

    public TextBox MailBodyTextBox => new TextBox(By.XPath(".//div[@role='textbox']"), "Mail body text box");

    public Button SendButton => new Button(By.XPath(".//button[@data-test-id='send']"), "Send button");

    public void Send(string recipient, string subject, string mailBody)
    {
        this.InputRecipient(recipient);
        this.InputSubject(subject);
        this.InputMailBody(mailBody);
        this.ClickSendButton();
    }

    public SendMailPopup Send(MailData mailData)
    {
        this.Send(mailData.To, mailData.Subject, mailData.Body);
        return new SendMailPopup();
    }

    public void InputRecipient(string recipient)
    {
        this.ToTextBox.SendKeys(recipient);
    }

    public void InputSubject(string subject)
    {
        this.SubjectTextBox.SendKeys(subject);
    }

    public void InputMailBody(string mailBody)
    {
        this.MailBodyTextBox.Clear();
        this.MailBodyTextBox.SendKeys(mailBody);
    }

    public void ClickSendButton()
    {
        this.SendButton.Click();
    }
}