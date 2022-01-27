using System;
using strategy.Investimento.Interface;

namespace strategy.Investimento
{
    public class RealizadorDeInvestimentos
    {
        public double AplicarInvestimento(Conta conta, IInvestimento investimento)
        {
            double resultado = investimento.Calcular(conta);
            conta.Depositar(resultado);

            return conta.Saldo;
        }
    }
}