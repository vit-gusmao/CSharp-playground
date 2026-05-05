class Vars
{
    public static void Var()
    {
        Int();
        Double();
        String();
        Bool();
        Char();
    }

    public static void String()
    {
        Console.WriteLine("\"string\" = variável que armazena uma sequência de caracteres somente usando \"\" (exemplo: string name = \"Vitor\";)");

        Console.Write("Digite algo: ");
        string algo = Console.ReadLine();

        Console.WriteLine($"você digitou \"{algo}\" e foi armazenado como string.\n");
    }

    public static void Int()
    {
        Console.WriteLine("\"int\" = variável que armazena números inteiros (exemplo: int num = 10;)");

        while (true)
        {
            Console.Write("Digite um número inteiro: ");

            bool verify = int.TryParse(Console.ReadLine(), out int num);

            if (verify)
            {
                Console.WriteLine($"você digitou o número inteiro: {num}\n");
                break;
            }

            Console.WriteLine("Você não digitou um número inteiro.");
        }
    }

    public static void Double()
    {
        Console.WriteLine("\"double\" = variável que armazena números reais (exemplo: double pi = 3.14;)");

        while (true)
        {
            Console.Write("Digite um número real: ");

            bool verify = double.TryParse(Console.ReadLine(), out double dbl);

            if (verify)
            {
                Console.WriteLine($"você digitou o número real: {dbl}\n");
                break;
            }

            Console.WriteLine("Você não digitou um número real.");
        }
    }

    public static void Bool()
    {
        Console.WriteLine("\"bool\" = variável que armazena true ou false (exemplo: bool ativo = true;)");

        double n1 = Numinput("Digite um número: ");
        double n2 = Numinput("Digite outro número: ");

        static double Numinput(string msg)
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

        bool verify = n1 > n2;

        Console.WriteLine($"o número {n1} é maior que o número {n2}: {verify}\n");
    }

    public static void Char()
    {
        Console.WriteLine("\"char\" = variável que armazena um único caractere somente usando '' (exemplo: char letra = 'a';)");

        while (true)
        {
            Console.Write("Digite um caractere: ");

            bool verify = char.TryParse(Console.ReadLine(), out char ch);

            if (verify)
            {
                Console.WriteLine($"você digitou o caractere: {ch}\n");
                break;
            }

            Console.WriteLine("Você não digitou um caractere.");
        }
    }
}