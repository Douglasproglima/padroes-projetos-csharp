using strategy.Impostos.Interface;

namespace strategy.Impostos.Strateges
{
    public class ICCC : IImposto
    {
        public double Calcular(Orcamento orcamento)
        {
            double valor = 0;

            if (orcamento.Valor < 1000)
                valor = (orcamento.Valor * 0.05);
            else if (orcamento.Valor >= 1000 && orcamento.Valor <= 3000)
                valor = (orcamento.Valor * 0.07);
            else if(orcamento.Valor > 3000)
                valor = (orcamento.Valor * 0.08) + 30;

            return valor;
        }
    }
}
