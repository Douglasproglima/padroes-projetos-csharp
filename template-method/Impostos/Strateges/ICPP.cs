using template_method.Impostos.TemplateAlgorithm;

namespace template_method.Impostos.Strateges
{
    public class ICPP : TemplateImpostoCondicional
    {
        public override bool UsarTaxaMaxima(Orcamento orcamento)
        {
            return orcamento.Valor >= 500;
        }

        public override double RetornarTaxaMaxima(Orcamento orcamento)
        {
            return orcamento.Valor * 0.07;
        }

        public override double RetornarTaxaMinima(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05;
        }
    }
}