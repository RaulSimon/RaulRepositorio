using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioComplementar6
{
    class Program
    {
        static void Main(string[] args)
        {
            String nomeMocas = "Continue",AuxNome="";
            double alturaMocas,auxAltura=0;
            int cont=0;


            while(nomeMocas != "FIM"){
                Console.WriteLine("Nome: ");
                nomeMocas = Console.ReadLine();

                Console.WriteLine(" Altura: ");
                alturaMocas = double.Parse(Console.ReadLine());
                if(auxAltura< alturaMocas){
                    auxAltura = alturaMocas;
                    AuxNome = nomeMocas;

                }
                cont++;
            }
            Console.WriteLine("Nome moça mais alta {0} com a altura de {1}",AuxNome,auxAltura);
            Console.WriteLine("Total de moças que participaram foi " + cont);
            Console.ReadKey();
        }
    }
}
