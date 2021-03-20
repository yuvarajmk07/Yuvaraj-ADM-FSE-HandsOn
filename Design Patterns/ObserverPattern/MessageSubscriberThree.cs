using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class MessageSubscriberThree : Observer
    {
        public void update(Message m)
        {
            Console.WriteLine("MessageSubscriberThree :: " + m.getMessageContent());
        }
    }
}
