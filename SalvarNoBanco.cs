namespace patterns { 
    public class SalvarNoBanco : AcaoAposGerarNotaFiscal { 
        public override void Executar() {
            System.Console.WriteLine("Persistindo os dados..");
        }
    }
}