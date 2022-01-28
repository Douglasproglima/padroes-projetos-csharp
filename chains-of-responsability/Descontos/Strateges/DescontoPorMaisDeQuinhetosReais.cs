using chains_of_responsability.Impostos;

namespace chains_of_responsability.Descontos.Strateges
{
    public class DescontoPorMaisDeQuinhetosReais
    {
        public double Calcular(Orcamento orcamento)
        {
            if (orcamento.Valor > 500.0)
                return orcamento.Valor * 0.07;

            return 0;
        }
    }
}
