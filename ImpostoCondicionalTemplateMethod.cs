namespace patterns {
    public abstract class ImpostoCondicionalTemplateMethod : IImposto
    {
        //A idéia é que a estrutura condicional de CalcularImposto só exista no template 
        public decimal CalcularImposto(Orcamento orcamento)
        {
            if (DeveUsarMaximaTaxacao(orcamento))
                return MaximaTaxacao(orcamento);

            return MinimaTaxacao(orcamento);
        }

        public abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);
        public abstract decimal MaximaTaxacao(Orcamento orcamento);
        public abstract decimal MinimaTaxacao(Orcamento orcamento);

    }
}