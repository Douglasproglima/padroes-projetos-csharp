namespace state.Impostos.Interface
{
    public interface IStatusConta
    {
        void Depositar(Conta conta, double valor);
        void Sacar(Conta conta, double valor);
    }
}
