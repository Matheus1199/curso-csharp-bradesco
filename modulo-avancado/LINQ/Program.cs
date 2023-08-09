using System;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(String[] args)
        {
            int[] numeros = new int[] { 4, 5, 7, 8 };

            var operacao = numeros.Where(x => x % 2 == 0);

            foreach (int x in operacao)
            {
                Console.WriteLine(x);
            }
        }
    }
}