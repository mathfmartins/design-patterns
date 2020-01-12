namespace patterns {
    public abstract class Imposto
    {
        protected Imposto OutroImposto { get; set; }
        public Imposto() {
            OutroImposto = null;
        }

        public Imposto(Imposto outroImposto)
        {
            OutroImposto = outroImposto;
        }

        public abstract decimal CalcularImposto(Orcamento orcamento);
        protected decimal CalcularDoOutroImposto(Orcamento orcamento)
        {
            if (OutroImposto == null)
                return 0;
            else
                return OutroImposto.CalcularImposto(orcamento);
        }
    }
}