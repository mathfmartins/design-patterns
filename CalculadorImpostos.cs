namespace patterns
{
    public class CalculadorImpostos {
        public decimal RealizarCalculo(Orcamento orcamento, Imposto imposto) {
            return imposto.CalcularImposto(orcamento);
        }
    }
}