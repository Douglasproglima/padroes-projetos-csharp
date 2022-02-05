using state.Impostos.Interface;

namespace state.Impostos.State.Conta
{
    public class SaldoPositivo : IStatusConta
    {
        public void Depositar(Impostos.Conta conta, double valor)
        {
            conta.Saldo += valor * 0.98;
        }

        public void Sacar(Impostos.Conta conta, double valor)
        {
            conta.Saldo -= valor;

            if (conta.Saldo <= 0) 
                conta.Status = new SaldoNegativo();
        }
    }
}
