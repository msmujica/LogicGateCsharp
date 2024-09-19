using Gates;
public class logicalV : IValorEntrada
{
    public static IValorEntrada instance { get; } = new logicalV();
    private logicalV()
    {
        
    }

    public string name => "Logical True";

    public bool Calcular()
    {
        return true;
        
    }
    
}
    
   