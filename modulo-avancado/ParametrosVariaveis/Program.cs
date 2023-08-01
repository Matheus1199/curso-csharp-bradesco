class Parametros
{
    public static void Despedida(params string[] alunos)
    {
        foreach (var aluno in alunos)
        {
            Console.WriteLine("Tchau {0}, até a próxima aula", aluno);
        }
    }

    static void Main(string[] args)
    {
        Despedida("Joao", "Thiago", "Antonio");
    }
}



