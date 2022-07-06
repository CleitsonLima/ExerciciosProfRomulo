using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosProfRomulo.MatematicaBasica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2,soma;
            

            Console.WriteLine("digite um numero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("digite outro  numero");
            num2 = int.Parse(Console.ReadLine());

            soma = num1 + num2;
            Console.WriteLine($"A soma entre os numeros {num1} e {num2} e igual a {soma}.");
            Console.ReadKey();
        }
        
    }
}
