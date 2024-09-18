namespace Gates
{
    public class CompuertaAND : IValorEntrada
    {
        private List<IValorEntrada> inputs = new List<IValorEntrada>();
        public string name { get; set; }

        public CompuertaAND(string name, IValorEntrada firstInput)
        {
            this.name = name;
            this.inputs.Add(firstInput);
        }
        
        public bool Calcular()
        {
            bool result = this.inputs[0].Calcular();
            for (int i = 1; i < this.inputs.Count; i++)
            {
                result = result && this.inputs[i].Calcular();
            }

            return result;
        }
    }
}