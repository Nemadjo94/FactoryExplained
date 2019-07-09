using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryExplained
{
    class PayPal : IPaymentGateway
    { 
        public void MakePayment(Product product)
        {
            Console.WriteLine($"Using PayPal to pay for {product.Name}, amount {product.Price}");
        }
    }
}
