using System;

namespace patterns {
    public class Ikcv : ImpostoCondicionalTemplateMethod
    {
        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor > 500 && ItemMaiorQue100ReaisNo(orcamento);
        }

        public override decimal MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1m;
        }

        public override decimal MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06m;
        }
        private bool ItemMaiorQue100ReaisNo(Orcamento orcamento)
        {
            foreach (Item item in orcamento.Itens) {
                if (orcamento.Valor > 100)
                    return true;
            }
            return false;
        }
    }
}