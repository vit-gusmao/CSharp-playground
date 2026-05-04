using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Int();
            Console.WriteLine();

            Float();
            Console.WriteLine();

            String();
            Console.WriteLine();

            Bool();
            Console.WriteLine();

            Char();
            Console.WriteLine();

            Var();
        }

        static void String()
        {
            Console.WriteLine("\"string\" = variável que armazena uma sequência de caracteres somente usando \"\" (exemplo: string name = \"Vitor\";)");
            Console.Write("Digite algo: ");
            string algo = Console.ReadLine();
            Console.WriteLine($"você digitou \"{algo}\" e foi armazenado como string.\n");
        }

        static void Int()
        {
            Console.WriteLine("\"int\" = variável que armazena números inteiros (exemplo: int num = 10;)");
            while(true){
                try{
                    Console.Write("Digite um número inteiro: ");
                    int num = int.Parse(Console.ReadLine());
                    Console.WriteLine($"você digitou o número inteiro: {num}");
                    break;
                }catch{
                    Console.WriteLine("Você não digitou um número inteiro.");
                }
            }
        }

        static void Bool()
        {
            Console.WriteLine("\"bool\" = variável que armazena true ou false (exemplo: bool ativo = true;)");
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
        }

        static void Float()
        {
            Console.WriteLine("\"float\" = variável que armazena números reais (exemplo: float pi = 3.14f;)");
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
        }

        static void Char()
        {
            Console.WriteLine("\"char\" = variável que armazena um único caractere somente usando '' (exemplo: char letra = 'a';)");
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
        }

        static void Var()
        {
            Console.WriteLine("\"var\" = variável que armazena um valor de qualquer tipo.");
        }
    }
}