using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedParameters
{
    class Program
    {
        public static void GetCohortDetails(string cohort_Name, string genc_Count, string mode, string track, string current_Module)
        {
            Console.WriteLine("It is {0} with {1} GenCs undergoing training for {2} thru {3}.The current module of training is {4}",cohort_Name,genc_Count,mode,track,current_Module) ;
        }
        static void Main(string[] args)
        {
            GetCohortDetails("ADM", "21", "OBL", ".Net", "Threads");
            GetCohortDetails(mode: "OBL", track: ".Net", cohort_Name:"ADM",current_Module:"Threads",genc_Count:"21");
            Console.ReadLine();


        }
    }
}
