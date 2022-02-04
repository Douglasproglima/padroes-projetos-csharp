using state.Impostos.Interface;

namespace state.Impostos.TemplateAlgorithm
{
    public abstract class TemplateImpostoCondicional : Imposto
    {
        public TemplateImpostoCondicional(Imposto outroImposto) : base(outroImposto) { }
        public TemplateImpostoCondicional() : base() { }

        public override double Calcular(Orcamento orcamento)
        {
            if (UsarTaxaMaxima(orcamento))
                return RetornarTaxaMaxima(orcamento) + OutroImposto.Calcular(orcamento);
            else
                return RetornarTaxaMinima(orcamento);
        }

        public abstract double RetornarTaxaMinima(Orcamento orcamento);
        public abstract double RetornarTaxaMaxima(Orcamento orcamento);
        public abstract bool UsarTaxaMaxima(Orcamento orcamento);
    }
}
