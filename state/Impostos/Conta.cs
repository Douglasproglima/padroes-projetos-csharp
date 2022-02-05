using System;

namespace state.Impostos
{
    public class Conta
    {
        interface IStatusConta
        {
            void Depositar(Conta conta, double valor);
            void Sacar(Conta conta, double valor);
        }

        class SaldoNegativo : IStatusConta
        {
            public void Depositar(Conta conta, double valor)
            {
                conta.Saldo += valor;
            }

            public void Sacar(Conta conta, double valor)
            {
                conta.Saldo -= valor;
            }
        }

        public double Saldo { get; private set; }
        public DateTime DataAberturaConta { get; set; }
    }
}
