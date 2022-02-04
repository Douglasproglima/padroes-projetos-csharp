using state.Impostos.Interface;
using System;

namespace state.Impostos.State
{
    public class Aprovado : IStatusOrcamento
    {
        public void AplicarDescontoExtra(Orcamento orcamento)
        {
            orcamento.Valor -= orcamento.Valor * 0.02;
        }

        public void Aprovar(Orcamento orcamento)
        {
            throw new Exception("Não é possível 'Aprovar' um orçamento que já está como aprovado!");
        }

        public void Reprovar(Orcamento orcamento)
        {
            throw new Exception("Não é possível 'Reprovar' um orçamento que já está como 'Aprovado'!");
        }

        public void Finalizar(Orcamento orcamento)
        {
            orcamento.StatuAtual = new Finalizado();
        }
    }
}
