using System;

namespace ObserverPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            MessageSubscriberOne s1 = new MessageSubscriberOne();
            MessageSubscriberTwo s2 = new MessageSubscriberTwo();
            MessageSubscriberThree s3 = new MessageSubscriberThree();
            MessageSubscriberOne s4 = new MessageSubscriberOne();
            MessagePublisher p = new MessagePublisher();
            p.Attach(s1);
            p.Attach(s2);
            p.NotifyUpdate(new Message("Initial State")); 
            p.Detach(s1);
            p.Attach(s3);
            p.UpdateState(1);
            p.Attach(s4);
            p.UpdateState(1);

        }
    }
}
