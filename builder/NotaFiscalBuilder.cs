using System;
using System.Collections.Generic;

namespace builder
{
    public class NotaFiscalBuilder
    {
        private String RazaoSocial;
        private String Cnpj;
        private double ValorTotal;
        private double Imposto;
        private DateTime Data;
        private String Observacao;
        private IList<ItemNota> Itens = new List<ItemNota>();

        public NotaFiscal CriarNF()
        {
            return new NotaFiscal(RazaoSocial, Cnpj, Data, ValorTotal, Imposto, Itens, Observacao);
        }

        public void InserirRazaoSocial(String razaoSocial)
        {
            this.RazaoSocial = razaoSocial;
        }

        public void InserirCNPJ(String cnpj)
        {
            this.Cnpj = cnpj;
        }

        public void InserirItem(ItemNota item)
        { 
            this.Itens.Add(item);
            this.ValorTotal += item.Valor;
            this.Imposto = item.Valor * 0.05;
        }

        public void InserirObs(string observacao)
        { 
            this.Observacao = observacao;
        }

        public void DataAtual()
        { 
            this.Data = DateTime.Now;
        }
    }
}
