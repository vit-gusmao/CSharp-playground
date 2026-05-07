class Switch
{
    public static void swtch()
    {  char select;

        Console.WriteLine("1,2");
       Console.Write("escolha um número: ");
       while (!char.TryParse(Console.ReadLine(), out select))
       {
        Console.WriteLine("escolha inválida.");
        Console.Write("escolha um número: ");
       }

       switch (select)
       {
        case '1':
            Console.WriteLine("você escolheu o número 1");
            break;
        case '2':
            Console.WriteLine("você escolheu o número 2");
            break;
       }
    }
}