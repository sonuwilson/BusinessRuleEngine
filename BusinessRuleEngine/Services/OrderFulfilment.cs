using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine
{
    public abstract class OrderFulfilment
    {
        public List<string> PaymentActions { get; set; }
        public abstract List<string> FulfilOrder();
    }
}
