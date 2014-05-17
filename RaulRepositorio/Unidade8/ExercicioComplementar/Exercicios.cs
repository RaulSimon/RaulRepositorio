using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade8.ExercicioComplementar
{
    class Exercicios
    {
        static void Main()
        {
            //NumeroAleatorio();
            //hashtag();
            //condominio();
           // taboada();
            //JogoDeDados();
            //numeroAleatorio();
            Console.ReadKey();
        }
        public static  Random r  = new Random();
        public static void NumeroAleatorio()
        {
            double a, b;
            a = r.NextDouble();
            b = r.NextDouble();
            Console.WriteLine("A = "+ a + " B = " + b);
            if (a > b)
            {
                Console.WriteLine("Primeiro > segundo");
            }else if (a < b )
            {
                Console.WriteLine("Segundo > primeiro");
            }
            else
            {
                Console.WriteLine("primeiro = segundo");
            }
        }

        public static void hashtag()
        {
            String soma = "", a = "**********";
            for (int i = 0; i < 3; i++)
            {


                for (int j = 0; j < 5; j++)
                {

                    
                    
                        soma = " ";
                        a = soma + a;
                        Console.WriteLine(a);

                        
                }
                a = "**********";
            }


        }

        public static void condominio()
        {
            Random r = new Random();
            

         

                Random random =new Random();
                int numero = r.Next(1, 4);
                int numero1 = r.Next(1, 10);
                int numero2 = r.Next(20,25);


                Console.Write("Condominio: {0}, Andar: {1}, Apartamento: {2} ",numero,numero1,numero2 );
               
                
            
        }

        public static void taboada()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Taboada do : " + i);
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine("{0} x {1} = {2}",i,j,i*j);
                }
            }
        }

        public static void JogoDeDados()
        {
            
            Random JogarDados = new Random();
            int dado;
            int soma = 0, contador=0;

            for (int i = 0; i < 10; i++)
            {
                dado = r.Next(1, 7);
                soma += dado;
                if (dado == 6)
                {
                    contador++;
                    if (contador == 2)
                    {

                        Console.Write("O numero 6 caiu pela segunda vez, ");
                        break;

                    }
                }
            }
            
            if (soma%2==1 && contador<2)
            {
               
                Console.WriteLine("Voce ganhou a soma foi: " + soma);
            }
            else
            {
                Console.WriteLine("Voce perdeu a soma foi: "+ soma);
            }
        }

        public static void numeroAleatorio()
        {
            Random r = new Random();
            int numeroAleatorio;
            numeroAleatorio = r.Next(1,1000000);
            string stringNumero = numeroAleatorio.ToString();
            int cont = 0;
            

            Console.WriteLine("Numero: " + numeroAleatorio);
            char[] charNumeroAleatorio = stringNumero.ToCharArray();
            
            for (int i = 0; i < charNumeroAleatorio.Length; i++)
            {
                if (charNumeroAleatorio[i].Equals('1'))
                {
                    cont++;
                }
            }
          
            Console.WriteLine("Quantidade de numeros 1: " + cont);
        }
    }
 
}
