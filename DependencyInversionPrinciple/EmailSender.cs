using DependencyInversionPrinciple.Interfaces;

namespace DependencyInversionPrinciple;

public class EmailSender : ISender
{
    public void SendMessage(string text)
    {
        Console.WriteLine($"Sending message: {text}");
    }
}