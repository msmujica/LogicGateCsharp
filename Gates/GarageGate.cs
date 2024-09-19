namespace Gates;

public class GarageGate
{
    public bool Abrir(bool A, bool B, bool C)
    {
        IValorEntrada inputA = new LogicalValor(A);
        IValorEntrada inputB = new LogicalValor(B);
        IValorEntrada inputC = new LogicalValor(C);


        IValorEntrada notA = new CompuertaNOT("Not A", inputA);
        IValorEntrada notB = new CompuertaNOT("Not B", inputB);
        CompuertaAND condition1 = new CompuertaAND("Condicion 1", notA);
        condition1.AddInput(notB);
        condition1.AddInput(inputC);

        CompuertaAND condition2 = new CompuertaAND("Condicion 2", inputA);
        condition2.AddInput(inputB);
        condition2.AddInput(inputC);

        CompuertaOR finalCondition = new CompuertaOR("Condicion final", condition1);
        finalCondition.AddInput(condition2);

        return finalCondition.Calcular();

    }
}

public class LogicalValor : IValorEntrada
{
    private bool value;

    public LogicalValor(bool value)
    {
        this.value = value;
    }

    public string name => value ? "True" : "False";

    public bool Calcular()
    {
        return this.value;
    }

}