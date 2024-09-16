namespace Gates;

public class CompuertaNOT : IValorEntrada
{
    private IValorEntrada entrada;
    private string name;

    public CompuertaNOT(string name, IValorEntrada entrada)
    {
        this.Name = name;
        this.entrada = entrada;
    }

    public string Name
    {
        get { return name;}
        set { name = value; }
    }

    public bool Evaluar
    {
        get
        {
            return !this.entrada.Evaluar;
        }
    }
}