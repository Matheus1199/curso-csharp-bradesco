class ParametroRef 
{
    public static void AlterarRef( ref int numero)
    {
        numero += 500;
    }

    public static void AlterarOut(int numero)
    {
        numero = 0;
        numero += 50;
    }

    public static void Main()
    {
        int x = 5;
        AlterarRef(ref x);
        Console.WriteLine(x);

        int y = 8;
        AlterarOut(y);
        Console.WriteLine(y);
    }
}
