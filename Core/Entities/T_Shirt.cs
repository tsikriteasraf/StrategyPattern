using Assignment3.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class T_Shirt:Clothing
    {
        public T_Shirt(IPaymentMethod paymentMethod, Color color, Size size, Fabric fabric) : base(paymentMethod, color, size, fabric)
        {
        }
        public override int ColorPrice { get => (int)Color * 2; }
        public override int SizePrice { get => (int)Size*3; }
        public override int FabricPrice { get => (int)Fabric*5; }
    }
}
