﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComplementaresUnidade6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantas maças: ");
            double maca = double.Parse(Console.ReadLine());

            if(maca <12){
                maca = (maca * 0.30);

            }
            else
            {
                maca = maca * 0.25;
            }
            Console.WriteLine("Total de venda {0} r$",maca);
            Console.ReadKey();
        }
    }
}
