using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternCaseStudy
{
    public interface INotificationObserver
    {
        public string Name { get;}
        public void OnServerDown();
    }
}
