using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using CustomerCommLib;
using NUnit.Framework;
namespace CustomerCommTests
{
    [TestFixture]
    public class Test
    {
        Mock<IMailSender> mock;
        CustomerComm cc;
        [OneTimeSetUp]
        public void setUp()
        {
            mock = new Mock<IMailSender>();
            cc = new CustomerComm(mock.Object);
        }
        
        [Test]
        [TestCase("abc@gmail.com","Some Message",true)]
        [TestCase("OneIT@cognizant.com", "Hi Team", true)]
        public void MailCheck(string toAddress,string message,bool expected)
        {
            mock.Setup(p => p.SendMail(toAddress, message)).Returns(true);
            bool result= cc.SendMailToCustomer("hi",message);
            Assert.AreEqual(expected, result);
           

        }


    }
}
