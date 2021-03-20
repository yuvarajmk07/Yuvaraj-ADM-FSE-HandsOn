using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternCaseStudy
{
    public class SteveObserver : INotificationObserver
    {
        public string Name { get { return "Steve"; } }

        public void OnServerDown()
        {
            Console.WriteLine(Name + " !! Notification has been received ");
        }
    }
}
