using System;
using System.Collections.Generic;
using System.Text;
using static FactoryExplained.PaymentGatewayFactory;

namespace FactoryExplained
{
    public class PaymentProcessor
    {
        IPaymentGateway gateway = null;

        public void MakePayment(PaymentMethod method, Product product)
        {
            PaymentGatewayFactory factory = new PaymentGatewayFactory();
            this.gateway = factory.CreatePaymentGateway(method, product);

            this.gateway.MakePayment(product);
        }
    }
}
