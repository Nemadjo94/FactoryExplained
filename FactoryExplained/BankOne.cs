using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryExplained
{
    class BankOne : IPaymentGateway
    {
        public void MakePayment(Product product)
        {
            Console.WriteLine($"Using bank1 to pay for {product.Name}, amount {product.Price}");
        }
    }
}
