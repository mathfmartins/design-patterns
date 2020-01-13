namespace patterns
{
    public abstract class EstadoDeUmOrcamento
    {
        public abstract decimal AplicaDescontoExtra(Orcamento orcamento); 

        public abstract void Aprovar(Orcamento orcamento);
        public abstract void Reprovar(Orcamento orcamento);
        public abstract void Finalizar(Orcamento orcamento);
    }

    public class EmAprovacao : EstadoDeUmOrcamento
    {
        public override decimal AplicaDescontoExtra(Orcamento orcamento)
        {
            return orcamento.Valor -= orcamento.Valor * 0.05m;
        }

        public override void Aprovar(Orcamento orcamento)
        {
            orcamento.Estado = new Aprovado();
        }

        public override void Finalizar(Orcamento orcamento)
        {
            throw new System.Exception("Orçamento em aprovação não pode ir para o estado finalizado");
        }

        public override void Reprovar(Orcamento orcamento)
        {
            orcamento.Estado = new Reprovado();
        }
    }

    public class Aprovado : EstadoDeUmOrcamento
    {
        public override decimal AplicaDescontoExtra(Orcamento orcamento)
        {
            return orcamento.Valor -= orcamento.Valor * 0.02m;
        }

        public override void Aprovar(Orcamento orcamento)
        {
            throw new System.Exception("Orçamento já está aprovado.");
        }

        public override void Reprovar(Orcamento orcamento)
        {
            throw new System.Exception("Orçamento está aprovado, não é possível reprova-lo");
        }
        public override void Finalizar(Orcamento orcamento)
        {
            orcamento.Estado = new Finalizado();
        }
    }

    public class Reprovado : EstadoDeUmOrcamento
    {
        public override decimal AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new System.Exception("Orçamentos reprovados não recebem desconto extra.");
        }

        public override void Aprovar(Orcamento orcamento)
        {
            throw new System.Exception("Não é possível aprovar orçamento pois está reprovado.");
        }

        public override void Finalizar(Orcamento orcamento)
        {
            throw new System.NotImplementedException();
        }

        public override void Reprovar(Orcamento orcamento)
        {
            throw new System.Exception("Orçamento já está reprovado.");
        }
    }

    public class Finalizado : EstadoDeUmOrcamento
    {
        public override decimal AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new System.Exception("Orçamentos finalizados não recebem desconto extra.");
        }

        public override void Aprovar(Orcamento orcamento)
        {
            throw new System.Exception("Não é possível aprovar um orçamento já finalizado.");
        }

        public override void Finalizar(Orcamento orcamento)
        {
            throw new System.Exception("Não é possível finalizar um orçamento já finalizado.");
        }

        public override void Reprovar(Orcamento orcamento)
        {
            throw new System.Exception("Não é possível reprovar um orçamento já reprovado.");
        }
    }
}