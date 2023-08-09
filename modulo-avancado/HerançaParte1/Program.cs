using System.Diagnostics.CodeAnalysis;

public class Professor
{
    protected readonly float salariomaximo;
    float salarioatual;

    public Professor(float salarioMaximo)
    {
        salariomaximo = salarioMaximo;
    }


    protected float ModificaSalario(float Modf)
    {
        float novoSalario = salarioatual + Modf;

        if (novoSalario < 0)
        {
            salarioatual = 0;
        }
        else if (novoSalario > salariomaximo)
        {
            salarioatual = salariomaximo;
        }
        else
        {
            salarioatual = novoSalario;
        }

        return salarioatual;
    }

    public float AumentaSalario()
    {
        return ModificaSalario(+500);
    }

    public float DiminuiSalario()
    {
        return ModificaSalario(-500);
    }

    public class Prof : Professor
    {
        public Prof() : base(1400)
        {

        }
    }

    public static void Main()
    {
        Console.WriteLine("Professor 1: ");
        Prof prof1 = new Prof();
        Console.WriteLine(prof1.AumentaSalario());
        Console.WriteLine(prof1.AumentaSalario());
    }
    
}