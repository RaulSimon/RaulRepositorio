using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6.ExerciciosComplementares
{
    class ExercicioComplementar3
    {
        static void Main3(string[] args)
        {
            String sexo;
            double altura;

            Console.WriteLine("Sexo? ");
            sexo = Console.ReadLine();
            Console.WriteLine("Altura: ");
            altura = double.Parse(Console.ReadLine());
            
            if(sexo.ToLower() == "feminino"){
               
               altura = (62.1 * altura) - 44.7; 
            } else if(sexo.ToLower() == "masculino"){
                altura = (72.7 * altura) - 58; 
            }
            Console.WriteLine("Seu peso ideal: " + altura);
            Console.ReadKey();
        }
    }
}
