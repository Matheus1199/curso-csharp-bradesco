class MetodoEstatico
{
    public static int somar(int x, int y)
    {
        return x + y;
    }

    public int multiplicar(int x, int y)
    {
        return x * y;
    }

    static void Main(string[] args)
    {
        var result = MetodoEstatico.somar(3, 2);
        Console.WriteLine("A soma é igual a {0}", result);

        MetodoEstatico calc = new MetodoEstatico();
        Console.WriteLine(calc.multiplicar(2,3));
    }
}