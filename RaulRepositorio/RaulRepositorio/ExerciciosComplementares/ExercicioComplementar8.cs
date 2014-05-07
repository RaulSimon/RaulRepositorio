using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6.ExerciciosComplementares
{
    class ExercicioComplementar8
    {
        static void Main8(string[] args)
        {
            Console.WriteLine("Digite o texto: ");
            string texto = Console.ReadLine();
            int conta = 0;

            char[] text = texto.ToCharArray();

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].Equals('a') || text[i].Equals('A'))
                {
                    conta++;
                }
                else if (text[i].Equals('b') || text[i].Equals('B'))
                {
                    conta++;
                }
                else if (text[i].Equals('d') || text[i].Equals('D'))
                {
                    conta++;
                }
                else if (text[i].Equals('e') || text[i].Equals('E'))
                {
                    conta++;
                }
                else if (text[i].Equals('g') || text[i].Equals('G'))
                {
                    conta++;
                }
                else if (text[i].Equals('o') || text[i].Equals('O'))
                {
                    conta++;
                }
                else if (text[i].Equals('p') || text[i].Equals('P'))
                {
                    conta++;
                }
                else if (text[i].Equals('q') || text[i].Equals('Q'))
                {
                    conta++;
                }
            }
            Console.WriteLine("Quantidade buracos: " + conta);

            Console.ReadKey();
        }


    }
}
