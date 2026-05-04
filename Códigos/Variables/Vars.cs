class Vars
{
    public static void Var()
    {
        Int();
        Float();
        String();
        Bool();
        Char();
        Var();
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

    public static void Float()
    {
        Console.WriteLine("\"float\" = variável que armazena números reais (exemplo: float pi = 3.14f;)");

        while (true)
        {
            Console.Write("Digite um número real: ");

            bool verify = float.TryParse(Console.ReadLine(), out float flt);

            if (verify)
            {
                Console.WriteLine($"você digitou o número real: {flt}\n");
                break;
            }

            Console.WriteLine("Você não digitou um número real.");
        }
    }

    public static void Bool()
    {
        Console.WriteLine("\"bool\" = variável que armazena true ou false (exemplo: bool ativo = true;)");

        float n1, n2;

        while (true)
        {
            Console.Write("Digite um número: ");
            bool verify1 = float.TryParse(Console.ReadLine(), out n1);

            Console.Write("Digite outro número: ");
            bool verify2 = float.TryParse(Console.ReadLine(), out n2);

            if (verify1 && verify2)
            {
                break;
            }

            Console.WriteLine("Você não digitou um número.");
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

    public static void Var()
    {
        Console.WriteLine("\"var\" = variável que armazena um valor de qualquer tipo.");
    }
}