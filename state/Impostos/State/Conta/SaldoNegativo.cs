using state.Impostos.Interface;
using System;

namespace state.Impostos.State.Conta
{
    public class SaldoNegativo : IStatusConta
    {
        public void Depositar(Impostos.Conta conta, double valor)
        {
            conta.Saldo += valor * 0.95;
            if (conta.Saldo > 0) 
                conta.Status = new SaldoPositivo();
        }

        public void Sacar(Impostos.Conta conta, double valor)
        {
            throw new Exception("Saldo negativo. Não é possível sacar!");
        }
    }
}
