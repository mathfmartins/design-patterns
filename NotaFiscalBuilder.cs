using System;
using System.Collections.Generic;

namespace patterns { 
    public class NotaFiscalBuilder { 
        public NotaFiscalBuilder() {
            TodosOsItens = new List<ItemDaNota>();
        }
        public NotaFiscal Construir() {
            return new NotaFiscal(RazaoSocial, Cnpj, DataDeEmissao, TodosOsItens, ValorTotal, Impostos, Observacoes);
        }

        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public System.DateTime DataDeEmissao { get; private set; }
        public decimal ValorTotal { get; private set; }
        public decimal Impostos { get; private set; }
        public IList<ItemDaNota> TodosOsItens = new List<ItemDaNota>();
        private string Observacoes { get; set; }

        public NotaFiscalBuilder ParaRazaoSocial(string razaoSocial) { 
            RazaoSocial = razaoSocial;
            return this;
        }
        
        public NotaFiscalBuilder ParaCnpj(string cnpj) {
            Cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilder ParaDataDeEmissao() {
            DataDeEmissao = System.DateTime.Now;
            return this;
        }


        public NotaFiscalBuilder ParaObservacoes(string observacoes) {
            Observacoes = observacoes;
            return this;
        }

        public NotaFiscalBuilder ParaItem(ItemDaNota itemDaNota)
        {
            TodosOsItens.Add(itemDaNota);
            return this;
        }

        public NotaFiscalBuilder GetValorTotal()
        {
            foreach (var item in TodosOsItens)
            {
                ValorTotal += item.Valor;
            }
            return this;
        }

        public NotaFiscalBuilder GetValorImpostos() {
            foreach (var item in TodosOsItens) {
                Impostos += item.Valor * 0.03m;
            }
            return this;
        }
    }
}