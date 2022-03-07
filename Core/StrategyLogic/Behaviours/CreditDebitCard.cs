using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class CreditDebitCard : IPaymentMethod
    {
        public double Payment(int ColorPrice, int SizePrice, int FabricPrice)
        {
            return (ColorPrice + SizePrice + SizePrice) * 1.5;
        }
    }
}
