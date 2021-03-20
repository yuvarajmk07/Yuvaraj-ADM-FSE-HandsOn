using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern
{
    public interface IUser
    {
        void SendMessage(string message);
        void ReceiveMessage(string message);
    }
}
