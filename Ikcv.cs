using System;

namespace patterns {
    public class Ikcv : ImpostoCondicionalTemplateMethod
    {
        public Ikcv() : base()
        {
        }

        public Ikcv(Imposto outroImposto) : base(outroImposto)
        {
        }

        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor > 500 && ItemMaiorQue100ReaisNo(orcamento);
        }

        protected override decimal MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1m;
        }

        protected override decimal MinimaTaxacao(Orcamento orcamento)
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