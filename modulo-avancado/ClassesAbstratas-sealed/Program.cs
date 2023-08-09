public abstract class Telefone
{
    public abstract string Tipo();
}

public class Xiaomi : Telefone 
{
    public override string Tipo()
    {
        return "Note 8 pro";
    }
    
}