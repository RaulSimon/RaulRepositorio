using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade7.ExercicioFixaçao
{
    class ExercicioFixacao3
    {
        static void Main3(String[] args)
        {
            int totalMercadorias;
            Console.WriteLine("Total mercadoria ?");
            totalMercadorias = int.Parse(Console.ReadLine());
            double[] valorMercadoria = new double[totalMercadorias];
            Double soma = 0;

            for (int i = 0; i < valorMercadoria.Length; i++)
            {
                Console.WriteLine("Valor de mercadoria " + i + " : ");
                valorMercadoria[i] = double.Parse(Console.ReadLine());
                soma += valorMercadoria[i];
            }
            Console.WriteLine("Valor total de estoque: " + soma);
            Console.ReadKey();
        }
    }
}
