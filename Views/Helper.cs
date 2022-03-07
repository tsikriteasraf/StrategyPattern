using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Views
{
    public class Helper
    {
        public static List<double> ListCreator(Database db)
        {
            List<double> list = new List<double>();
            foreach (var item in db.Clothing)
            {
                list.Add(item.paymentMethod.Payment(item.ColorPrice, item.SizePrice, item.FabricPrice));
            }
            return list;
        }
    }
}
