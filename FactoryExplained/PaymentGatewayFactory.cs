using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryExplained
{
    public class PaymentGatewayFactory
    {
        public enum PaymentMethod
        {
            BANK_ONE,
            BANK_TWO,
            BEST_FOR_ME,
            PAYPAL,
            BILL_DECK
        }

        public virtual IPaymentGateway CreatePaymentGateway(PaymentMethod method, Product product)
        {
            IPaymentGateway gateway = null;

            switch (method)
            {
                case PaymentMethod.BANK_ONE:
                    gateway = new BankOne();
                    break;
                case PaymentMethod.BANK_TWO:
                    gateway = new BankTwo();
                    break;
                case PaymentMethod.BEST_FOR_ME:
                    if(product.Price < 50)
                    {
                        gateway = new BankTwo();
                    }
                    else
                    {
                        gateway = new BankOne();
                    }
                    break;
            }
            return gateway;
        }
    }
}
