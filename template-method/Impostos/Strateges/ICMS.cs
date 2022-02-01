using template_method.Impostos.Interface;

namespace template_method.Impostos.Strateges
{
    internal class ICMS : IImposto
    {
        public double Calcular(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.05) + 50;
        }
    }
}
