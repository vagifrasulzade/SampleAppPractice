namespace SampleAppPractice.Models;

public class Messanger : IMessanger
{
    private readonly ISmtpClient _client;
    private readonly IMessageFactory _factory;

    public Messanger(ISmtpClient client, IMessageFactory factory)
    {
        _client = client;
        _factory = factory;
    }

    public void SendMessage(string message, string user)
    {
        SmtpMessage smtpMessage = _factory.Create(message);
        _client.Send(smtpMessage);
    }
}