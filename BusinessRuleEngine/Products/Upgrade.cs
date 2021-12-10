using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine.Products
{
    public class Upgrade : OrderFulfilment
    {
        private IEmailService _emailService;

        public Upgrade(IEmailService emailService)
        {
            _emailService = emailService;
            PaymentActions = new List<string>();
        }
        public override List<string> FulfilOrder()
        {
            PaymentActions.Add("Upgrade the membership");
            PaymentActions.Add("Send the membershipupgrademail");
            _emailService.SendEmail("Membership Upgraded");

            return PaymentActions;
        }
    }
}
