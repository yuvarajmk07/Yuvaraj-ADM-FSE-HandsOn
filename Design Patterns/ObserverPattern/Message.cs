using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class Message
    {
        string messageContent;

        public Message(String m) {

            this.messageContent = m; 

        }

        public String getMessageContent() { 

            return messageContent; 
        }
    }
}
