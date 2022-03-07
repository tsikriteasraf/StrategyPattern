using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Core.Entities
{
   public abstract class Clothing
    {
        public IPaymentMethod paymentMethod;

        public Clothing(IPaymentMethod paymentMethod, Color color, Size size, Fabric fabric)
        {
            this.paymentMethod = paymentMethod;
            Color = color;
            Size = size;
            Fabric = fabric;
        }

        public Color Color { get; }
        public Size Size { get; }
        public Fabric Fabric { get; }

        public virtual int ColorPrice { get => (int)Color; }
        public virtual int SizePrice { get => (int)Size; }
        public virtual int FabricPrice { get => (int)Fabric; }

        public void SetPaymentMethod(IPaymentMethod paymentMethod) => this.paymentMethod = paymentMethod;
    }
}
