using System;

namespace InfoStrings
{
    class stringcarac
    {
        static void Main(string[] args)
        {
            //quantidade de caracteres em uma string e localizar carateres especiais
            Console.WriteLine("Crie uma senha: ");
            string senha = Console.ReadLine();
            int senhaSize = senha.Length;
            Console.WriteLine($"sua senha possui {senhaSize} caracteres.\n");
            Console.WriteLine("digite um caractere para pesquisar se possui ou não em sua senha");
            string caracSearch = Console.ReadLine();
            int checkSymb = senha.IndexOf(caracSearch);
            if (checkSymb == -1)
            {
                Console.WriteLine("não há o caractere que você buscou em sua senha");
            }
            else
            {
                Console.WriteLine($"o caractere que você buscou está na {checkSymb} posição");
            }
   
        }
    }
}