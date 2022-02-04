using state.Impostos.Interface;
using System;

namespace state.Impostos.State
{
    public class EmAnalise : IStatusOrcamento
    {
        public void AplicarDescontoExtra(Orcamento orcamento)
        {
            orcamento.Valor -= orcamento.Valor * 0.05;
        }

        public void Aprovar(Orcamento orcamento)
        {
            orcamento.StatuAtual = new Aprovado();
        }

        public void Reprovar(Orcamento orcamento)
        {
            orcamento.StatuAtual = new Reprovado();
        }

        public void Finalizar(Orcamento orcamento)
        {
            throw new Exception("Orçamento 'Em Análise' não pode ser finalizado diretamente!");
        }
    }
}
