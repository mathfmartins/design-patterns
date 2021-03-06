namespace patterns {
    public class Irrs : ImpostoCondicionalTemplateMethod
    {
        public Irrs() : base() {}
        public Irrs(Imposto outroImposto) : base(outroImposto)
        {
        }
        
        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            if (ListDeItensPossuiDoisNomesIguais(orcamento)) 
                return true;
            return false;
                     
        }

        public bool ListDeItensPossuiDoisNomesIguais(Orcamento orcamento) {
            for (int i = 0; i <= orcamento.Itens.Count; i++) {
                for (int x = i+1; x < orcamento.Itens.Count; x++) { 
                    if (orcamento.Itens[i].Nome == orcamento.Itens[x].Nome) {
                        System.Console.WriteLine("Máximo desconto aplicado.");
                        return true;
                    }
                }
            }   
            return false;
        }

        protected override decimal MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.13m + 100;
        }

        protected override decimal MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * (0.01m * orcamento.Itens.Count);
        }
    }
}