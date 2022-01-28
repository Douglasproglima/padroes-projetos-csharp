using chains_of_responsability.Impostos.Interface;

namespace chains_of_responsability.Impostos.Strateges
{
    public class ISS : IImposto
    {
        public double Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }
    }
}
