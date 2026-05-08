class Operators
{
    public Operators(double[] n)
    {
        Arithmetic(n);
        Comparison(n);
        Logic(n);
    }

    public static void Arithmetic(double[] n)
    {
        Console.WriteLine($"""
        Operadores Aritméticos:
        Adição: {n[0]} + {n[1]} = {n[0] + n[1]}
        Subtração: {n[0]} - {n[1]} = {n[0] - n[1]}
        Multiplicação: {n[0]} * {n[1]} = {n[0] * n[1]}
        Divisão: {n[0]} / {n[1]} = {n[0] / n[1]}
        Resto da Divisão: {n[0]} % {n[1]} = {n[0] % n[1]}
        Incrementando variável: n[0] = n[0] + 1 -> n[0]+=1: {n[0] + 1}
        """);
    }

    public static void Comparison(double[] n)
    {
        Console.WriteLine($"""
        Operadores de Comparação:

        Igual (==): {n[0]} == {n[1]}: {n[0] == n[1]}
        Diferente (!=): {n[0]} != {n[1]}: {n[0] != n[1]}
        Maior que (>): {n[0]} > {n[1]}: {n[0] > n[1]}
        Menor que (<): {n[0]} < {n[1]}: {n[0] < n[1]}
        Maior ou igual (>=): {n[0]} >= {n[1]}: {n[0] >= n[1]}
        Menor ou igual (<=): {n[0]} <= {n[1]}: {n[0] <= n[1]}
        """);
    }

    public static void Logic(double[] n)
    {
        Console.WriteLine($"""
        Operadores Lógicos:

        E   (&&): ({n[0]} > 0) && ({n[1]} > 0): {(n[0] > 0) && (n[1] > 0)}
        OU  (||): ({n[0]} > 0) || ({n[1]} > 0): {(n[0] > 0) || (n[1] > 0)}
        NÃO (!): !({n[0]} > 0): {! (n[0] > 0)}
        """);
    }
}