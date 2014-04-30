using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6.ExerciciosDeFixaçao
{
    class Exercicio8
    {
        static void Main1(string[] args)
        {
            Random r = new Random();
            String[] vendedor = new String[3];
            double[] valorVendas = new double[3];

            for (int i = 0; i < vendedor.Length; i++)
            {
                valorVendas[i] = r.Next(1, 100000);
                vendedor[i] = Console.ReadLine();

                if (valorVendas[i] > 50000)
                {
                    valorVendas[i] = valorVendas[i] * 0.12;
                    Console.WriteLine(valorVendas[i]);
                }
                else if (valorVendas[i] < 50000 && valorVendas[i] > 30000)
                {
                    valorVendas[i] = valorVendas[i] * 0.9;
                    Console.WriteLine(valorVendas[i]);
                }
                else
                {
                    valorVendas[i] = valorVendas[i] * 0.7;
                    Console.WriteLine(valorVendas[i]);
                }
            }
        }
    }
}
