using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade10.Metodos
{
    internal class ExerciciosFixacao
    {
        private static void Main()
        {
            //Console.WriteLine(ConsumoDeCombustivel(10,100));
            //JurosComposto();
            //IRPF(800.00);
            //IMC(85,1.75);
            //Array();
            Console.ReadKey();
        }

        private static string ConsumoDeCombustivel(double KmInicial, double KmFinal)
        {

            KmFinal = KmFinal - KmInicial;
            return "O consumo de combustivel foi " + KmFinal;
        }

        private static void JurosComposto()
        {
            int mes = 12;
            double juros = 0.035, aplicacao = 6000, resultado;
            juros += 1;
            for (int i = 0; i < mes; i++)
            {
                juros *= juros;
            }
            resultado = aplicacao*juros;
            Console.WriteLine("O Juros composto da aplicaçao: " + resultado);

        }

        private static void IRPF(double salario)
        {
            if (salario <= 1637)
            {
                Console.WriteLine("Sem Imposto");
            }
            else if(salario> 1637 && salario < 2454)
            {
                salario = salario*0.925;
                Console.WriteLine("O salario com imposto foi: " + salario);
            }else if (salario> 2453 && salario< 3272)
            {
                salario = salario*0.75;
            }else if (salario> 3271 && salario < 4088)
            {
                salario = salario*0.775;
                Console.WriteLine("O Salario com imposto foi: "+ salario);
            }
            else
            {
                salario = salario*0.725;
                Console.WriteLine("O salario com imposto foi: "+ salario);
            }
        }

        private static void IMC(double peso,double altura)
        {
            double resultado;
            resultado = peso/(altura*2);
            if (resultado < 18)
            {
                Console.WriteLine("Muito Abaixo de peso");
            }
            else if(resultado > 16 && resultado < 18.50)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (resultado > 18.5 && resultado < 25)
            {
                Console.WriteLine("Peso Normal");
            }
            else if (resultado > 24.99 && resultado < 30)
            {
                Console.WriteLine("Acima do Peso");
            }
            else if (resultado > 29.99 && resultado < 35)
            {
                Console.WriteLine("Obesidade");
            }
            else if (resultado > 34.99 && resultado < 40)
            {
                Console.WriteLine("Obesidade Severa");
            }
            else
            {
                Console.WriteLine("Obesidade Morbida");
            }

        }

        private static void Array()
        {
            int[] array = new int[99];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }


}

