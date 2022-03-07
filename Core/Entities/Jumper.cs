using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Core.Entities
{
    public class Jumper : Clothing
    {
        public Jumper(IPaymentMethod paymentMethod, Color color, Size size, Fabric fabric) : base(paymentMethod, color, size, fabric)
        {
        }

        public override int ColorPrice { get => (int)Color * 3; }
        public override int SizePrice { get => (int)Size * 5; }
        public override int FabricPrice { get => (int)Fabric * 8; }
    }
}
