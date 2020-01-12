namespace patterns {

    //Imposto criado para ser usado com o padrão Template Method
    public class Icpp : ImpostoCondicionalTemplateMethod
    {
        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor >= 500;
        }

        protected override decimal MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.07m;
        }

        protected override decimal MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05m;
        }
    }
}