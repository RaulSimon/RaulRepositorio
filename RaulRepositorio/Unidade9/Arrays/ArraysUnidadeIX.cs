using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade9.Arrays
{
    class ArraysUnidadeIX
    {
        static void Main()
        {
            //VetorDe10();
            //arrayCrescente();
            //arrayDecrescente();
            //arrayAleatorio();
            //crescenteImpar();
            //arrayDeArrays();
            //TabuadaMatriz();
            Console.ReadKey();
        }
       public static Random r = new Random();
        private int teste;
        public static void VetorDe10()
        {
            int array;
            
            for (int i = 0; i < 10; i++)
            {
                array = r.Next(1,20);
                Console.WriteLine("Numero {0} : {1}",i,array);
            }
        }

        public static void arrayCrescente()
        {
            Console.WriteLine("Crescente");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void arrayDecrescente()
        {
            Console.WriteLine("Decrescente");
            for (int i = 10; i > 0; i--)
            {
             Console.WriteLine(i);   
            }
        }

        public static void crescenteImpar()
        {
            Console.WriteLine("Sequencia Impar");
            for (int i = 0; i < 10; i++)
            {
                if (i%2==1)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void arrayAleatorio()
        {
            int array;

            for (int i = 0; i < 10; i++)
            {
                array = r.Next(1, 20);
                Console.WriteLine("Numero {0} : {1}", i, array);
            }
        }

        public static void arrayDeArrays()
        {
            int[,] arrayDearray= new int[10,10];
            Console.WriteLine("Array de Arrays");
            for (int i = 0; i < 10; i++)
            {
                arrayDearray[i, i] = r.Next(1, 20);
                Console.WriteLine("Linha {0}",i);
                for (int j = 0; j < 10; j++)
                {
                    arrayDearray[i, j] = r.Next(1,20);
                    Console.WriteLine("Coluna : " +arrayDearray[i,j]);
                }
            }
        }

        public static void TabuadaMatriz()
        {
            int[,] matrizTabuada = new int[10,10];

            for (int i = 0; i < 10; i++)
            {
                matrizTabuada[i,i] = i;
                
                for (int j = 0; j < 10; j++) 
                {
                    
                    matrizTabuada[j,i]= j;
                }
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Taboada do " + i);
                for (int j = 0; j < 10; j++)
                {
                    int multiplica = matrizTabuada[i, j]  *matrizTabuada[j, i] ;
                    Console.WriteLine("{0} x {1} = {2}",matrizTabuada[i,j],matrizTabuada[j,i],multiplica);
                }
            }
            Console.ReadKey();
        }
        
    }
}
