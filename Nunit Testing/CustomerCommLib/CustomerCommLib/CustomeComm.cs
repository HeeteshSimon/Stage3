using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCommLib
{
    public class CustomeComm
    {
        IMailSender _mailSender;
        public CustomeComm(IMailSender mailSender) 
        {
            _mailSender = mailSender;
        }
        public bool SendMailToCustomer() 
        {
            _mailSender.SendMail("cust123@abc.com","Some Message");
            return true;
        }
    }
}
