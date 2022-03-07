using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Views
{
    public class GeneralView
    {
        public static void ViewItemsPrice(List<double> items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
