namespace patterns {
    public class Email { 
        public string Usuario { get; set; }
        public string Destinatario { get; set; }
        public string Assunto { get; set; }
        public string Mensagem { get; set; }

        public override string ToString() { 
            return $"Usuário: {Usuario}\nDestinatário: {Destinatario}\nAssunto: {Assunto}\nMensagem: {Mensagem}";
        }
    }

}