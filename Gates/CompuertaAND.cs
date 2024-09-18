namespace Gates;

public class ANDGate : ITruthValue
{
    private List<ITruthValue> inputs = new List<ITruthValue>();
    private string Name { get; set; }

    public ANDGate(string name, ITruthValue firstInput)
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