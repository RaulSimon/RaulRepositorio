using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade11.ExercicioComplementar
{
    class megaSena
    {
        static void Main()
        {
            sorteioMegaSena();
            Console.ReadKey();


        }

        static void sorteioMegaSena()
        {
            Random r = new Random();
            int[] sorteioDosNumeros = new int[6];
            int aux = 0;
            for (int i = 0; i < sorteioDosNumeros.Length; i++)
            {
                sorteioDosNumeros[i] = r.Next(1,61);
                
                aux = NumeroEscolhidos(sorteioDosNumeros);
                Console.WriteLine("Numero {0} sorteado",sorteioDosNumeros[i]);
            }
            if (aux == 1 )
            {
                Console.WriteLine("Acertou 1");
            }
            else if (aux ==2)
            {
                Console.WriteLine("Acertou 2");
            }
            else if (aux ==3)
            {
                Console.WriteLine("Acertou 3");
            }
            else if (aux ==4)
            {
                Console.WriteLine("Acertou 4");
            }
            else if (aux ==5)
            {
                Console.WriteLine("Acertou 5");
            }
            else if (aux ==6)
            {
                Console.WriteLine("Acertou 6");
            }
            else
            {
                Console.WriteLine("Nao acertou");
            }
            for (int i = 0; i < sorteioDosNumeros.Length; i++)
            {
                OrdenaElemento(sorteioDosNumeros);
                Console.WriteLine(sorteioDosNumeros[i]);
            }
            

        }

        static int  NumeroEscolhidos(int[] sorteioDosNumeros)
        {
            int[] informarNumeros = new int[6];
            Random r= new Random();
            int contador = 0;
            for (int i = 0; i < informarNumeros.Length; i++)
            {
                informarNumeros[i] = r.Next(1, 61);
                sorteioDosNumeros.Contains(informarNumeros[i]);

            }
            return contador;
        }
        private static int menor(int[] sorteioDosNumeros)
        {
            int posicaoMenor = 0;
            int auxMenor = 0;
            for (int i = 1; i < sorteioDosNumeros.Length; i++)
            {


                if (sorteioDosNumeros[posicaoMenor] > sorteioDosNumeros[i])
                {
                    sorteioDosNumeros[posicaoMenor] = i;
                    auxMenor = sorteioDosNumeros[i];
                }
            }
            return auxMenor;
        }

        
        private static void troca(int[] sorteioDosNumeros, int i, int j)
        {
            int aux = sorteioDosNumeros[i];
            sorteioDosNumeros[i] = sorteioDosNumeros[j];
            sorteioDosNumeros[j] = aux;
        }
        public static int Menor(int[] sorteioDosNumeros, int inicio)
        {
            int menor = inicio;

            for (int i = inicio + 1; i < sorteioDosNumeros.Length; i++)
            {
                if (sorteioDosNumeros[menor] > sorteioDosNumeros[i])
                {
                    menor = i;
                }
            }
            return menor;
        }
        private static void OrdenaElemento(int[] sorteioDosNumeros)
        {

            for (int i = 0; i < sorteioDosNumeros.Length; i++)
            {
                int menor = Menor(sorteioDosNumeros, i);
                troca(sorteioDosNumeros, i, menor);

            }

        }
    }
}
