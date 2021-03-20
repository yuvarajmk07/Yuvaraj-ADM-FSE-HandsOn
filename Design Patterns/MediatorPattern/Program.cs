using System;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IChatMediator chatMediator = new ChatMediator();
            IUser Mark = new BasicUser(chatMediator, "Mark");
            IUser Jeff = new PremiumUser(chatMediator, "Jeff");
            IUser Elon = new PremiumUser(chatMediator, "Elon");
            chatMediator.AddUser(Mark);
            chatMediator.AddUser(Jeff);
            chatMediator.AddUser(Elon);
            Console.WriteLine("Message sent from Mark");
            Mark.SendMessage("Hey Everybody!I Invite you all for my Party");
            Console.WriteLine("Message sent from Elon");
            Elon.SendMessage("Shall we go to Mark's Party");
            Console.WriteLine("Message sent from Jeff ");
            Jeff.SendMessage("Yes!! We will go ");
            Console.ReadLine();
        }
    }
}
