using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace MedindoAFebreVII
{
    class Exercicio13
    {
        static void Main(string[] args)
        {
            inicializaVetores();
            Console.WriteLine("Porcentagem Adultos: " + (contadorAdultos * 100 / 50) + "%");
            Console.WriteLine("Porcentagem nao Adultos: "+ (contadorNaoAdultos * 100 / 50)+ "%");
            Console.WriteLine("Maiores do que 1.70: " + Maiores() *100 / 50 +  " %");
            Console.ReadKey();
        }

        static void inicializaVetores()
        {
            Random r = new Random();

            string[] Nome = new string[50];
            string[] Sexo = new string[50];
            string[] TipoSexo = {"Feminino", "Masculino"};
            string[] tipoNome = {"Joao", "Maria", "Jose"};
            int[] idade = new int[50];
            double[] altura = new double[50];
            bool[] adulto = new bool[50];
            string nomeaux="", nomeaux2="";
            double alturaaux = 0;
            double auxaltura2 = 99;
            for (int i = 0; i < idade.Length; i++)
            {
                Nome[i] = tipoNome[r.Next(0, 3)];
                Sexo[i] = TipoSexo[r.Next(0,2)];
                    idade[i] = r.Next(1,90);
                altura[i] = r.NextDouble()*2;
                
                               Console.WriteLine();
                if (idade[i] > 17)
                {
                    adulto[i] = true;
                    PorcentagemAdultos();
                }
                else
                {
                    adulto[i] = false;
                    PorcentagemNaoAdultos();
                }
                
                if (altura[i] > 1.69)
                {
                    Maiores();
                }
               
                if (altura[i]> alturaaux)
                {
                    
                    alturaaux = altura[i];
                    
                    nomeaux = Nome[i];

                }
                
                
                if (altura[i] < auxaltura2)
                {
                    auxaltura2 = altura[i];
                    
                    nomeaux2 = Nome[i];
                }

                Console.WriteLine("Nome:" + Nome[i] + ", Idade: " + idade[i] + ", Sexo " + Sexo[i] + " , Adulto: " + adulto[i]);


            }
            int a = 0;
            for (int i = 0; i < idade.Length; i++)
            {
                for (int j = 0; j < idade.Length - 1; j++)
                {
                    if (idade[j] > idade[j + 1])
                    {
                        a = idade[j + 1];
                        idade[j + 1] = idade[j];
                        idade[j] = a;
                    }
                }
            }
            for (int i = 0; i < 50; i++)
            {
                if (i>39)
                {
                    Console.WriteLine("Mais velhos: " + Nome[i] + " idade: " + idade[i]);
                }
                if (i<5)
                {
                    Console.WriteLine("Mais novos: " + Nome[i] + " idade: " + idade[i]);
                }
            }
            Console.WriteLine("Pessoa mais alta: " + nomeaux );
            Console.WriteLine("Pessoa mais baixa: "+ nomeaux2 );
            
        }
        static int contadorMaiores = 0;
         static int Maiores()
         {
             
             return contadorMaiores++;
         }
       static int contadorAdultos=0;
        static double PorcentagemAdultos()
        {
            
            
            return contadorAdultos++;

        }

        private static int contadorNaoAdultos = 0;
        static double PorcentagemNaoAdultos()
        {
            return contadorNaoAdultos++;
        }

        
        

    }
}
