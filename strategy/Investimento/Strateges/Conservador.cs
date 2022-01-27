using strategy.Investimento.Interface;

namespace strategy.Investimento.Strateges
{
    public class Conservador : IInvestimento
    {
        public double Calcular(Conta conta)
        {
            return conta.Saldo * 0.008;
        }
    }
}
