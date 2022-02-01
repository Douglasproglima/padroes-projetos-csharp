using System;
using System.Linq;
using System.Collections.Generic;
using template_method.Impostos.TemplateAlgorithm;

namespace template_method.Impostos.Strateges
{
    public class IHIT : TemplateImpostoCondicional
    {
        public override double RetornarTaxaMaxima(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.13) + 100;
        }

        public override double RetornarTaxaMinima(Orcamento orcamento)
        {
            return orcamento.Itens.Count() * 0.01;
        }

        public override bool UsarTaxaMaxima(Orcamento orcamento)
        {
            return this.ExisteItemComMesmoNome(orcamento);
        }

        private bool ExisteItemComMesmoNome(Orcamento orcamento)
        {
            bool retorno = false;

            IList<String> noOrcamento = new List<String>();

            foreach (Item item in orcamento.Itens)
            { 
                if(noOrcamento.Contains(item.Nome.ToUpper().Trim()))
                    retorno = true;
                else
                    noOrcamento.Add(item.Nome.ToUpper().Trim());
            }
            return retorno;
        }
    }
}
