using BusinessRuleEngine;
using BusinessRuleEngine.Products;
using Castle.Core.Logging;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using Xunit;

namespace BusinessRuleEngineTest
{
    public class RuleEngineTest
    {
        [Fact]
        public void Test1()
        {
            OrderFulfilment orderFulfilment = new Book();
            var order = orderFulfilment.FulfilOrder();

            Assert.NotNull(order);
            Assert.Equal("Generate Packiing Slip for Shipping", order[0]);
        }

        [Fact]
        public void Test2()
        {
            var emailService = new EmailService();
            OrderFulfilment orderFulfilment = new Membership(emailService);
            var order = orderFulfilment.FulfilOrder();//
        }
    }
}