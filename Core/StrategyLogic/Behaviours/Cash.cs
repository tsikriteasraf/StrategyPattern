using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Cash : IPaymentMethod
    {
        public double Payment(int ColorPrice, int SizePrice, int FabricPrice)
        {
            return (ColorPrice + SizePrice + SizePrice) ;
        }
    }
}
