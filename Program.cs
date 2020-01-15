﻿using patterns;

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

            //Testando builder
            var builder = new NotaFiscalBuilder();
            builder.ParaRazaoSocial("Jurídica")
                .ParaCnpj("71.539.819/0003-08")
                .ParaDataDeEmissao()
                .ParaItem(new ItemDaNota("Abajur", 299.00m))
                .ParaItem(new ItemDaNota("Espelho", 87.99m))
                .ParaItem(new ItemDaNota("Bandeira do México", 45.00m))
                .GetValorTotal()
                .GetValorImpostos()
                .ParaObservacoes("--Observações--");

            //Testando observer
            builder.AdicionarAcao(new EnviadorEmail());
            builder.AdicionarAcao(new EnviadorSms());
            builder.AdicionarAcao(new SalvarNoBanco());
            
            NotaFiscal notaFiscal_1 = builder.Construir();
            
            System.Console.WriteLine(notaFiscal_1.ValorTotal);
            System.Console.WriteLine(notaFiscal_1.Impostos);

            
            NotaFiscal notaFiscal_2 = builder.Construir();
        }
    }
}
