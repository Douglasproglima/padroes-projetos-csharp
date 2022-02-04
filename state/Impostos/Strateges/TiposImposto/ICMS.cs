using state.Impostos.Interface;

namespace state.Impostos.Strateges
{
    public class ICMS : Imposto
    {
        public ICMS(Imposto outroImposto) : base(outroImposto) { }
        public ICMS() : base() { }

        public override double Calcular(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.1) + CalcularOutroImposto(orcamento);
        }
    }
}
