using state.Impostos.Interface;
using System;

namespace state.Impostos
{
    public class Conta
    {
        public IStatusConta StatusConta;
        public double Saldo { get; set; }
        public DateTime DataAberturaConta { get; set; }

        public void Depositar(double valor)
        {
            StatusConta.Depositar(this, valor);
        }

        public void Sacar(double valor)
        {
            StatusConta.Sacar(this, valor);
        }
    }
}
