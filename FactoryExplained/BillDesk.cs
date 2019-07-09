using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryExplained
{
    class BillDesk : IPaymentGateway
    {
        public void MakePayment(Product product)
        {
            Console.WriteLine($"Using BillDesk to pay for {product.Name}, amount {product.Price}");
        }
    }
}
