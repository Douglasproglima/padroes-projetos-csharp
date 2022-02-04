namespace state.Impostos.Interface
{
    public interface IStatusOrcamento
    {
        void AplicarDescontoExtra(Orcamento orcamento);
        void Aprovar(Orcamento orcamento);
        void Reprovar(Orcamento orcamento);
        void Finalizar(Orcamento orcamento);
    }
}
