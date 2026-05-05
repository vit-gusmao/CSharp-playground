using System;

class Program
{
    static void Main(string[] args)
    {
        double n1 = NumInput("Digite um número: ");
        double n2 = NumInput("Digite outro número: ");
        
        new Operators(n1, n2);

    }

     static double NumInput(string msg)
     {
        double num;

        Console.Write(msg);

         while (!double.TryParse(Console.ReadLine(), out num))
    {
        Console.WriteLine("Você não digitou um número.");
        Console.Write(msg);
    }

    return num;

     }   
  }
