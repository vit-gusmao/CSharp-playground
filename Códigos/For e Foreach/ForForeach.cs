class ForForeach
{
    public static void For()
    {
        Console.Write("Digite uma frase: ");
        string frase = Console.ReadLine() ?? "";
        Console.Write($"Digite a quantidade de vezes que a frase digitada será repetida: ");
        int qnt;
        while (!int.TryParse(Console.ReadLine(), out qnt))
        {
            Console.WriteLine("Você não digitou um número.");
            Console.Write($"Digite a quantidade de vezes que a frase digitada será repetida: ");
        }
        for (int i = 0; i < qnt; i++)
        {
            Console.WriteLine(frase);
        }
    }

}