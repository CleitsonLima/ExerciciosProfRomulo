using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosProfRomulo.EscolinhaTicTic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            do
            {
                double num1, num2, num3, soma, media;
                string nome;


                Console.WriteLine("\nDigite seu nome");
                nome = Console.ReadLine();

                Console.WriteLine("digite a primeira nota");
                num1 = double.Parse(Console.ReadLine());

                Console.WriteLine("digite a segunda nota");
                num2 = double.Parse(Console.ReadLine());

                Console.WriteLine("digite a terceira nota");
                num3 = double.Parse(Console.ReadLine());

                soma = num1 + num2 + num3;
                media = (num1 + num2 + num3) / 3;



                //Console.WriteLine("O aluno " + nome + " tirou as seguintes notas: " +num1 + "," + num2 + "," + num3+ " totalizando " + soma );

                Console.WriteLine($"O aluno {nome} tirou as seguintes notas: {num1}, {num2}, {num3}, totalizando {soma}");
                Console.WriteLine($"A media final do aluno e igual a {media.ToString("F")}.");

                if (media >= 7)
                {
                    Console.WriteLine("Aprovado");
                }
                else
                {
                    Console.WriteLine("Reprovado");
                }

                Console.WriteLine("Para continuar digite qualquer tecla diferente de barra de espaco");
                //sair = int.Parse(Console.ReadLine());

                
            } while (Console.ReadKey().Key != ConsoleKey.Spacebar );
            
        }
    }
}
