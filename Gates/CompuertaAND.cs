namespace Gates;

public class ANDGate : IValorEntrada
{
    private List<IValorEntrada> inputs = new List<IValorEntrada>();
    private string Name { get; set; }

    public ANDGate(string name, IValorEntrada firstInput)
    {
        this.Name = name;
        this.inputs.Add(firstInput);
    }

    public bool Evaluate
    {
        get
        {
            bool resultado = this.inputs[0].Evaluate;
            for (int i = 1; i < this.inputs.Count; i++)
            {
                resultado = resultado && this.inputs[i].Evaluate;
            }

            return resultado;
        }

    
        
    
    
    }