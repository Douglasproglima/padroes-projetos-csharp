using observer.Interface;
using observer.Utils;
using System;
using System.Collections.Generic;

namespace observer
{
    public class NotaFiscalBuilder
    {
        public String RazaoSocial { get; private set; }
        public String Cnpj { get; private set; }
        public double ValorTotal { get; private set; }
        public double Imposto { get; private set; }
        public DateTime Data { get; private set; }
        private String observacao;
        private IList<ItemNota> itens = new List<ItemNota>();
        private IList<IAcaoAposGerarNF> todasAcoesNF;

        public NotaFiscalBuilder()
        { 
            this.todasAcoesNF = new List<IAcaoAposGerarNF>();
        }

        public NotaFiscal CriarNF()
        {
            NotaFiscal nf = new NotaFiscal(RazaoSocial, Cnpj, Data, ValorTotal, Imposto, itens, observacao);

            foreach (IAcaoAposGerarNF acaoAposGerarNF in todasAcoesNF)
                acaoAposGerarNF.ExecutarAcao(nf);

            return nf;
        }

        public void AdicionarAcaoNotaFiscal(IAcaoAposGerarNF novaAcao)
        { 
            this.todasAcoesNF.Add(novaAcao);
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
            this.itens.Add(item);
            this.ValorTotal += item.Valor;
            this.Imposto = item.Valor * 0.05;
            return this;
        }

        public NotaFiscalBuilder InserirObs(string observacao)
        { 
            this.observacao = observacao;
            return this;
        }

        public NotaFiscalBuilder DataAtual()
        { 
            this.Data = DateTime.Now;
            return this;
        }
    }
}
