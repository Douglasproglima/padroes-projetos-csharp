using System.Linq;
using template_method.Impostos.Interface;

namespace template_method.Impostos.Strateges
{
    public class ICPP : IImposto
    {
        public double Calcular(Orcamento orcamento)
        {
            if (orcamento.Valor > 500 && existeItemMaior500Reais(orcamento))
                return orcamento.Valor * 0.1;
            else
                return orcamento.Valor * 0.06;
        }

        private bool existeItemMaior500Reais(Orcamento orcamento)
        {
            bool retorno = false;

            var itensMaior100 = from itens in orcamento.Itens
                                where itens.Valor > 100
                                select itens;

            retorno = itensMaior100.Count() > 0;

            return retorno;
        }
    }
}