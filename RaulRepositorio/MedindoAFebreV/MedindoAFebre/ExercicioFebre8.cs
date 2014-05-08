using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedindoAFebreV.MedindoAFebre
{
    class ExercicioFebre8
    {
        static void Main2(String[] args)
        {
            Random r = new Random();
            int condicao = r.Next(1, 100);
            double[] horario = new double[condicao];
            int contadorPessoas=0;
            

            for (int i = 0; i < horario.Length; i++)
            {
                horario[i] = r.Next(1,24);
                if (horario[i] >9 && horario[i] < 17)
                {
                    contadorPessoas++;
                }
            }
            Console.WriteLine("Quantidade de pessoas que entraram no horario das 10 as 16  : " + contadorPessoas);
            Console.ReadKey();
        }

    }
}
