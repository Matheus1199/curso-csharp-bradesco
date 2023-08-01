class ParametroPadrao
{
    public static double Multiplica(double x = 3.4, double y = 3)
    {
        return x * y;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(Multiplica());
    }
}