namespace Gates;

public class CompuertaNOT : IValorEntrada
{
    public string name { get; set; }
    private IValorEntrada input;
    public CompuertaNOT(string nombre, IValorEntrada input)

{
        this.name = nombre;
        this.input = input;
    }

    public bool Calcular()
    {
        return !this.input.Calcular();
    }
}