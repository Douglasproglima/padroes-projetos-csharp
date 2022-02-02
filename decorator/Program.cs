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
            //Decorator -> Umm objeto que precisa calcular vários impostos agrupados.
            Imposto iss = new ISS(new ICMS(new IKCV()));
            Orcamento orcamento = new Orcamento(500);

            double valor = iss.Calcular(orcamento);

            /*
             Na prática os impostos se agrupam de forma a por exemplo
             somar o iss com o icpp.
             Com isso em mente é necessário implementar uma forma de compor os impostos.
             */

            Console.WriteLine(valor);
            Console.ReadKey();
        }
    }
}
