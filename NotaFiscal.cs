using System;
using System.Collections.Generic;

namespace patterns {
    public class NotaFiscal {
        public NotaFiscal(string razaoSocial, string cnpj, DateTime dataDeEmissao, IList<ItemDaNota> itens, decimal valorTotal, decimal impostos, string observacoes)
        {
            RazaoSocial = razaoSocial;
            Cnpj = cnpj;
            DataDeEmissao = dataDeEmissao;
            Itens = itens;
            Observacoes = observacoes;
            ValorTotal = valorTotal;
            Impostos = impostos;
        }

        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public DateTime DataDeEmissao { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal Impostos { get; set; }
        public IList<ItemDaNota> Itens { get; set; }
        public string Observacoes { get; set; }
        
        public override string ToString() {
            return $"CNPJ: {Cnpj}, Data de Emissão: {DataDeEmissao}, Impostos R$: {Impostos}, Observações: {Observacoes}";
        }
    }
 }