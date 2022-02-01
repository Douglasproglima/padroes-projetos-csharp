using template_method.Impostos.Interface;

namespace template_method.Impostos.TemplateAlgorithm
{
    public abstract class TemplateImpostoCondicional : IImposto
    {
        public double Calcular(Orcamento orcamento)
        {
            if (UsarTaxaMaxima(orcamento))
                return RetornarTaxaMaxima(orcamento);
            else
                return RetornarTaxaMinima(orcamento);
        }

        public abstract double RetornarTaxaMinima(Orcamento orcamento);
        public abstract double RetornarTaxaMaxima(Orcamento orcamento);
        public abstract bool UsarTaxaMaxima(Orcamento orcamento);
    }
}
