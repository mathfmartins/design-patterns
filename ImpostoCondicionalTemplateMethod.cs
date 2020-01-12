namespace patterns {
    public abstract class ImpostoCondicionalTemplateMethod : Imposto
    {
        public ImpostoCondicionalTemplateMethod() : base() {}
        public ImpostoCondicionalTemplateMethod(Imposto outroImposto) : base(outroImposto) {}
        public override decimal CalcularImposto(Orcamento orcamento)
        {
            if (DeveUsarMaximaTaxacao(orcamento))
                return MaximaTaxacao(orcamento) + CalcularDoOutroImposto(orcamento);

            return MinimaTaxacao(orcamento);
        }

        protected abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);
        protected abstract decimal MaximaTaxacao(Orcamento orcamento);
        protected abstract decimal MinimaTaxacao(Orcamento orcamento);

    }
}