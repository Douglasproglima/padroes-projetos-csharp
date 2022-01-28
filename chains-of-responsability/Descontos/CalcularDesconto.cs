using chains_of_responsability.Descontos.Interface;
using chains_of_responsability.Descontos.Strateges;
using chains_of_responsability.Impostos;

namespace chains_of_responsability.Descontos
{
    public class CalcularDesconto
    {
        public double Calcular(Orcamento orcamento)
        {
            IDesconto d1 = new DescontoPorCincoItens();
            IDesconto d2 = new DescontoPorMaisDeQuinhetosReais();
            IDesconto d3 = new DescontoPorVendaCasada();
            IDesconto d4 = new SemDesconto();

            d1.ProximoDesconto = d2;
            d2.ProximoDesconto = d3;
            d3.ProximoDesconto = d4;
            d4.ProximoDesconto = d1;

            return d1.RetornarDesconto(orcamento);
        }
    }
}
