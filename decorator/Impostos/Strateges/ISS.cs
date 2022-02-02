using decorator.Impostos.Interface;

namespace decorator.Impostos.Strateges
{
    public class ISS : Imposto
    {
        public ISS(Imposto outroImposto) : base(outroImposto) { }
        public ISS() : base() { }

        public override double Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06 + this.CalcularOutroImposto(orcamento);
        }
    }
}
