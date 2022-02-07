using System;

namespace observer.Builder
{
    public class ItemNotaBuilder
    {
        public String Descricao { get; private set; }
        public double Valor { get; private set; }

        public ItemNota CriarItemNota(String descricao, double Valor)
        { 
            return new ItemNota(descricao, Valor);
        }

        public ItemNotaBuilder InserirDescricao(String descricao)
        { 
            this.Descricao = descricao;
            return this;
        }

        public ItemNotaBuilder InserirValor(double valor)
        {
            this.Valor = valor;
            return this;
        }
    }
}
