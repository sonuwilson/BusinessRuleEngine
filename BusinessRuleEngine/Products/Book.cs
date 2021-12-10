using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine
{
    public class Book : PhysicalProduct, IGeneratePackingSlipForRoyaltyDepartment
    {
        
        public override List<string> FulfilOrder()
        {
            base.FulfilOrder();
            GeneratePackingSlipForRoyaltyDepartment();
            return PaymentActions;
        }
        public void GeneratePackingSlipForRoyaltyDepartment()
        {
            PaymentActions.Add("Generate Packaging Slip for Royalty Department");
        }
    }
}
