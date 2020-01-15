namespace patterns {
    public class EnviadorEmail : AcaoAposGerarNotaFiscal
    {
        public override void Executar()
        {
            System.Console.WriteLine("Enviando email..");
        }
    }
}