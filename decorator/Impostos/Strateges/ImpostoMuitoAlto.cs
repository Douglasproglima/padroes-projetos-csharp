using decorator.Impostos.Interface;

namespace decorator.Impostos.Strateges
{
    public class ImpostoMuitoAlto : Imposto
    {
        public ImpostoMuitoAlto(Imposto outroImposto) : base(outroImposto) { }
        public ImpostoMuitoAlto() : base() { }

        public override double Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * 0.2 + OutroImposto.Calcular(orcamento);
        }
    }
}
