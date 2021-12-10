using BusinessRuleEngine.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine.Products
{
    public class Video : OrderFulfilment,IGeneratePackingSlip
    {
        public string Title { get; set; }
        public Video(string title)
        {
            Title = title;
            PaymentActions = new List<string>();
        }
        public override List<string> FulfilOrder()
        {
            GeneratePackingSlip();
            foreach (var offer in ComboOffers.GetVideoOffers())
            {
                if(offer.Key.ToLower() == Title.ToLower())
                {
                    PaymentActions.Add(offer.Value);
                }
            }

            return PaymentActions;
                
        }

        public void GeneratePackingSlip()
        {

            PaymentActions.Add("Generate Packiing Slip for Shipping");
        }
    }
}
