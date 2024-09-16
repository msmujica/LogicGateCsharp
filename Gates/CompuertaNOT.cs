namespace Gates;

public class CompuertaNOT : IValorEntrada
{
    public string name { get; set; }
    public bool entrada { get; set; }

    public CompuertaNOT(string nombre, bool entrada)
    {
        this.name = nombre;
        this.entrada = entrada;
    }

    public bool Calcular()
    {
        return !this.entrada;
    }
}