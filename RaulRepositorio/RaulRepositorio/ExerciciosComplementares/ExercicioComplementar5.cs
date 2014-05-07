using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6.ExerciciosComplementares
{
    class ExercicioComplementar5
    {
        static void Main5(string[] args)
        {
            int AuxVet = 99;
            int[] vetNumero = new int[AuxVet];
            int[] vetIdade = new int[AuxVet];
            double[] vetLaranjasColhidas = new double[AuxVet];
            String Condicao = "Continue";
            for (int i = 0; i < vetLaranjasColhidas.Length; i++)
            {
                Console.WriteLine("Numero Trabalhador: ");
                vetNumero[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Idade Trabalhador : ");
                vetIdade[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Laranhas Colhidas ? ");
                vetLaranjasColhidas[i] = double.Parse(Console.ReadLine());
                if (vetLaranjasColhidas[i] < 6)
                {
                    vetLaranjasColhidas[i] = vetLaranjasColhidas[i] * 2;
                }
                else if (vetLaranjasColhidas[i] < 11)
                {
                    vetLaranjasColhidas[i] = vetLaranjasColhidas[i] * 2.5;
                }
                else if (vetLaranjasColhidas[i] < 21)
                {
                    vetLaranjasColhidas[i] = vetLaranjasColhidas[i] * 3.5;
                }
                else if (vetLaranjasColhidas[i] > 20)
                {
                    vetLaranjasColhidas[i] = vetLaranjasColhidas[i] * 5;
                }

                if (vetIdade[i] > 17 && vetIdade[i] < 46)
                {
                    vetLaranjasColhidas[i] = vetLaranjasColhidas[i] * 1.10;
                }
                else if (vetIdade[i] > 44 && vetIdade[i] < 66)
                {
                    vetLaranjasColhidas[i] = vetLaranjasColhidas[i] * 1.20;
                }
                Console.WriteLine("O Trabalhador {0} receberá {1} ", vetNumero[i], vetLaranjasColhidas[i]);

                Console.WriteLine("Deseja cadastrar mais um trabalhador?");

                Condicao = Console.ReadLine();
                if (Condicao == "Pause") { break; }
            }

            Console.ReadKey();
        }
    }
}
