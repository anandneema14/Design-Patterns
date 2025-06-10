using PubSub.ImplementationWIthEvent.Abstract;

namespace PubSub.ImplementationWIthEvent.Concrete;

public class Subscriber<T>(IPublisher<T> publisher)
{
    public IPublisher<T> Publisher { get; private set; } = publisher;
}