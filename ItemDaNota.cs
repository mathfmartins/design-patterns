namespace patterns
{
    public class ItemDaNota
    {
        public ItemDaNota()
        {
        }

        public ItemDaNota(string nome, decimal valor)
        {
            Nome = nome;
            Valor = valor;
        }

        public string Nome { get; set; }
        public decimal Valor { get; set; }

    }
}