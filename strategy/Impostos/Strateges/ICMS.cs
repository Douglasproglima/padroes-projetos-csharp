using strategy.Impostos.Interface;

namespace strategy.Impostos.Strateges
{
    internal class ICMS : IImposto
    {
        public double Calcular(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.05) + 50;
        }
    }
}
