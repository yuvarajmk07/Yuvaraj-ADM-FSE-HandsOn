using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternCaseStudy
{
    public class NotificationService:INotificationService
    {
        public List<INotificationObserver> subscribers;

        public NotificationService()
        {
            subscribers = new List<INotificationObserver>();
        }

        public void AddSubscriber(INotificationObserver name)
        {
            subscribers.Add(name);
        }

        public void NotifySubscriber()
        {
           foreach(var i in subscribers)
            {
                i.OnServerDown();
            }
        }

        public void RemoveSubscriber(INotificationObserver name)
        {
            subscribers.Remove(name);
        }
    }
}
