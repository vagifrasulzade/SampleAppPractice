namespace SampleAppPractice.Models;

public interface IMessageFactory
{
    SmtpMessage Create(string message);
}
