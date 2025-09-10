namespace SampleAppPractice.Models;

public interface ISmtpClient
{
    void Send(SmtpMessage smtpMessage);
}
