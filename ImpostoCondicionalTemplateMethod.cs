namespace patterns {
    public abstract class ImpostoCondicionalTemplateMethod : IImposto
    {
        public decimal CalcularImposto(Orcamento orcamento)
        {
            if (DeveUsarMaximaTaxacao(orcamento))
                return MaximaTaxacao(orcamento);

            return MinimaTaxacao(orcamento);
        }

        protected abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);
        protected abstract decimal MaximaTaxacao(Orcamento orcamento);
        protected abstract decimal MinimaTaxacao(Orcamento orcamento);

    }
}