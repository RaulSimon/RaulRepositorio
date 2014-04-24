using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int c = 12;

            if (a + b > c)
            {
                Console.WriteLine("maior");
            }
            else if (a + b < c)
            {
                Console.WriteLine("menor");
            }
            else
            {
                Console.WriteLine("igual");
            }
            Console.ReadKey();
        }
    }
}
