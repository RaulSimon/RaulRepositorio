using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedindoAFebreVI.MedindoAFebre
{
    class ExercicioMedindoAFebreVI
    {
        static void Main(String[] args)
        {
            Random r = new Random();
            int[] matricula = new int[100];
            int[] frequencia = new int[100];
            double[] nota1 = new double[100];
            double[] nota2 = new double[100];
            double[] nota3 = new double[100];
            double media = 0, maiorNota = 0, menorNota = 9999, maiorNota1=0, maiorNota2=0,mediaTurma=0,menorNota1=9999,menorNota2=9999;
            int cont = 0;
            

            for (int i = 0; i < matricula.Length; i++)
            {
                matricula[i] = r.Next(1,101);
                frequencia[i] = r.Next(1,100);
                nota1[i] = r.Next(1, 101);
                nota2[i] = r.Next(1, 101);
                nota3[i] = r.Next(1, 101);
            }
            for (int i = 0; i < matricula.Length; i++)
            {
                media = (nota1[i] + nota2[i] + nota3[i])/3;
                Console.WriteLine("O aluno com a matricula: {0} teve a media de {1}",matricula[i],media);
                mediaTurma += media;

                if (maiorNota < nota1[i] )
                {
                    maiorNota = nota1[i];
                }
                if(maiorNota1 < nota2[i] )
                {
                    maiorNota1 = nota2[i];
                }
                if (maiorNota2 < nota3[i])
                {
                    maiorNota2 = nota3[i];
                }

                if (menorNota > nota1[i])
                {
                    menorNota = nota1[i];
                }
                if (menorNota1 > nota2[i])
                {
                    menorNota1 = nota2[i];
                }
                if (menorNota2 > nota3[i])
                {
                    menorNota2 = nota3[i];
                }

                if (media > 59 && frequencia[i] > 39)
                {
                    Console.WriteLine("O aluno de Matricula: {0} \n foi Aprovado com media de : {1} e frequencia de : {2}",matricula[i],media,frequencia[i]);
                }
                else
                {
                    Console.WriteLine("O aluno de Matricula: {0} \n foi reprovado com media de : {1} e frequencia de : {2}", matricula[i], media, frequencia[i]);
                    cont++;
                }
                Console.WriteLine();
            }
            Console.WriteLine("Media da Turma: " + mediaTurma/100);
            Console.WriteLine("Total de Alunos Reprovados: " + cont);

            if (maiorNota > maiorNota1 && maiorNota > maiorNota2)
            {
                Console.WriteLine("A maior nota é: "+ maiorNota);
            }else if (maiorNota1 > maiorNota && maiorNota1 > maiorNota2)
            {
                Console.WriteLine("A maior nota é: "+ maiorNota1);
            }
            else
            {
                Console.WriteLine("a maior nota é: " + maiorNota2);
            }

            if (menorNota < menorNota1 && menorNota < menorNota2)
            {
                Console.WriteLine("A maior nota é: " + menorNota);
            }
            else if (menorNota1 < menorNota && menorNota1 < menorNota2)
            {
                Console.WriteLine("A maior nota é: " + menorNota1);
            }
            else
            {
                Console.WriteLine("a maior nota é: " + menorNota2);
            }


            Console.ReadKey();
        }
    }
}
