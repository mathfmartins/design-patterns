using System.Collections.Generic;

namespace patterns
{
    public class Orcamento {
        public Orcamento(decimal valor) {
            Valor = valor;
            Itens = new List<Item>();
            Estado = new EmAprovacao();
        }

        public decimal Valor {get; set;}
        public List<Item> Itens { get; set; }
        public EstadoDeUmOrcamento Estado { get; set; }

        public void AdicionarItem(Item item) {
            Itens.Add(item);
        }

        public void AplicarDescontoExtra() {
            Estado.AplicaDescontoExtra(this);
        }

        public void Aprovar() {
            Estado.Aprovar(this);
        }
         public void Reprovar() {
            Estado.Reprovar(this);
        }
         public void Finalizar() {
            Estado.Finalizar(this);
        }
    }
}