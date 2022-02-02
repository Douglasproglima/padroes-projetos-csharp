namespace decorator.Impostos.Interface
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
            if (OutroImposto == null) return 0;

            return OutroImposto.Calcular(orcamento);
        }
    }
}
