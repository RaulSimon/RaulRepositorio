using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade9.Arrays.Complementar
{
    internal class ExerciciosComplementares
    {
        private static void Main()
        {
            //correcaoAutomatica();
            //VagaDeCarro();
            //PosicaoVetor();
            //ValorNulo();
            //notaAluno();
            //clienteLocadora();
            //subtrair();
            loteria();
            Console.ReadKey();
        }

        private static void correcaoAutomatica()
        {
            int[] Prova = new int[10];
            int[] correcao = new int[10];
            Random r = new Random();
            Console.WriteLine(
                "Cada questão possui 3 alternativas numeradas de 1 até 3, digite a questão com o numero correto");
            for (int i = 0; i < 10; i++)
            {

                Prova[i] = r.Next(1, 4);
                correcao[i] = r.Next(1, 4);
                Console.WriteLine("Questa : {0} Resposta: {1} ", i, Prova[i]);

            }
            Console.WriteLine("Correçao Prova: ");
            for (int i = 0; i < 10; i++)
            {
                if (Prova[i] == correcao[i])
                {
                    Console.WriteLine("Questao: {0} Esta Correta", i);
                }
                else
                {
                    Console.WriteLine("Questao: {0} Esta Errada", i);
                }
            }
        }

        private static void VagaDeCarro()
        {
            int[,] Vaga = new int[4, 10];
            string[] situacao = { "Livre", "Ocupada" };
            Random r = new Random();


            for (int i = 0; i < 4; i++)
            {
                Vaga[i, i] = i;

                for (int j = 0; j < 10; j++)
                {
                    Vaga[i, j] = j;

                    Console.WriteLine("Andar: {0} Vaga: {1} Esta : {2} ", i + 1, j + 1, situacao[r.Next(0, 2)]);
                }
            }
        }

        private static void PosicaoVetor()
        {
            Random r = new Random();
            int[] valor = new int[7];
            int auxValor = 101, auxPosi = 0;


            for (int i = 0; i < 7; i++)
            {
                valor[i] = r.Next(1, 100);

                if (auxValor > valor[i])
                {
                    auxValor = valor[i];
                    auxPosi = i;
                }
            }
            Console.WriteLine("O menor valor foi {0} na posição {1}", auxValor, auxPosi);
        }

        private static void ValorNulo()
        {
            int[] vetor = new int[12];
            int[] vetor1 = new int[12];
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    vetor[i] = r.Next(2, 200);
                }
                Console.WriteLine("vetor com nullos: " + vetor[i]);
                vetor1[i] = vetor[i];
                if (vetor1[i] == 0)
                {
                    vetor1[i] = 1;
                }

            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("velor sem nulos: " + vetor1[i]);
            }
        }

        private static void notaAluno()
        {
            int[] aluno = new int[10];
            int[] prova = new int[10];
            int[] gabarito = new int[10];
            Random r = new Random();
            int contCertas = 0;
            for (int i = 0; i < 10; i++)
            {
                gabarito[i] = r.Next(1, 4);
            }

            for (int i = 0; i < 10; i++)
            {
                aluno[i] = i + 1;
                contCertas = 0;

                for (int j = 0; j < 10; j++)
                {
                    prova[j] = r.Next(1, 4);
                    if (prova[j] == gabarito[j])
                    {
                        contCertas++;

                    }
                }
                if (contCertas > 5)
                {
                    Console.WriteLine("O Aluno {0} Passou com {1} Acertos", aluno[i], contCertas);
                }
                else
                {
                    Console.WriteLine("O Aluno {0} Reprovou com {1} Acertos", aluno[i], contCertas);
                }
            }


        }

        private static void clienteLocadora()
        {
            Random r = new Random();
            int[] clientes = new int[50];

            for (int i = 0; i < 50; i++)
            {
                clientes[i] = r.Next(1, 30);
                if (clientes[i] > 9)
                {
                    Console.WriteLine("Cliente {0} tem direito a uma locaçao gratis", i);
                }
            }
        }

        private static void subtrair()
        {
            int[] A = new int[50];
            int[] B = new int[50];
            int resultado = 0;
            Random r = new Random();
            int i;
            for (i = 0; i < 50; i++)
            {
                A[i] = r.Next(1, 20);
                Console.WriteLine(A[i]);

            }
            i = 0;
            for (int j = 49; j > 0; j--)
            {
                B[j] = r.Next(1, 20);
                Console.WriteLine(B[j]);


                resultado += (A[i] - B[j]);
                i++;
            }
            Console.WriteLine("Resultado: {0}", resultado);
        }

        private static void loteria()
        {
            Random r = new Random();
            int[] gabaritoLoteria = new int[10];
            int[,] aposta = new int[3, 13];
            int contador = 0;
            for (int i = 0; i < 10; i++)
            {
                gabaritoLoteria[i] = r.Next(1, 7);
            }
            for (int i = 0; i < 3; i++)
            {


                for (int j = 0; j < 13; j++)
                {
                    aposta[i, j] = r.Next(1, 7);
                    if (aposta[i, j] == gabaritoLoteria[i])
                    {
                        contador++;
                    }
                }
                if (contador == 13)
                {
                    Console.WriteLine("Jogador {0} GANHOU", i);
                }
                else
                {
                    Console.WriteLine("Jogador {0} nao ganhou", i);
                }
                contador = 0 ;
            }
        }

    }
}
