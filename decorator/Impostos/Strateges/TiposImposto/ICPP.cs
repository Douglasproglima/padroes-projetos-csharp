using decorator.Impostos.Interface;
using decorator.Impostos.TemplateAlgorithm;

namespace decorator.Impostos.Strateges
{
    public class ICPP : TemplateImpostoCondicional
    {
        public ICPP(Imposto imposto) : base(imposto) { }
        public ICPP() : base() { }

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