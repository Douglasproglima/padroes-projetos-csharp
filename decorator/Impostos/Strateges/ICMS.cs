using decorator.Impostos.Interface;

namespace decorator.Impostos.Strateges
{
    public class ICMS : IImposto
    {
        public double Calcular(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.05) + 50;
        }
    }
}
