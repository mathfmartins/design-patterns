namespace patterns {
    public class Icms : Imposto {

        public Icms() : base() { }
        public Icms(Imposto outroImposto) : base(outroImposto) { }

        public override decimal CalcularImposto(Orcamento orcamento)
        {
            return orcamento.Valor * 0.01m + CalcularDoOutroImposto(orcamento);
        }
    }
}