using chains_of_responsability.Impostos;

namespace chains_of_responsability.Descontos.Strateges
{
    public class DescontoPorCincoItens
    {
        public double Calcular(Orcamento orcamento)
        {
            if (orcamento != null && orcamento.Itens.Count > 5)
                return orcamento.Valor * 0.07;

            return 0;
        }
    }
}
