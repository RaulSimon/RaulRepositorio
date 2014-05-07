using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade7.Operadores
{
    class Decremento
    {
        static void Main3(String[] args)
        {
            int i = 0;
            i++;
            i--;
            int b = 100;
            b = ++i +i --;
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
