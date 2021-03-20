using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern
{
    public class ChatMediator:IChatMediator
    {
        List<IUser> users;

        public ChatMediator()
        {
            users = new List<IUser>();

        }

        public void AddUser(IUser user)
        {
            users.Add(user);
        }

        public void SendMessage(string message,IUser sender)
        {
            foreach(var user in users)
            {
                if (user!= sender)
                {
                    user.ReceiveMessage(message);
                }
            }
        }
    }
}
