using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternCaseStudy
{
    public class AdminObserver : INotificationObserver
    {
        public void EmailNotification(string EventName, int EventTicketCount)
        {
            Console.WriteLine("Email Notification\nSub:Ticket Count Limit Exceeded.\nHi Admin,\nTicket Count for the event {0} exceeded.More {1} has been booked",EventName,EventTicketCount);
            Console.WriteLine("");
        }

        public void SMSNotification(string EventName, int EventTicketCount)
        {
            Console.WriteLine("SMS Notification\nTicket Count exceeded for the event {0}.More {1} has been booked",EventName,EventTicketCount);
            Console.WriteLine("");
        }

        public void WhatsAppNotification(string EventName, int EventTicketCount)
        {
            Console.WriteLine("WhatsApp Notification\nTicket Count exceeded for the event {0}.More {1} has been booked",EventName,EventTicketCount);
            Console.WriteLine("");
        }
    }
}
