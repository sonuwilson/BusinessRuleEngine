using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine
{
    public class EmailService : IEmailService
    {
        public void SendEmail(string email)
        {
            // code to send email
            Console.WriteLine("Mail Sent Successfully");
        }
    }
}
