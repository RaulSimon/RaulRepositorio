using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade7.ExercicioFixaçao
{
    class ExercicioFixacao4
    {
        static void Main(String[] args)
        {
            String palavra= "12345";
            char[] aux = palavra.ToCharArray();
            Console.WriteLine(palavra);
            for (int i = 0; i < aux.Length; i++)
            {
                 Console.Write(aux[i]);
                for (int j = 4; j < aux.Length; j--)
                {
                    
                    Console.Write(aux[j]);
                    for (int a = 2; a < aux.Length; a++)
                    {

                        Console.Write(aux[a]);

                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
