using state.Impostos;
using System;

namespace state
{
    internal class Program
    {
        /*
         Orçamento:         Desconto
            - Em Análise       5%
            - Aprovado         2%
            - Reprovado        0%
            - Finalizado       0%

         Desconto:
            
         */

        static void Main(string[] args)
        {
            Orcamento reforma = new Orcamento(500);
            
            Console.WriteLine($"Orçamento Inicial: {reforma.Valor}");
            
            reforma.AplicarDescontoExtra();
            Console.WriteLine("Valor do Orçamento Aprovado: " + reforma.Valor);
            reforma.Aprovar();

            reforma.AplicarDescontoExtra();
            Console.WriteLine("Valor do Orçamento Finalizado: " + reforma.Valor);
            reforma.Finalizar();

            //reforma.Finalizar();
            //reforma.AplicarDescontoExtra();

            //reforma.Reprovar();
            //reforma.AplicarDescontoExtra();

            Console.ReadKey();
        }
    }
}
