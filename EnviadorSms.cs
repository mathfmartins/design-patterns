namespace patterns {
    public class EnviadorSms : AcaoAposGerarNotaFiscal
    {
        public override void Executar()
        {
            System.Console.WriteLine("Enviando SMS..");
        }
    }
}