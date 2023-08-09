namespace Delegate
{
    delegate double BinaryNumericOperation(double n1, double n2);

    class Program
    {


        class Calculadora
        {

            public static double Max(double x, double y)
            {
                if (x > y)
                {
                    return x;
                }
                else 
                {
                    return y;
                }
            }

            public static double soma(double x, double y)
            {
                return x+ y;
            }
            static void Main(string[] args)
            {
                double a = 40;
                double b = 30;

                BinaryNumericOperation operacao = Calculadora.soma;

                Console.WriteLine(operacao(a,b));
            }
                
        }
    }
}