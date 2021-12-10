using BusinessRuleEngine.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine
{
    public class PhysicalProduct : OrderFulfilment, IGeneratePackingSlip, IGenerateAgentCommission
    {
     
        public PhysicalProduct()
        {
            PaymentActions = new List<string>();
        }
        public override List<string> FulfilOrder()
        {
            GeneratePackingSlip();
            GenerateAgentCommision();
            return PaymentActions;
        }

        public void GenerateAgentCommision()
        {
            PaymentActions.Add("Generate Agent Commision");
        }

        public void GeneratePackingSlip()
        {
            PaymentActions.Add("Generate Packiing Slip for Shipping");
        }
    }
}
