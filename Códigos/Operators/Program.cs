using System;

class Program
{
    static void Main(string[] args)
    {
        double[] n = new double[2];
        for (int i = 0; i < 2; i++)
        {
            Console.Write($"Digite o {i+1}º número: ");
            while (!double.TryParse(Console.ReadLine(), out n[i]))
            {
                Console.WriteLine("Você não digitou um número.");
                Console.Write($"Digite o {i+1}º número: ");
            }
        }

        Console.WriteLine();
        new Operators(n);

    }
}   
  
