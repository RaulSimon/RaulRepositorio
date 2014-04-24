using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe10
{
    class Program
    {
        static void Main(string[] args)
        {
               String[] NomeProduto = new String[4];
            double[] preco = new double[4];
            double[]  precoDesconto = new double[4];
            double a=0,b;
            for (int i = 0; i < 4; i ++ )
            {
                NomeProduto[i] = Console.ReadLine();
                preco[i] = double.Parse(Console.ReadLine());
                precoDesconto[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("Nome Produto: " + NomeProduto[i] + " Preço produto " + preco[i] + "  Desconto " + precoDesconto[i]);
                b = preco[i] * precoDesconto[i];
                preco[i] -= b;
                Console.WriteLine("  produto Com desconto  : " + preco[i]);
                a += preco[i];
            }
            Console.WriteLine("preço total: "+ a);
            Console.ReadKey();
        }
        }
    }
}
