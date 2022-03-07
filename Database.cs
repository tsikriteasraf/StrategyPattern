using Assignment3.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Database
    {
        public ICollection<Clothing> Clothing { get; set; }
        public Database(BankTransfer bank, Cash cash, CreditDebitCard card)
        {
            T_Shirt t1 = new T_Shirt(bank, Color.RED, Size.S, Fabric.COTTON);
            T_Shirt t2 = new T_Shirt(card, Color.BLUE, Size.XL, Fabric.POLYESTER);
            T_Shirt t3 = new T_Shirt(cash, Color.GREEN, Size.L, Fabric.SILK);

            Jumper j1 = new Jumper(card, Color.GREEN, Size.L, Fabric.SILK);
            Jumper j2 = new Jumper(cash, Color.BLUE, Size.L, Fabric.RAYON);
            var clothing = new List<Clothing>() { t1, t2, t3,j1,j2 };
            Clothing = clothing;
        }
    }
}
