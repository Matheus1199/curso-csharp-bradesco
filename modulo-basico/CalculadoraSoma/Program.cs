using System;

internal class Program
{
    private static void Main(string[] args)
    {
        bool opcao = true;

        Console.WriteLine("Bem-vindo a Calculadora de Soma");

        Console.WriteLine("Digite o valor inicial");
        float.TryParse(Console.ReadLine(), out float inicial);

        while (opcao == true)
        {
            Console.WriteLine("Digite o número que deseja somar com o número inicial");
            float.TryParse(Console.ReadLine(), out float n1);
            inicial = inicial + n1;
            Console.WriteLine("A soma até o momento é {0}", inicial);
            Console.WriteLine("Deseja sair do programa? 1 - sim e 2 - não");
            int.TryParse(Console.ReadLine(), out int saida);
            switch (saida) {
                case 1:
                    Console.WriteLine("Saindo do programa");
                    opcao = false;
                    break;
                case 2:
                    Console.WriteLine("Continua a soma");
                    break;
                default:
                    Console.WriteLine("Opção Inválida. Retornando para soma");
                    break;
            }
        }
    }
}