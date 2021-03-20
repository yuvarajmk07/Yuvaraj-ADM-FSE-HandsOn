using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public interface Subject
    {
        public void Attach(Observer o);
        public void Detach(Observer o);
        public void NotifyUpdate(Message m);
        public int GetState { get; set; }
    }
}
