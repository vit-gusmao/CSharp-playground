using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\"int\" = váriavel que armazena números inteiros (exemplo: int num = 10;)");
           while(true){
           try{
                Console.Write("Digite um número inteiro: ");
                int n_int = int.Parse(Console.ReadLine());
                Console.WriteLine($"você digitou o número inteiro: {n_int}");
                break;
            }catch{
                Console.WriteLine("Você não digitou um número inteiro.");
            }
        }
            Console.WriteLine();
            
            Console.WriteLine("\"float\" = váriavel que armazena números reais (exemplo: float pi = 3.14f;)");
            while(true){
                try{
                    Console.Write("Digite um número real: ");
                    float flt = float.Parse(Console.ReadLine());
                    Console.WriteLine($"você digitou o número real: {flt}");
                    break;
                }catch{
                    Console.WriteLine("Você não digitou um número real.");
                }
        }
            Console.WriteLine();

            Console.WriteLine("\"string\" = váriavel que armazena uma sequência de caracteres somente usando \"\" (exemplo: string name = \"Vitor\";)");
            Console.Write("Digite algo: ");
            string algo = Console.ReadLine();
            Console.WriteLine($"você digitou \"{algo}\" e foi armazenado como string.\n");

            Console.WriteLine("\"bool\" = váriavel que armazena true ou false (exemplo: bool ativo = true;)");
             float n1, n2;
             while(true){
                try{
                    Console.Write("Digite um número: ");
                    n1 = float.Parse(Console.ReadLine());
                    Console.Write("Digite outro número: ");
                     n2 = float.Parse(Console.ReadLine());
                    break;
                }catch{
                    Console.WriteLine("Você não digitou um número.");
                }
        }
            bool verify = n1 > n2;
            Console.WriteLine($"o número {n1} é maior que o número {n2}: {verify}\n");
            
            Console.WriteLine("\"char\" = váriavel que armazena um único caractere somente usando '' (exemplo: char letra = 'a';)");
            while(true){
                try{
                    Console.Write("Digite um caractere: ");
                    char ch = char.Parse(Console.ReadLine());
                    Console.WriteLine($"você digitou o caractere: {ch}");
                    break;
                }catch{
                    Console.WriteLine("Você não digitou um caractere.");
                }
        }
            Console.WriteLine();

            Console.WriteLine("\"var\" = váriavel que armazena um valor de qualquer tipo.");
        }
    }
}