using chains_of_responsability.Impostos.Interface;

namespace chains_of_responsability.Impostos.Strateges
{
    internal class ICMS : IImposto
    {
        public double Calcular(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.05) + 50;
        }
    }
}
