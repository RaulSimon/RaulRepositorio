using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade7.ExercicioFixaçao
{
    class ExercicioFixacao1
    {
        static void Main1(String[] args)
        {

            Random r = new Random();
            double auxValor=0;
            double mediaAr=0;
            int[] codigoProduto = new int[15];
            double[] ValorProduto = new double[15];

            for (int i = 0; i < codigoProduto.Length; i++)
            {
                codigoProduto[i] = r.Next(200,900);
                ValorProduto[i] = r.NextDouble() * 100;
                if (auxValor < ValorProduto[i])
                {
                    auxValor = ValorProduto[i];
                }
                mediaAr = ValorProduto[i] / 15;
            }
            Console.WriteLine("Maior Valor: " + auxValor);
            Console.WriteLine("Media : " + mediaAr);
            Console.ReadKey();
        }
    }
}
 