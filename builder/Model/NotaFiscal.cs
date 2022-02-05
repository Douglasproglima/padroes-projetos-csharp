using System;
using System.Collections.Generic;
using System.Linq;

namespace builder
{
    public class NotaFiscal
    {
        public String RazaoSocial { get; private set; }
        public String Cnpj { get; private set; }
        public DateTime DataDeEmissao { get; private set; }
        public double ValorBruto { get; private set; }
        public double Imposto { get; private set; }
        public IList<ItemNota> Itens { get; private set; }
        public String Observacoes { get; private set; }

        public NotaFiscal(String razaoSocial, String cnpj, DateTime dataDeEmissao,
                          double valorBruto, double impostos, IList<ItemNota> itens, String observacoes)
        {
            this.RazaoSocial = razaoSocial;
            this.Cnpj = cnpj;
            this.DataDeEmissao = dataDeEmissao;
            this.ValorBruto = valorBruto;
            this.Imposto = impostos;
            this.Itens = itens;
            this.Observacoes = observacoes;
        }

        public string ShowNotaFiscal()
        {
            Util util = new Util();
            string itens = string.Empty;

            foreach (var item in Itens)
            {
                itens += item.ShowItem()+"\n";
            }


            string nf = $"Empresa: {RazaoSocial}\nCNPJ: {Cnpj}\nData Emissão: {DataDeEmissao}\nValor Total: {util.FormatarValor(ValorBruto)}\nImposto: {Imposto}\nObservações: {Observacoes}\n\n{itens}";

            return nf;
        }
    }
}
