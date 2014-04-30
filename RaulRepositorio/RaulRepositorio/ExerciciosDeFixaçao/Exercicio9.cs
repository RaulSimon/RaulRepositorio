using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6.ExerciciosDeFixaçao
{
    class Exercicio9
    {
        static void Main2(string[] args)
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
