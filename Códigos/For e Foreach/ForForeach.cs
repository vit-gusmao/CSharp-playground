class ForForeach
{
    public static void For()
    {
        Console.Write("Digite a quantidade de frases que você deseja digitar: ");
        int qnt;
        while (!int.TryParse(Console.ReadLine(), out qnt))
        {
            Console.WriteLine("Você não digitou um número inteiro.");
            Console.Write("Digite a quantidade de frases que você deseja digitar: ");
        }

        string[] frase = new string[qnt];

        for (int i = 0; i < qnt; i++)
        {
            Console.Write($"Digite a {i+1}º frase: ");
            frase[i] = Console.ReadLine();
        }
        
        int qnt2;

        while (true)
        {
          Console.Write("Digite quantas frazes da que você digitou você deseja mostrar: ");

          if (!int.TryParse(Console.ReadLine(), out qnt2))
          {
            Console.WriteLine("Você não digitou um número inteiro.");
            continue;
          }
          else if (qnt2 > qnt)
          {
            Console.WriteLine("Você digitou um número maior que a quantidade de frases que você digitou.");
            continue;
          }
          else
          {
            break;
          }
        }

        for (int i = 0; i < qnt2; i++)
        {
            Console.WriteLine(frase[i]);
        }
    }
    public static void Foreach()
   {
       Console.Write("Digite a quantidade de frases que você deseja digitar: ");
       int qnt;
       while (!int.TryParse(Console.ReadLine(), out qnt))
       {
            Console.WriteLine("Você não digitou um número inteiro.");
            Console.Write("Digite a quantidade de frases que você deseja digitar: ");
       }
       string[] frase = new string[qnt];

        for (int i = 0; i < qnt; i++)
        {
            Console.Write($"Digite a {i+1}º frase: ");
            frase[i] = Console.ReadLine();
        }

        Console.Write("Aqui está todas as frases que você digitou: ");
        foreach (string f in frase)
        {
            Console.Write(f);
        }
  }  
}
