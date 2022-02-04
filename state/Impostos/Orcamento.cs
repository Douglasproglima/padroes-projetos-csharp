using System;
using System.Collections.Generic;

namespace state.Impostos
{
    public class Orcamento
    {
        public int EM_PROVACAO = 1;
        public int APROVADO = 2;
        public int REPROVADO = 3;
        public int FINALIZADO = 4;

        public int StatuAtual { get; set; }
        public double Valor { get; private set; }
        public IList<Item> Itens { get; private set; }

        public Orcamento(double valor)
        {
            this.Valor = valor;
            this.Itens = new List<Item>();
        }

        public void AplicarDescontoExtra()
        {
            if (StatuAtual == EM_PROVACAO) Valor = Valor - (Valor * 0.05);
            else if (StatuAtual == APROVADO) Valor = Valor - (Valor * 0.02);
            else throw new Exception("Orçamentos Reprovados/Finalizado não recebem descontos extras!");
        }

        public void AdicionarItem(Item item)
        {
            Itens.Add(item);
        }
    }
}
