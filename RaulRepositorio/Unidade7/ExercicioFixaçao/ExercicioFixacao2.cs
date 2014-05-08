using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade7.ExercicioFixaçao
{
    class ExercicioFixacao2
    {
        static void Main2(String[] args)
        {
            
            Console.WriteLine("Quantidade de pessoas a entrevistar ? ");
            int quantidade = Int16.Parse(Console.ReadLine());
            double[] salarioHabitantes = new double[quantidade];
            int[] numeroDeFilhos = new int[quantidade];
            double calculoSalarioHabitantes=0,mediaDeFilhos=0,maiorSalario=0;
            int contadorSalario = 0;
            
            for (int i = 0; i < numeroDeFilhos.Length; i++)
            {
                Console.WriteLine("Salario: ");
                salarioHabitantes[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("quantos filhos ? ");
                numeroDeFilhos[i] = Int16.Parse(Console.ReadLine());
                if (maiorSalario < salarioHabitantes[i])
                {
                    maiorSalario = salarioHabitantes[i];
                }
                if (salarioHabitantes[i] < 150)
                {
                    contadorSalario++;
                }
                calculoSalarioHabitantes = salarioHabitantes[i]/quantidade;
                mediaDeFilhos = numeroDeFilhos[i]/quantidade;

            }
            Console.WriteLine("Media salarial por habitante: " + calculoSalarioHabitantes);
            Console.WriteLine("Media de filhos por habitantes: " + mediaDeFilhos);
            Console.WriteLine("Maior salario dos habitantes entrevistados: "+  maiorSalario);
            Console.WriteLine("Porcentagem de habitantes com salario menor do que 150: " + contadorSalario / quantidade * 100);

        }
    }
}
