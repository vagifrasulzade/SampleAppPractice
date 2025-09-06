namespace SampleAppPractice.Models;

public class MessageFactory
{
    internal SmtpMessage Create(string message)
    {
        return new SmtpMessage() { Body = message };
    }
}
