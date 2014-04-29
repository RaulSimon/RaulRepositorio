using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2Complementar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("insira senha: ");
            String senha = Console.ReadLine();

            if(senha.Equals("NomeUsuário123")){
                Console.WriteLine("Senha valida");
            }
            else
            {
                Console.WriteLine("Senha invalida");
            }
            Console.ReadKey();
        }
    }
}
