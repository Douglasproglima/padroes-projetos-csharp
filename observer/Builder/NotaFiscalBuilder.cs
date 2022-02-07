using System;
using System.Collections.Generic;

namespace observer
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
            NotaFiscal nf = new NotaFiscal(RazaoSocial, Cnpj, Data, ValorTotal, Imposto, Itens, Observacao);

            this.SalvarNota();
            this.EnviarEmail();
            this.EnviarSMS();

            return nf;
        }

        public void EnviarEmail()
        {
            Console.WriteLine("Simulando envio do e-mail.");
        }

        public void EnviarSMS()
        {
            Console.WriteLine("Simulando envio do SMS.");
        }

        public void SalvarNota()
        {
            Console.WriteLine("Simulando insert no BD.");
        }

        public NotaFiscalBuilder InserirRazaoSocial(String razaoSocial)
        {
            this.RazaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilder InserirCNPJ(String cnpj)
        {
            this.Cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilder InserirItem(ItemNota item)
        { 
            this.Itens.Add(item);
            this.ValorTotal += item.Valor;
            this.Imposto = item.Valor * 0.05;
            return this;
        }

        public NotaFiscalBuilder InserirObs(string observacao)
        { 
            this.Observacao = observacao;
            return this;
        }

        public NotaFiscalBuilder DataAtual()
        { 
            this.Data = DateTime.Now;
            return this;
        }
    }
}
