namespace patterns {
    public class EmailBuilder {
        public EmailBuilder() { 
            Email = new Email();
        } 
        private Email Email { get; set; }

        public EmailBuilder Usuario(string usuario) {
            Email.Usuario = usuario;
            return this;
        }

        public EmailBuilder Destinatario(string destinatario) {
            Email.Destinatario = destinatario;
            return this;
        }

        public EmailBuilder Assunto(string assunto) {
            Email.Assunto = assunto;
            return this;
        }

        public EmailBuilder Mensagem(string mensagem) { 
            Email.Mensagem = mensagem;
            return this;
        }

        public Email Construir() { 
            return Email;
        }
    }
}