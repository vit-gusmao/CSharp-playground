using System;
using Internal;

class Arrays
{
    public static void Array()
    {
        Console.WriteLine("""
        Arrays = variáveis que armazenam uma lista de valores em diferentes formas:
        
        "var_type[] var = new var[quantidade_de_valores];" 
        "var_type[] var = new var[quantidade_de_valores] {valor1, valor2, valor3, ...};" já insere os valores na variável com array.
        "var_type[] var = var{valor1, valor2, valor3, ...};" não precisa de new var e já indica a quantidade de valores automaticamente pela quantidade de valores inseridos.
   
        declarando posições da lista:
        var[0] = primeiro valor da lista.
        var[1] = segundo valor da lista.
        var[2] = terceiro valor da lista.
        ...
        
        """);
        Console.WriteLine("");
    }
}