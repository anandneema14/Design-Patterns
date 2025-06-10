namespace PubSub.ImplementationWIthEvent;

/// <summary>
/// Implementation of PubSub with Event
/// </summary>
/// <param name="message"></param>
/// <typeparam name="T"></typeparam>
public class MessageArgument<T>(T message) : EventArgs
{
    public T Message { get; set; } = message;
}