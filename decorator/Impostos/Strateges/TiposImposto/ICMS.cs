using decorator.Impostos.Interface;

namespace decorator.Impostos.Strateges
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
