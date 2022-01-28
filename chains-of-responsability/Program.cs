using System;
using chains_of_responsability.Descontos;
using chains_of_responsability.Descontos.Interface;
using chains_of_responsability.Descontos.Strateges;
using chains_of_responsability.Impostos;

namespace chains_of_responsability
{
    internal class Program
    {
        private static void CalcularImpostos()
        {
            CalcularDesconto calculador = new CalcularDesconto();

            Orcamento orcamento = new Orcamento(500.00);
            orcamento.AdicionarItem(new Item("Caneta", 250.00));
            orcamento.AdicionarItem(new Item("Caderno", 200));
            orcamento.AdicionarItem(new Item("PC", 50.00));

            double desconto = calculador.Calcular(orcamento);

            Console.WriteLine("Desconto Recebido: " + desconto);
        }

        static void Main(string[] args)
        {
            CalcularImpostos();
        }
    }
}
