namespace patterns {

    //Imposto criado para ser usado com o padrão Template Method
    public class Icpp : ImpostoCondicionalTemplateMethod
    {
        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor >= 500;
        }

        public override decimal MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.07m;
        }

        public override decimal MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05m;
        }
    }
}