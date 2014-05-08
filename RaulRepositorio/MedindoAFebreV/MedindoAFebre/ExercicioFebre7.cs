using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedindoAFebreV.MedindoAFebre
{
    class ExercicioFebre7
    {
        static void Main1(String[] args)
        {
            int idade=0;
            int aux = 18;
            String a ;
            
            Console.WriteLine("Quantos anos tem ? ");
            idade = int.Parse(Console.ReadLine());
            a = idade >= aux ? "Maior de Idade"+ idade : "Menor de Idade"+ idade;
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
