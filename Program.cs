using patterns;

namespace design_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculador = new CalculadorDesconto();
            var orcamento = new Orcamento(500);
            orcamento.AdicionarItem(new Item("Coca-Cola", 8.72m));
            orcamento.AdicionarItem(new Item("Arroz", 21.00m));
            orcamento.AdicionarItem(new Item("Smart TV", 1900));
            orcamento.AdicionarItem(new Item("Notebook", 3499));
            orcamento.AdicionarItem(new Item("Churrasqueira", 500));
            orcamento.AdicionarItem(new Item("Smart TV", 5399.99m));
            orcamento.AdicionarItem(new Item("Fogão", 500));
            
            decimal desconto = calculador.Calcular(orcamento);
            System.Console.WriteLine(desconto);

            var irrs = new Irrs();
            irrs.CalcularImposto(orcamento);

            //Decorator
            Imposto icms = new Icms(new Iss());
            System.Console.WriteLine(icms.CalcularImposto(orcamento));

            Imposto icms2 = new Icms();
            System.Console.WriteLine(icms2.CalcularImposto(orcamento)); 
                 



        }
    }
}
