using System.Diagnostics;

namespace SampleAppPractice.Models;

public class SmtpClient : ISmtpClient
{
    private readonly SmtpSettings _settings;

    public SmtpClient(SmtpSettings settings)
    {
        _settings = settings;
    }

    public void Send(SmtpMessage smtpMessage)
    {
        Debug.WriteLine("Message sent by SmtpClient.");
    }


}


