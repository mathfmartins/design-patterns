namespace patterns {
    public class Iss : Imposto {
        
        public Iss() :base() {}
        public Iss(Imposto outroImposto) : base(outroImposto) {

        }
         public override decimal CalcularImposto(Orcamento orcamento) {
            return orcamento.Valor * 0.06m + CalcularDoOutroImposto(orcamento);
        }
    
        
    }
} 