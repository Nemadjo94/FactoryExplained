using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryExplained
{
    class PaymentGatewayFactory2 : PaymentGatewayFactory
    {
        public virtual IPaymentGateway CreatePaymentGateway(PaymentMethod method, Product product)
        {
            IPaymentGateway gateway = null;

            switch (method)
            {
                case PaymentMethod.PAYPAL:
                    gateway = new PayPal();
                    break;
                case PaymentMethod.BILL_DECK:
                    gateway = new BillDesk();
                    break;
            }

            return gateway;
        }
    }
}
