using System;

class Program
{
    static void Main(string[] args)
    {
        float n1 = NumInput("Digite um número: ");
        float n2 = NumInput("Digite outro número: ");
        
        new Operators(n1, n2);

    }

     static float NumInput(string msg)
     {
        float num;

        Console.Write(msg);

         while (!float.TryParse(Console.ReadLine(), out num))
    {
        Console.WriteLine("Você não digitou um número.");
        Console.Write(msg);
    }

    return num;

     }   
  }


