using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade8.Repeticao
{
    class Repeticao
    {
        static void Main1(String[] args)
        {
            //  imprime100numeros();
            //imprime100MenosMutiplosDe3();
            //MaiorNumeroInteiro();
            //JogoDeDados2();
            Castigo(20);
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
                if (i % 3 == 0)
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
            int maior = 2147483647;
            Console.WriteLine(maior);
            while (maior > 100)
            {
                maior = maior / 2;
                Console.WriteLine(maior);

            }
        }

        public static void JogoDeDados()
        {
            Random r = new Random();
            int dado, soma = 0;
            for (int i = 0; i < 5; i++)
            {
                dado = r.Next(1, 7);
                soma += dado;
                if (soma > 19)
                {
                    Console.WriteLine("Maior que 19" + soma);
                    break;

                }
            }
            Console.WriteLine("Final das 5 jogadas: " + soma);
        }

        public static void JogoDeDados2()
        {
            Random r = new Random();
            int dado, soma = 0;
            for (int i = 0; i < 4; i++)
            {
                dado = r.Next(1, 7);
                if (dado % 2 == 1)
                {


                    soma += dado;
                }

                if (soma > 9)
                {
                    Console.WriteLine("Maior que 9 : " + soma);
                    break;

                }
            }
            Console.WriteLine("Final das 4 jogadas: " + soma);
        }

        public static void Castigo(int quantidadeDeCastigo)
        {
            for (int i = 0; i < quantidadeDeCastigo; i++)
            {
            Console.WriteLine( "Eu nao vou mais andar de skate nos corredores ");    
            }
            
        }
    }
}
