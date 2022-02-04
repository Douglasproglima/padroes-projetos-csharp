using state.Impostos.Interface;
using System;

namespace state.Impostos.State
{
    public class Finalizado : IStatusOrcamento
    {
        public void AplicarDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamento 'Finalizado' não recebem descontos extras!");
        }

        public void Aprovar(Orcamento orcamento)
        {
            throw new Exception("Não é possível 'Aprovar' um orçamento que já está como finalizado!");
        }

        public void Finalizar(Orcamento orcamento)
        {
            throw new Exception("Não é possível 'Finalizar' um orçamento que já está como finalizado!");
        }

        public void Reprovar(Orcamento orcamento)
        {
            throw new Exception("Não é possível 'Reprovar' um orçamento que já está como finalizado!");
        }
    }
}
