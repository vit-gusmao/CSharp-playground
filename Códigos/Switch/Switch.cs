class Switch
{
    public static void Swt()
    {  
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine($"Opção {i + 1}");
        }

       Console.Write("escolha um número das opções: ");
       bool v = int.TryParse(Console.ReadLine(), out int select);

       switch (select)
       {
        case 1:
            Console.WriteLine("você escolheu o número 1");
            break;
        
        case 2:
            Console.WriteLine("você escolheu o número 2");        
            break;
        
        default:
            if (!v || select < 2 || select > 2){Console.WriteLine("opção inválida");}
            break;
        }
    }
}