using Gates;

public class logicalF : IValorEntrada
{
    public static IValorEntrada instance { get; } = new logicalF();

    private logicalF()
    {
        
    }

    public string name => "Logical False";
    public bool Calcular()
    { 
        return true;
    }
    
}
