using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternCaseStudy
{
    public class JohnObserver:INotificationObserver
    {
        public string Name { get { return "John"; } }

        public void OnServerDown()
        {
            Console.WriteLine(Name + " !! Notification has been received ");
        }
    }
}
