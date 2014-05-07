using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6.ExerciciosComplementares
{
    class ExercicioComplementar7
    {
        static void Main7(string[] args)
        {
            String TipoDeCargo;
            double horasTrabalhadas;
            int faltas;
            double valorPorFalta;
            double valorPorHora;
            Console.WriteLine("Escreva 'H' para horista ou 'M' para mensalista: ");
            TipoDeCargo = Console.ReadLine();
            TipoDeCargo.ToUpper();
            if (TipoDeCargo == "H")
            {
                Console.WriteLine("Quantas horas trabalhou: ");
                horasTrabalhadas = double.Parse(Console.ReadLine());
                Console.WriteLine("Valor por hora Trabalhada: ");
                valorPorHora = double.Parse(Console.ReadLine());
                horasTrabalhadas = horasTrabalhadas * valorPorHora;
                Console.WriteLine("Valor total horista:" + horasTrabalhadas);
            }
            else if (TipoDeCargo == "M")
            {
                Console.WriteLine("Teve quantas faltas? ");
                faltas = Int32.Parse(Console.ReadLine());
                Console.WriteLine("valor por hora trabalhada: ");
                valorPorHora = double.Parse(Console.ReadLine());
                Console.WriteLine("Valor descontado por falta? ");
                valorPorFalta = double.Parse(Console.ReadLine());
                Console.WriteLine("Quantas horas trabalhou ? ");
                horasTrabalhadas = double.Parse(Console.ReadLine());

                valorPorFalta = valorPorFalta * faltas;
                valorPorHora = (valorPorHora * horasTrabalhadas) - valorPorFalta;
                Console.WriteLine("Valor total mensalista: " + valorPorHora);




            }
            Console.ReadKey();
        }
    }
}
