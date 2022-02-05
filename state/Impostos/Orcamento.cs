using state.Impostos.Interface;
using state.Impostos.State;
using System;
using System.Collections.Generic;

namespace state.Impostos
{
    public class Orcamento
    {
        public IStatusOrcamento StatuAtual { get; set; }
        public double Valor { get; set; }
        public IList<Item> Itens { get; private set; }

        public Orcamento(double valor)
        {
            this.StatuAtual = new EmAnalise();
            this.Valor = valor;
            this.Itens = new List<Item>();
            this.StatuAtual = new EmAnalise();
        }

        public void Aprovar()
        {
            StatuAtual.Aprovar(this);
        }

        public void Reprovar()
        { 
            StatuAtual.Reprovar(this);
        }

        public void Finalizar()
        { 
            StatuAtual.Finalizar(this);
        }

        public void AplicarDescontoExtra()
        {
            StatuAtual.AplicarDescontoExtra(this);
        }

        public void AdicionarItem(Item item)
        {
            Itens.Add(item);
        }
    }
}
