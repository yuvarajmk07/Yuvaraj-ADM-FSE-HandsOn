using System;
using System.Collections.Generic;

namespace ObserverPatternCaseStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            NotificationService notificationService= new NotificationService();
            INotificationObserver adminObserver = new AdminObserver();
            notificationService.Subscribe(adminObserver);
            Console.WriteLine("Welcome to Cultral Event");
            Console.WriteLine("");


            //Event Name and Booked Ticket Counts//
            Dictionary<string,int> events = new Dictionary<string,int>();
            events.Add("Dance Party", 50);
            events.Add("Music Party", 98);
            events.Add("Fashion Party", 75);


            //Iterating through the List of Events/
            foreach (KeyValuePair<string, int> entry in events)
            {
                Console.WriteLine(entry.Key);    
            }
            Console.WriteLine("");


            //Book Tickets//
            Console.WriteLine("Do you want to book tickets? If so, Please enter Yes");
            string status = Console.ReadLine().ToLower();
            while (status == "yes")
            {
                Console.WriteLine("Enter the Event Name");
                string eventName = Console.ReadLine();
                Console.WriteLine("Enter the number of tickets");
                int noOfTickets = Int32.Parse(Console.ReadLine());
                int totalTickets = events[eventName]+noOfTickets;
                events[eventName] = totalTickets;
                Console.WriteLine("Do you wish to Continue?Book for any other Event");
                status = Console.ReadLine().ToLower();
            }
            Console.WriteLine("");
            Console.WriteLine("");
            

            void Notify()
            {
                foreach (KeyValuePair<string, int> entry in events)
                {
                    if (entry.Value > 100)
                    {
                        notificationService.EventName = entry.Key;
                        int differenceTickets = entry.Value - 100;
                        notificationService.EventTicketCount = differenceTickets;
                        notificationService.NotifyAdmins();
                    }
                }
            }

            //Notify Admin//
            Notify();
            //Admin Unsubscribed from Notification//
            notificationService.UnSubscribe(adminObserver);
            Notify();

        }

    }
}
