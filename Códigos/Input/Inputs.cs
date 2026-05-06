class Input
{
    public static void String()
    {
        Console.WriteLine("Input string = Console.ReadLine();");
        Console.Write("Digite algo: ");
        string input = Console.ReadLine();
        Console.WriteLine($"Você digitou \"{input}\" e foi armazenado como string.");
    }

    public static void TryParse()
    {
        Console.WriteLine("""Input int e double = var.TryParse(Console.ReadLine(), out var);""");
        Console.Write("Digite um número: ");
        double n;
        while (!double.TryParse(Console.ReadLine(), out n))
        {
            Console.WriteLine("Você não digitou um número.");
            Console.Write("Digite um número: ");
        }
        Console.WriteLine($"Você digitou o número: {n}");
    }

    public static void Numbers()
    {
        Console.WriteLine("""Vários inputs de números""");
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
        Console.WriteLine($"Você digitou o número {n[0]} e {n[1]}.");
    }
}
