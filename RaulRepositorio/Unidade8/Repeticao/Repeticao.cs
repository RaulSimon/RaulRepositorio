using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade8.Repeticao
{
    class Repeticao
    {
        static void Main(String[] args)
        {
            imprime100numeros();
            Console.ReadKey();
        }

        public static void imprime100numeros()
        {
            

            for (int i = 0; i < 100; i++)
            {
                
                Console.WriteLine(i);
            }
        }
    }
}
