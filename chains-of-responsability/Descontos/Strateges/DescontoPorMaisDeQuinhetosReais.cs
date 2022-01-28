using chains_of_responsability.Descontos.Interface;
using chains_of_responsability.Impostos;

namespace chains_of_responsability.Descontos.Strateges
{
    public class DescontoPorMaisDeQuinhetosReais : IDesconto
    {
        public IDesconto ProximoDesconto { get; set; }
        public double RetornarDesconto(Orcamento orcamento)
        {
            if (orcamento.Valor > 500.0)
                return orcamento.Valor * 0.07;

            return this.ProximoDesconto.RetornarDesconto(orcamento);
        }
    }
}
