using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern
{
    public class BasicUser:IUser
    {
        string name;
        IChatMediator chatMediator;

        public BasicUser(IChatMediator chatMediator, string userName)
        {
            this.name = userName;
            this.chatMediator = chatMediator;
        }

        public void SendMessage(string message)
        {
            chatMediator.SendMessage(message, this);
        }

        public void ReceiveMessage(string message)
        {
            Console.WriteLine("Receiver name:{0} \n Message Content:{1}", name, message);
        }
    }
}
