using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine.Products
{
    public class Membership : OrderFulfilment
    {
        private IEmailService _emailService;

        public Membership(IEmailService emailService)
        {
            _emailService = emailService;
            PaymentActions = new List<string>();
        }
        public override List<string> FulfilOrder()
        {
            PaymentActions.Add("Activate the membership");
            PaymentActions.Add("Send the membership activate mail");
            _emailService.SendEmail("Membership activated");
            return PaymentActions; ;
        }
    }
}
