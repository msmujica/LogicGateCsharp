namespace Gates;

public class OrGate : IValorEntrada 
{
    
    private List<IValorEntrada> inputs = new List<IValorEntrada>();
    private string Name { get; set; }
        

    public OrGate(string name, IValorEntrada firstInput)
    {
        this.Name = name;
        this.inputs.Add(firstInput);
    }

    public bool Evaluar
    {
        get
        {
            bool result = this.inputs[0].Evaluar;
            for (int i = 1; i < this.inputs.Count; i++)
            {
                result = result || this.inputs[i].Evaluar;
            }

            return result;
        }
            
    }
    
}