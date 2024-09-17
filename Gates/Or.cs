namespace Gates;

public class OrGate : ITruthValue 
{
    
        private List<ITruthValue> inputs = new List<ITruthValue>();
        private string Name { get; set; }
        

        public OrGate(string name, ITruthValue firstInput)
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