using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Matematica  
{
    class comandos
    {
        static void Main(string[] args)
        {
            //Math.Abs() = Número somado ou subtraido que é igual a 0.
            Console.WriteLine("Digite um número");
            var numberAbs = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"o número {numberAbs} somado ou subtraido com o número {Math.Abs(numberAbs)} da 0.");

            //Math.Sqrt() = Calcula a raiz quadrada de um número.
            Console.WriteLine("Digite um número");
            var numberSqrt = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"A raiz quadrada do número {numberSqrt} é {Math.Abs(numberAbs)}.");

            //Math.Floor() Arredonda o número para o menor inteiro mais próximo e Math.Ceiling o maior inteiro mais próximo
            Console.WriteLine("Digite um número decimal");
            var numberArredondar = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"O número {numberArredondar} arrendodado para o menor inteiro é {Math.Floor(numberArredondar)} e o maior inteiro é {Math.Ceiling(numberArredondar)}.");

            //Math.Min() Retorna o menor número, Math.Max() retorna o maior número
            Console.WriteLine("Digite 2 Números");
            Console.WriteLine("Primeiro Número");
            var number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Segundo Número");
            var number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"O menor número é {Math.Min(number1, number2)} e o maior número é {Math.Max(number1, number2)}");

        }
    }
}