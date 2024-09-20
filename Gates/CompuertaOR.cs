namespace Gates;

public class CompuertaOR : IValorEntrada
{
    public string name { get; }
    public List<bool> entradas = new List<bool>();


    public CompuertaOR(string nombre)
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
            if (e == true)
            {
                return true;
            }
        }

        return false;
    }
}