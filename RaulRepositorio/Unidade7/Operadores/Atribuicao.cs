using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade7.Operadores
{
    class Atribuicao
    {
        static void Main1(String[] args){
            double uan = 1;
            uan += 2;
            uan -= 4;
            uan *= 25;
            uan /= 20;
            
            Random r = new Random();
            uan = r.NextDouble() * 100;
           if(uan > 10 && uan < 100){
               Console.WriteLine("lol");
           }else if(uan > 10 || uan <100){
               Console.WriteLine("sdahdadaudusa");
           }
            Console.WriteLine("Valor do uan: " + uan);
            Console.ReadKey();
        }
    }
}
