//Does used by EventAggregator to reserve subscription  
public class Subscription<Tmessage> : IDisposable  
{
    //public Action<Tmessage> Action { get; private set; }  
    //private readonly EventAggregator EventAggregator;  
    //private bool isDisposed;  
    //public Subscription(Action<Tmessage> action, EventAggregator eventAggregator)  
    //{  
    //    Action = action;  
    //    EventAggregator = eventAggregator;  
    //}  

    //~Subscription()  
    //{  
    //    if (!isDisposed)  
    //        Dispose();  
    //}  

    public void Dispose()
    {
        //EventAggregator.UnSbscribe(this);
        //isDisposed = true;
    }
}  
