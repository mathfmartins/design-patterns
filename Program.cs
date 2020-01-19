using System.Collections.Generic;
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

            Imposto irrs = new Irrs();
            irrs.CalcularImposto(orcamento);

            //Testando decorator
            Imposto icms = new Icms(new Iss());
            System.Console.WriteLine(icms.CalcularImposto(orcamento));
            
            Imposto icpp = new Icpp(new Ikcv());
            System.Console.WriteLine(icpp.CalcularImposto(orcamento));

            //Testando state
            var reforma = new Orcamento(500.00m);
            reforma.AplicarDescontoExtra();
            System.Console.WriteLine(reforma.Valor);

            reforma.Aprovar();

            reforma.AplicarDescontoExtra();
            System.Console.WriteLine(reforma.Valor);

            reforma.Finalizar();
            // reforma.AplicarDescontoExtra();
            // reforma.Reprovar();

            //Testando builder e observer
            var listaDeAcoes = new List<AcaoAposGerarNotaFiscal>() {
                new EnviadorEmail(),
                new EnviadorSms(),
                new SalvarNoBanco()
            };
            var builder = new NotaFiscalBuilder(listaDeAcoes);
            
            builder.ParaRazaoSocial("Jurídica")
                .ParaCnpj("71.539.819/0003-08")
                .ParaDataDeEmissao()
                .ParaItem(new ItemDaNota("Abajur", 299.00m))
                .ParaItem(new ItemDaNota("Espelho", 87.99m))
                .ParaItem(new ItemDaNota("Bandeira do México", 45.00m))
                .GetValorTotal()
                .GetValorImpostos()
                .ParaObservacoes("--Observações--");
            
            NotaFiscal notaFiscal_1 = builder.Construir();
            System.Console.WriteLine(notaFiscal_1.ValorTotal);
            System.Console.WriteLine(notaFiscal_1.Impostos);
            NotaFiscal notaFiscal_2 = builder.Construir();

            //Mais um exemplo de builder
            var emailBuilder = new EmailBuilder();
            emailBuilder
            .Usuario("Matheus Martins")
            .Destinatario("Amanda Mollina")
            .Assunto("Clean Code")
            .Mensagem("Você pode me emprestar um livro sobre clean code?");
            Email email = emailBuilder.Construir();
            System.Console.WriteLine(email);
        }
    }
}