using strategy.Investimento.Interface;
using System;

namespace strategy.Investimento.Strateges
{
    public class Arrojado : IInvestimento
    {
        private Random random;

        public Arrojado()
        {
            this.random = new Random();
        }

        public double Calcular(Conta conta)
        {
            int palpite = random.Next(10);

            if (palpite >= 0 && palpite <= 1)
                return conta.Saldo * 0.5;
            else if (palpite >= 2 && palpite <= 4)
                return conta.Saldo * 0.3;
            else
                return conta.Saldo * 0.006;
        }
    }
}
