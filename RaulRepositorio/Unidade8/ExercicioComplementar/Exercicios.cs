using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade8.ExercicioComplementar
{
    class Exercicios
    {
        static void Main()
        {
            //NumeroAleatorio();
            hashtag();
            Console.ReadKey();
        }
        public static  Random r  = new Random();
        public static void NumeroAleatorio()
        {
            double a, b;
            a = r.NextDouble();
            b = r.NextDouble();
            Console.WriteLine("A = "+ a + " B = " + b);
            if (a > b)
            {
                Console.WriteLine("Primeiro > segundo");
            }else if (a < b )
            {
                Console.WriteLine("Segundo > primeiro");
            }
            else
            {
                Console.WriteLine("primeiro = segundo");
            }
        }

        public static void hashtag()
        {
            String soma = "", a = "**********";
            for (int i = 0; i < 3; i++)
            {


                for (int j = 0; j < 5; j++)
                {

                    
                    
                        soma = " ";
                        a = soma + a;
                        Console.WriteLine(a);

                        
                }
                a = "**********";
            }


        }

    }
 
}
