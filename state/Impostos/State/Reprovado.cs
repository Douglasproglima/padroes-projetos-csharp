using state.Impostos.Interface;
using System;

namespace state.Impostos.State
{
    public class Reprovado : IStatusOrcamento
    {
        public void AplicarDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamentos 'Reprovados' não recebem descontos extras!");
        }

        public void Aprovar(Orcamento orcamento)
        {
            throw new Exception("Não é possível 'Aprovar' um orçamento reprovado!");
        }

        public void Finalizar(Orcamento orcamento)
        {
            orcamento.StatuAtual = new Finalizado();
        }

        public void Reprovar(Orcamento orcamento)
        {
            throw new Exception("Não é possível 'Reprovar' um orçamento já reprovado!");
        }
    }
}
