class MetodosEstaticos
{
    public static int somar(int x, int y)
    {
        return x + y;
    }

    public static int multiplicar(int x, int y)
    {
        return (x * y);
    }

    static void Main(string[] args)
    {
        var result = MetodosEstaticos.somar(1, 2);
        Console.WriteLine("A soma é igual a: {0}", result);

        Console.WriteLine(MetodosEstaticos.multiplicar(3, 2));
    }
}