using PubSub.ImplementationWIthEvent.Abstract;
using PubSub.ImplementationWIthEvent.Concrete;

namespace PubSub.ImplementationWIthEvent;

public class Client
{
    private readonly IPublisher<int> intPublisher;
    private readonly IPublisher<float> floatPublisher;
    private readonly Subscriber<int> intSubscriber;  
    private readonly Subscriber<float> floatSubscriber;

    public Client()
    {
        intPublisher = new Publisher<int>();//create publisher of type integer
        floatPublisher = new Publisher<float>();//create publisher of type float
   
        intSubscriber = new Subscriber<int>(intPublisher);//subscriber 1 subscribe to integer publisher  
        intSubscriber.Publisher.DataPublisher += publisher_DataPublisher1;//event method to listen publish data  
   
        floatSubscriber = new Subscriber<float>(floatPublisher);//subscriber 2 subscribe to float publisher  
        floatSubscriber.Publisher.DataPublisher += publisher_DataPublisher2;//event method to listen publish data  
   
        intPublisher.PublishData(10); // publisher publish message
        floatPublisher.PublishData(10.5f); // publisher publish message
    }
    
    void publisher_DataPublisher1(object? sender, MessageArgument<int> e)  
    {  
        Console.WriteLine("Subscriber 1 : " + e.Message);  
    }  
   
    void publisher_DataPublisher2(object? sender, MessageArgument<float> e)  
    {  
        Console.WriteLine("Subscriber 2 : " + e.Message);  
    }  
}