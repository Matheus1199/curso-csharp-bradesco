using System.Security.AccessControl;
using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Bem vindo ao programa de calcular média ;)");

        // Coletando as notas

        Console.WriteLine("Qual a sua primeira nota? ");
        int.TryParse(Console.ReadLine(), out int nota1);

        Console.WriteLine("Qual a sua segunda nota");
        int.TryParse(Console.ReadLine(), out int nota2);

        Console.WriteLine("Qual a sua terceira nota");
        int.TryParse(Console.ReadLine(), out int nota3);

        // Calculando a média

        float media = (nota1 + nota2 + nota3) / 3;

        Console.WriteLine("A média do aluno é {0}", media);

        // Vendo se ele foi aprovado ou reprovado

        if (media < 7)
        {
            Console.WriteLine("Aluno está em recuperação");
        }
        else
        {
            Console.WriteLine("Aluno aprovado");
        }
    }

}
