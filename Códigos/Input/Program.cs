using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\"input\" = variável que armazena uma entrada do usuário, podendo ser string, int, float, etc.\n");
        
        Input.String();
        Console.WriteLine();

        Input.TryParse();
        Console.WriteLine();

        Input.Numbers();
    }
}