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
           // imprime100numeros();
            //imprime100MenosMutiplosDe3();
            MaiorNumeroInteiro();
            Console.ReadKey();
        }

        public static void imprime100numeros()
        {
            

            for (int i = 0; i < 100; i++)
            {
                
                Console.WriteLine(i);
            }
        }

        public static void imprime100MenosMutiplosDe3()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i%3 == 0)
                {
                    continue;
                    
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void MaiorNumeroInteiro()
        {
            int maior = 999999999;
            Console.WriteLine(maior);
            while (maior > 100)
            {
                maior = maior/2;
                Console.WriteLine(maior);

            }
        }
    }
}
