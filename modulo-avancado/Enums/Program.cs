class Enum
{
    public enum Genero { Filme, Serie, Documentario};


    public class Filme
    {
        public string Nome;
        public Genero TipoVideo;
    }

    static void Main()
    {
        int cod = (int)Genero.Documentario;
        Console.WriteLine(cod);
    }
}