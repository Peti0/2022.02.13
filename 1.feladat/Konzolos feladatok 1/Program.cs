using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konzolos_feladatok_1
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem adjon meg egy számot!");
            Console.WriteLine();
            int n =Convert.ToInt32(Console.ReadLine());




            if (n % 3 == 0)
                Console.WriteLine("A szám osztható hárommal");
            if (n % 4 == 0)
                Console.WriteLine("A szám osztható négyel");
            if (n % 9 == 0)
                Console.WriteLine("A szám osztható kilencel");




            Console.ReadKey();

            
        }
        
    }
}
