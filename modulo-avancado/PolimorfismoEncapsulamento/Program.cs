public class Mensagem
{
    private String Texto;

    public void Exibir()
    {
        Console.WriteLine(this.Texto);
    }

    public String getTexto()
    {
        return this.Texto;
    }

    public void setTexto(String txt)
    {
        this.Texto = txt;
    }

    static void Main(string [] args)
    {
        Mensagem txt1, txt2;


        txt1 = new Mensagem();
        txt1.setTexto("CURSO AVANÇADO DE C#");
        txt1.Exibir();
    }
}