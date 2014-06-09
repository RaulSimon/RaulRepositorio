using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Unidade11.ExercicioFixacao
{
    class fixacao
    {
        

        static void Main1()
        {
            int[] array = {1,4,6,3,74,3,53,73,35,3};
            
              int ElementoMaior = maior(array);
            Console.WriteLine("Maior elemente {0}  ",ElementoMaior);
            int ElementoMenor = menor(array);
            Console.WriteLine("Elemente menor {0} ", ElementoMenor);
            int SomaElementos = soma(array);
            Console.WriteLine("Soma dos elementos {0}",SomaElementos);
            int mediaElementos = media(array);
            Console.WriteLine("Media dos Elementos {0} ",mediaElementos);
            
            
            
            OrdenaElemento(array);
            
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);    
            }
            
            Console.ReadKey();
        }

        

        private static int media(int[] array)
        {
            int media;
            int Soma = soma(array);
            media = Soma/array.Length;
            return media;
        }

        private static int soma(int[] array)
        {
            int soma = 0;
            for (int i = 0; i < array.Length; i++)
            {
                soma += array[i];
            }
            return soma;
        }

        private static int maior(int[] array)
        {
            int posicaoMaior = 0;
            int auxMaior=0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[posicaoMaior] < array[i])
                {
                    array[posicaoMaior] = i;
                    auxMaior = array[i];

                }
            }
            return auxMaior;
        }

        private static int menor(int[] array)
        {
            int posicaoMenor = 0;
            int auxMenor = 0;
            for (int i = 1; i < array.Length; i++)
            {


                if (array[posicaoMenor] > array[i])
                {
                    array[posicaoMenor] = i;
                    auxMenor = array[i];
                }
            }
            return auxMenor;
        }

        private static void troca(int[] array, int i, int j)
        {
            int aux = array[i];
            array[i] = array[j];
            array[j] = aux;
        }
        public static int Menor(int[] array, int inicio)
        {
            int menor = inicio;

            for (int i = inicio + 1; i < array.Length; i++)
            {
                if (array[menor] > array[i])
                {
                    menor = i;
                }
            }
            return menor;
        }
        private static void OrdenaElemento(int[] array)
        {

            for (int i = 0; i < array.Length; i++)
            {
                int menor = Menor(array, i);
                troca(array,i,menor);
                
            }
            
        }
    }
}
