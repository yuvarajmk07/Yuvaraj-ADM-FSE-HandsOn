using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternCaseStudy
{
    public interface INotificationService
    {
        void Subscribe(INotificationObserver observer);
        void UnSubscribe(INotificationObserver observer);
        void NotifyAdmins();
    }
}
