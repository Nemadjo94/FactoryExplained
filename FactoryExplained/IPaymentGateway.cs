using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryExplained
{
    //This interface defines the contract that all the payments gateways should conform to
        public interface IPaymentGateway
    {
        void MakePayment(Product product);
    }
}
