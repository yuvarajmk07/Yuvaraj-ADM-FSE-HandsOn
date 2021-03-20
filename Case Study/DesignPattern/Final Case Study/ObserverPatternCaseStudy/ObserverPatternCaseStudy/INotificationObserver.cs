using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternCaseStudy
{
    public interface INotificationObserver
    {
         void EmailNotification(string EventName,int EventTicketCounts);
         void WhatsAppNotification(string EventName, int EventTicketCounts);
         void SMSNotification(string EventName, int EventTicketCounts);
    }
}
