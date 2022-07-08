using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosProfRomulo.ExercicioSeis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *Crie um algoritmo que mostre os 100 primeiros números pares.
             *Use
             *While
             *If
             *% 
             */

            int i=1;
            while(i <= 100) 
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);                    
                }
                i++;
            }
            Console.ReadKey();
        }
    }
}
