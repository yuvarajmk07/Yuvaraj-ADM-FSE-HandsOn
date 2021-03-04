using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListEmployeesPartial.Models
{
   
        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public double Salary { get; set; }
            public bool IsPermanent { get; set; }
        }
    
}
