class Operators
{
    public Operators(float n1, float n2)
    {
        Arithmetic(n1, n2);
        Comparison(n1, n2);
        Logic(n1, n2);
    }

    public static void Arithmetic(float n1, float n2)
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

    public static void Comparison(float n1, float n2)
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

    public static void Logic(float n1, float n2)
    {
        Console.WriteLine($"""
        Operadores Lógicos:

        E   (&&): ({n1} > 0) && ({n2} > 0): {(n1 > 0) && (n2 > 0)}
        OU  (||): ({n1} > 0) || ({n2} > 0): {(n1 > 0) || (n2 > 0)}
        NÃO (!): !({n1} > 0): {! (n1 > 0)}
        """);
    }
}    