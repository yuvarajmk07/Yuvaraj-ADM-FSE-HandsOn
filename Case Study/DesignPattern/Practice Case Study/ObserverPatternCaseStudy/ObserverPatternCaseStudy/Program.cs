using System;

namespace ObserverPatternCaseStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            INotificationService notificationObserver = new NotificationService();
            INotificationObserver johnObserver = new JohnObserver();
            INotificationObserver steveObserver = new SteveObserver();
            Console.WriteLine("Subscriber's Added");
            notificationObserver.AddSubscriber(johnObserver);
            notificationObserver.AddSubscriber(steveObserver);
            notificationObserver.NotifySubscriber();
            Console.WriteLine("John is removed from Subscrber's list");
            notificationObserver.RemoveSubscriber(johnObserver);
            notificationObserver.NotifySubscriber();
        }
    }
}
