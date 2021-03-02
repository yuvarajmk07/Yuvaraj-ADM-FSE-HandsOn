using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCommLib
{
    public class CustomerComm

    {

        IMailSender _mailSender;

        public CustomerComm(IMailSender mailSender)

        {

            _mailSender = mailSender;

        }

        public bool SendMailToCustomer(string toAddress,string message)
            
        {


            return _mailSender.SendMail(toAddress, message);

        }

    }
}
