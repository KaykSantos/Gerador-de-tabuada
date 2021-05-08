using System;

namespace Exercicio_de_Fixação_07_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int c, x;
    
    Console.Write("Digite a tabuada que você deseja:");
    x = int.Parse(Console.ReadLine());

    for(c = 1; c<=10; c++){
        Console.WriteLine(x+"x"+c+"="+(x*c));
      }

            
            }
        }
    }

