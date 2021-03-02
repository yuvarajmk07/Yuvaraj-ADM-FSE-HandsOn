using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameter
{
    class Program
    {
        public static void OrderDetails(string seller_Name,string product_Name,int order_Quantity=1,bool is_Returnable = true)
        {
            Console.WriteLine("Here is the order detail – {0} number of {1} by {2} is ordered. It’s returnable status is {3}",order_Quantity,product_Name,seller_Name,is_Returnable);
        }
        static void Main(string[] args)
        {
            OrderDetails("EKart", "Mobile Phone", 10, true);
            OrderDetails("EKart", "Laptop");
            Console.ReadLine();
        }
    }
}
