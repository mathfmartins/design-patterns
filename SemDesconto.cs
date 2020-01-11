namespace patterns {
    public class SemDesconto : IDesconto
    {
        public SemDesconto()
        {
            Proximo = null;
        }

        public IDesconto Proximo { get; set; }

        public decimal Descontar(Orcamento orcamento)
        {
            return 0;
        }
    }
}