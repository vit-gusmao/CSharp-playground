using System;

namespace Operators
{

class Program
{
    static void Main(string[] args)
    {
        float n1, n2;
        while (true){
            try {
                 Console.Write("Digite um número: ");
                 n1 = float.Parse(Console.ReadLine());
                 Console.Write("Digite outro número: ");
                 n2 = float.Parse(Console.ReadLine());
                 break;
            }catch{
                Console.WriteLine("Digite somente números.");
            }
          }
            Console.WriteLine();

            Arithmetic(n1, n2);
            Console.WriteLine();

            Comparison(n1, n2);

        }
 
     static void Arithmetic(float n1, float n2)
    {
        Console.WriteLine($"""
        Operadores Aritméticos:

        Adição: {n1} + {n2} = {n1 + n2}
        Subtração: {n1} - {n2} = {n1 - n2}
        Multiplicação: {n1} * {n2} = {n1 * n2}
        Divisão: {n1} / {n2} = {n1 / n2}
        Resto da Divisão: {n1} % {n2} = {n1 % n2}
        """);
    }

    static void Comparison(float n1, float n2)
    {
        Console.WriteLine($"""
        Operadores de Comparação:

        Igual (==): {n1} == {n2}: {n1 == n2}
        Diferente (!=): {n1} != {n2}: {n1 != n2}
        Maior que (>): {n1} > {n2}: {n1 > n2}
        Menor que (<): {n1} < {n2}: {n1 < n2}
        Maior ou igual (>=): {n1} >= {n2}: {n1 >= n2}
        Menor ou igual (<=): {n1} <= {n2}: {n1 <= n2}
        """);
    }   
  }
}

