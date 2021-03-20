using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class MessageSubscriberTwo : Observer
    {
        public void update(Message m)
        {
            Console.WriteLine("MessageSubscriberTwo :: " + m.getMessageContent());
        }
    }
}
