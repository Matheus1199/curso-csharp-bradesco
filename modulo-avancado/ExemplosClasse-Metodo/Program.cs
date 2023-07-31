class Aluno //Class
{
    // Atributos
    public string Nome;
    public int Idade;
    public int Serie;
}


internal class Program
{
    private static void Main(string[] args)
    {
        Aluno aluno1 /* <- Objeto */ = new Aluno(); // <- Metodo
        aluno1.Nome = "João";
        aluno1.Idade = 8;
        aluno1.Serie = 3;

        Console.WriteLine($"O aluno {aluno1.Nome} tem {aluno1.Idade} anos e está na {aluno1.Serie} serie");
    }
}