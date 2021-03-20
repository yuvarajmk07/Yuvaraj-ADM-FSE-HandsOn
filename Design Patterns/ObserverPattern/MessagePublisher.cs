using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class MessagePublisher : Subject
    {
        
        private List<Observer> observers = new List<Observer>();

        private int getState = 1;

        public int GetState { get => getState; set => getState=value; }

        public void Attach(Observer o)
        {
            observers.Add(o);
        }

        public void Detach(Observer o) {
            observers.Remove(o);
        }


        public void NotifyUpdate(Message m) {
            foreach(Observer o in observers)
            {
                o.update(m);
                
            }
        }
        public void UpdateState(int stateValue)
        {
            if (stateValue==getState)
            { 
                NotifyUpdate(new Message("State is Updated"));
            }
        }
    }
}