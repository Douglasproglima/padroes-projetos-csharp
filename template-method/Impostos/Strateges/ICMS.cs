using template_method.Impostos.Interface;

namespace template_method.Impostos.Strateges
{
    public class ICMS : IImposto
    {
        public double Calcular(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.05) + 50;
        }
    }
}
