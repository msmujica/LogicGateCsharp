namespace Gates;

public class CompuertaAND : IValorEntrada
{
    public string name { get; }
    public List<bool> entradas = new List<bool>();


    public CompuertaAND(string nombre)
    {
        this.name = nombre;
    }
    
    public void agregarEntrada(bool entrada)
    {
        entradas.Add(entrada);
    }

    public bool Calcular()
    {
        foreach (var e in entradas)
        {
            if (e == false)
            {
                return false;
            }
        }
        return true;
    }
}