using template_method.Impostos.Interface;

namespace template_method.Impostos.Strateges
{
    public class IKCV : IImposto
    {
        public double Calcular(Orcamento orcamento)
        {
            if (orcamento.Valor >= 500)
                return orcamento.Valor * 0.07;
            else
                return orcamento.Valor * 0.05;
        }
    }
}

