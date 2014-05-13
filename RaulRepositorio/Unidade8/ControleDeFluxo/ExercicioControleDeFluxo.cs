using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Unidade8.ControleDeFluxo
{
    internal class ExercicioControleDeFluxo
    {
        private static void Main(String[] args)
        {
            Console.WriteLine(NotaAluno());
            Console.WriteLine(VerificaValorProduto("Maio", 0.6));
            Console.WriteLine(EscolheCaminho(0.6));
            Console.WriteLine(EscolheRoupa(0.4));
            Console.WriteLine(NumeroDivisivel(6,3));
            Console.ReadKey();

        }

        public static string NotaAluno()
        {
            Random r = new Random();

            if (r.Next(1, 10) > 6)
            {
                return "Aprovado";
            }
            else
            {
                return "Reprovado";
            }
        }
        public static string VerificaValorProduto(string mesDoAno, double preco)
        {
            if (mesDoAno.ToLower() == "maio" && preco > 0.5)
            {
                return "O preço caro";
            }
            else
            {
                return "o preço eh barato";
            }
        }

        public static string EscolheCaminho(double caminho)
        {
            if (caminho > 0.5)
            {
                return "Direita";
            }
            else
            {
                return "Esquerda";
            }
        }

        public static String EscolheRoupa(double roupa)
        {
            if (roupa > 0.5)
            {
                return "Camisa Vermelha";
            }
            else
            {
                return "Outra camisa";
            }
                
        }

        public static string NumeroDivisivel(int a, int b)
        {
            if (a%b == 0)
            {
                return "divisel";
            }
            else
            {
                return "Num eh";
            }
        }
    
        
    

    }
}
