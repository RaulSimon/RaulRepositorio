using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace MedindoAFebreV.MedindoAFebre
{
    class ExercicioFebre9
    {
        static void Main3(String[] args)
        {
            string produtoNome;
            int qtdAdquirida;
            double precoUnitario;
            double total;
            

            Console.WriteLine("Digite nome produto ?");
            produtoNome = Console.ReadLine();
            Console.WriteLine("Digite Qtd Adquirida?");
            qtdAdquirida = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite preçoUnitario?");
            precoUnitario = double.Parse(Console.ReadLine());
            total = precoUnitario*qtdAdquirida;
            Console.WriteLine("Total sem desconto: " + total);
            if (qtdAdquirida <= 5)
            {
                total = total*0.98;
            }
            else if(qtdAdquirida <=10 )
            {
                total = total*0.97;
            }
            else if(qtdAdquirida > 10)
            {
                total = total*0.95;
            }
            Console.WriteLine("  Total com desconto: " + total);

            Console.ReadKey();

        }
    }
}
