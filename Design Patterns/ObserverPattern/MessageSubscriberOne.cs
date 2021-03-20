using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class MessageSubscriberOne : Observer
    {
    public void update(Message m)
    {
       Console.WriteLine("MessageSubscriberOne :: " + m.getMessageContent());
    }
}
}
