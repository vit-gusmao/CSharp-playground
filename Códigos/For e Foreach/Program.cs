using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("""
        \"for(x;y;z)\"
        x =  contador
        y =  condição do contador
        z =  incremento / decremento do contador

        """);
        Console.WriteLine();

        ForForeach.For();

        Console.WriteLine("""
        \"foreach(var in array)\"
          foreach percorre todos os elementos de um array
          var = variável que armazenará o valor de cada elemento do array
          array = array que será percorrido
        """);
        Console.WriteLine();

        ForForeach.Foreach();
    }
}
