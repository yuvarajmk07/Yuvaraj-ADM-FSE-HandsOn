using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
    class PhoneRepair : IPhoneRepair,IAccessoryRepair
    {
        public void ProcessAccessoryRepair(string accessoryType)
        {
            Console.WriteLine(string.Format("{0} repair accepted!", accessoryType));
        }
        
        public void ProcessPhoneRepair(string modelName)
        {
            Console.WriteLine(string.Format("{0} repair accepted!", modelName));
        }
    }
}
