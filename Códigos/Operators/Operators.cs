class Operators
{
    public Operators(double n1, double n2)
    {
        Arithmetic(n1, n2);
        Comparison(n1, n2);
        Logic(n1, n2);
    }

    public static void Arithmetic(double n1, double n2)
    {
        Console.WriteLine($"""
        Operadores Aritméticos:
        Adição: {n1} + {n2} = {n1 + n2}
        Subtração: {n1} - {n2} = {n1 - n2}
        Multiplicação: {n1} * {n2} = {n1 * n2}
        Divisão: {n1} / {n2} = {n1 / n2}
        Resto da Divisão: {n1} % {n2} = {n1 % n2}
        Incrementando variável: n1 = n1 + 1 -> n1+=1: {n1+=1}
        """);
    }

    public static void Comparison(double n1, double n2)
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

    public static void Logic(double n1, double n2)
    {
        Console.WriteLine($"""
        Operadores Lógicos:

        E   (&&): ({n1} > 0) && ({n2} > 0): {(n1 > 0) && (n2 > 0)}
        OU  (||): ({n1} > 0) || ({n2} > 0): {(n1 > 0) || (n2 > 0)}
        NÃO (!): !({n1} > 0): {! (n1 > 0)}
        """);
    }
}