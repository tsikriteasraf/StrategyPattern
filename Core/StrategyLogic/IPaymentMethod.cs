using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
   public interface IPaymentMethod
    {
        double Payment(int ColorPrice, int SizePrice, int FabricPrice);
    }
}
