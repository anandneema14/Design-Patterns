namespace PubSub.ImplementationWIthEvent.Abstract;

public interface IPublisher<T>
{
    event EventHandler<MessageArgument<T>> DataPublisher;  
    void OnDataPublisher(MessageArgument<T> args);  
    void PublishData(T data);  
}