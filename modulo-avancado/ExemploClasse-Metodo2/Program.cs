using System.Runtime.CompilerServices;

class Aluno
{
    public string Nome;
    public int Idade;
    public int Serie;

    public string Retorno()
    {
        return string.Format($"O aluno {Nome} tem {Idade} anos e está na {Serie} serie");
    }

    public void RetornoConsole()
    {
        Console.WriteLine(Retorno());
    }
}


internal class Program
{
    private static void Main(string[] args)
    {
        Aluno aluno1 = new Aluno();
            aluno1.Nome = "João";
            aluno1.Idade = 13;
            aluno1.Serie = 6;

        aluno1.RetornoConsole();
    }
}