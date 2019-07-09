using System;
using System.Collections.Generic;
using System.Text;
using static FactoryExplained.PaymentGatewayFactory;

namespace FactoryExplained
{
    public class PaymentProcessor2
    {
        IPaymentGateway gateway = null;

        public void MakePayment(PaymentMethod method, Product product)
        {
            PaymentGatewayFactory2 factory2 = new PaymentGatewayFactory2();
            this.gateway = factory2.CreatePaymentGateway(method, product);

            this.gateway.MakePayment(product);
        }
    }
}
