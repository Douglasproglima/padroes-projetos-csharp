using decorator.Impostos;
using decorator.Impostos.Interface;
using decorator.Impostos.Strateges;
using System;

namespace decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IImposto iss = new ISS();
            Orcamento orcamento = new Orcamento(500);

            double valor = iss.Calcular(orcamento);

            /*
             Na prática os impostos se agrupam de forma a por exemplo
             somar o iss com o icpp
             */

            Console.WriteLine(valor);
            Console.ReadKey();
        }
    }
}
