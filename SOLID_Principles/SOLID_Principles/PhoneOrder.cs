using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
   public  class PhoneOrder:IOrder
    {
        public void ProcessOrder(string modelName)
        {
            Console.WriteLine(string.Format("{0} order accepted!", modelName));
        }

    }
}
