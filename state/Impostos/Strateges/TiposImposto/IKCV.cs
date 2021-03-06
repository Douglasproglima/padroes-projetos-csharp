using System.Linq;
using state.Impostos.Interface;
using state.Impostos.TemplateAlgorithm;

namespace state.Impostos.Strateges
{
    public class IKCV : TemplateImpostoCondicional
    {
        public IKCV(Imposto outroImposto) : base(outroImposto) { }
        public IKCV() : base() { }

        public override bool UsarTaxaMaxima(Orcamento orcamento)
        {
            return orcamento.Valor > 500 && this.ExisteItemMaior100Reais(orcamento);
        }

        public override double RetornarTaxaMaxima(Orcamento orcamento)
        {
            return orcamento.Valor * 0.10;
        }

        public override double RetornarTaxaMinima(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }

        private bool ExisteItemMaior100Reais(Orcamento orcamento)
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

