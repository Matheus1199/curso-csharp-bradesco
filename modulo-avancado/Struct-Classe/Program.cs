class StructClasse 
{
    public struct PontoS
    {
        public int X;
        public int Y;
    }

    public class Pontoc 
    {
        public int X;
        public int Y;
    }
        public static void Main()
    {
        PontoS ponto = new PontoS { X = 5, Y = 3 };
        PontoS ponto2 = ponto;
        ponto.X = 3;

        Console.WriteLine("Ponto: {0}", ponto.X);
        Console.WriteLine("Ponto 2: {0}", ponto2.X);

        Pontoc ponto3 = new Pontoc { X = 6, Y = 9 };
        Pontoc ponto4 = ponto3;
        ponto3.X = 3;

        Console.WriteLine("Ponto 3 = {0} , Ponto 4 - {1}", ponto3.X, ponto4.X);
    }

}