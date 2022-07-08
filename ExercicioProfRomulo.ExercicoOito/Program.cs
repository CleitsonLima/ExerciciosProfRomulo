using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioProfRomulo.ExercicoOito
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Crie um programa que entre com um número inteiro
             * e mostre o fatorial desse número.
             * Exemplo:
             * 5! = 120
             * 5*4*3*2*1=  120
             */
                     
            
            do
            {
                int i, Numero, Resultado = 1;
                Console.WriteLine("Digite um numero:");
                Numero = int.Parse(Console.ReadLine());
                for (i = Numero; i > 0; i--)
                {
                    Resultado *= i;

                }
                
                Console.WriteLine($"O Fatorial do numero {Numero} é igual a {Resultado}");


                Console.WriteLine("Enter para continuar backspace para sair");
            } while (Console.ReadKey().Key != ConsoleKey.Backspace);

        }
    }
}
