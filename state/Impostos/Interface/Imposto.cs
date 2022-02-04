namespace state.Impostos.Interface
{
    public abstract class Imposto
    {
        public Imposto OutroImposto { get; set; }

        public Imposto(Imposto outroImposto)
        {
            this.OutroImposto = outroImposto;
        }

        //Finaliza a composição
        public Imposto()
        {
            this.OutroImposto = null;
        }

        public abstract double Calcular(Orcamento orcamento);

        protected double CalcularOutroImposto(Orcamento orcamento)
        {
            return OutroImposto == null ? 0 : OutroImposto.Calcular(orcamento);
        }
    }
}
