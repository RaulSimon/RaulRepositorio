using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6.ExerciciosComplementares
{
    class ExercicioComplementar4
    {
        static void Main4(string[] args)
        {
            Random r = new Random();
            int inter, gremio;
            inter = r.Next(0,10);
            gremio = r.Next(0,1);
            if(inter > gremio){
                Console.WriteLine("o Inter ganhou do Gremio de {0} a {1} ",inter,gremio);
            }
            else if(inter < gremio)
            {
                Console.WriteLine("o Gremio ganhou do Inter de {1} a {0} ", inter, gremio);
            }
            else
            {
                Console.WriteLine("o Inter empatou com o  Gremio em {0} a {1} ", inter, gremio);
            }
            Console.ReadKey();
        }
    }
}
