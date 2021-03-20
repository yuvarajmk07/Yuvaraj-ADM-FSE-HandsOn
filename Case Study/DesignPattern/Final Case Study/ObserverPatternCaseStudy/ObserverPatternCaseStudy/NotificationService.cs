using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternCaseStudy
{
    public class NotificationService : INotificationService
    {
        public string EventName { get; set; }
        public int EventTicketCount { get; set; }
        public List<INotificationObserver> subscribers;

        public NotificationService()
        {
            subscribers = new List<INotificationObserver>();
        }

        public void Subscribe(INotificationObserver addAdmin)
        {
            subscribers.Add(addAdmin);
        }

        public void NotifyAdmins()
        {
            foreach (var i in subscribers)
            {
                i.EmailNotification(EventName,EventTicketCount);
                i.WhatsAppNotification(EventName,EventTicketCount);
                i.SMSNotification(EventName,EventTicketCount);
            }
        }

        public void UnSubscribe(INotificationObserver removeAdmin)
        {
            subscribers.Remove(removeAdmin);
        }
    }
}
