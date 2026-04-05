using System;

namespace GettingInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual seu nome ?");//Console.Write escreve o input na mesma linha.
            var nome = Console.ReadLine(); //Console.ReadLine(); atribui um valor no que foi inserido em string
            Console.WriteLine($"Seu nome é {nome}");//$ é usado para puxar uma var dentro de uma string com {nome da var}

            Console.WriteLine("Qual sua idade ?");//Console.WriteLine escreve o input na linha debaixo
            int idade = Convert.ToInt32(Console.ReadLine());//Console.ReadLine() obrigatoriamente é string, então pra converter para int se usa Convert.ToInt32()
            Console.WriteLine($"Você tem {idade} anos");//$ é usado para puxar uma var dentro de uma string com {nome da var}
        }
    }
}
