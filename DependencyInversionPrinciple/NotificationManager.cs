using DependencyInversionPrinciple.Interfaces;

namespace DependencyInversionPrinciple;

public class NotificationManager
{
    private readonly ISender _sender;
    public NotificationManager(ISender sender)
    {
        _sender = sender;
    }

    public void SendMessage(string text)
    {
        _sender.SendMessage(text);
    }
}