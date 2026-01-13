public class PhoneCall
{
    public delegate void Notify();
    public event Notify PhoneCallEvent;
    public string Message{get; private set;}
    private void OnSubscribe()
    {
        Message = "Subscribed to Call";
    }
    private void OnUnsubscribe()
    {
        Message = "Unsubscribed to Call";
    }

    //event trigger method
    public void MakePhoneCall(bool notify)
    {
        PhoneCallEvent = null;
        if (notify)
        {
            PhoneCallEvent += OnSubscribe;
        }
        else
        {
            PhoneCallEvent += OnUnsubscribe;
        }
        PhoneCallEvent?.Invoke();
    }
}