using chains_of_responsability.Descontos.Interface;
using chains_of_responsability.Impostos;
using System.Linq;

namespace chains_of_responsability.Descontos.Strateges
{
    public class DescontoPorVendaCasada : IDesconto
    {
        public IDesconto ProximoDesconto { get; set; }

        public double RetornarDesconto(Orcamento orcamento)
        {
            bool temItem = this.ExisteItens("LAPIS", orcamento) || this.ExisteItens("CANETA", orcamento);

            if (temItem)
                return orcamento.Valor * 0.05;
            else
                return this.ProximoDesconto.RetornarDesconto(orcamento);
        }

        private bool ExisteItens(string nomeItem, Orcamento orcamento)
        {
            bool isExisteLapisOuCaneta = false;

            if (orcamento != null && orcamento.Itens.Count > 0)
            {
                isExisteLapisOuCaneta =
                    orcamento.Itens
                        .Where(item => item.Nome.ToUpper().Trim().Equals(nomeItem.ToUpper().Trim()))
                        .Count() > 0;
            }

            return isExisteLapisOuCaneta;
        }
    }
}
