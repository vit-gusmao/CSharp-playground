class Formats
{
    public static void Outputs()
    {
        Raw();
        N();
        Aspas();
        T();
    }

     static void Raw()
    {
        Console.WriteLine("\"\"\" \"\"\" permite escrever textos em múltiplas linhas.\n");
        Console.Write("Digite uma mensagem para se repetir em múltiplas linhas: ");
        string algo = Console.ReadLine();
        Console.WriteLine($"""
        Você digitou:
        {algo}
        {algo}
        {algo}
        {algo}
        Isso está em múltiplas linhas.
        """);
    }
  
    static void N()
    {
        Console.WriteLine("Quebra de linha\n");
        Console.WriteLine("\"\\n\" é usado para pular uma linha no texto.\n");
        Console.Write("Digite algo: ");
        string texto = Console.ReadLine();
        Console.WriteLine($"Primeira linha\nSegunda linha com: {texto}\n");
    }

    static void Aspas()
    {
        Console.WriteLine("Aspas dentro de strings\n");
        Console.WriteLine("\"\\\\\"\" é usado para mostrar aspas dentro de uma string.\n");
        Console.Write("Digite algo: ");
        string texto = Console.ReadLine();
        Console.WriteLine($"Você disse: \"{texto}\" (com aspas incluídas)\n");
    }
     static void T()
    {
        Console.WriteLine("\"\\t\" é usado para inserir uma tabulação (tab) no texto.\n");
        Console.Write("Digite algo: ");
        string texto = Console.ReadLine();
        Console.WriteLine($"Aqui está com tabulação:\n\t{texto}");
    }
}