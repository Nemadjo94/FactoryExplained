using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryExplained
{
    class BankTwo : IPaymentGateway
    {
        public void MakePayment(Product product)
        {
            Console.WriteLine($"Using bank2 to pay for {product.Name}, amount {product.Price}");
        }
    }
}
