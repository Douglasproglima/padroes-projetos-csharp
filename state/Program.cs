using state.Impostos;
using System;

namespace state
{
    internal class Program
    {
        /*
         Orçamento:         Desconto
            - Aprovado         5%
            - Reprovado        2%
            - Finalizado       0%

         Desconto:
            
         */

        static void Main(string[] args)
        {
            Orcamento reforma = new Orcamento(700);
            reforma.AplicarDescontoExtra();

            Console.ReadKey();
        }
    }
}
