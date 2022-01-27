using System;
using strategy.Impostos;
using strategy.Impostos.Interface;
using strategy.Impostos.Strateges;

namespace strategy
{
    internal class Program
    {
        private const string ICMS = "ICMS";
        private const string ISS = "ISS";
        private const string ICCC = "ICCC";

        static void Main(string[] args)
        {
            double valor = 5.2;
            Orcamento orcamento = new Orcamento(valor);
            CalcularImposto calcular = new CalcularImposto();
            
            IImposto icms = new ICMS();
            IImposto iss = new ISS();
            IImposto iccc = new ICCC();

            double valorIcms = calcular.RealizarCalculo(orcamento, icms);
            double valorIss = calcular.RealizarCalculo(orcamento, iss);
            double valoriccc = calcular.RealizarCalculo(orcamento, iccc);

            string msg = "Valor: {0} | {1}: {2}";

            Console.WriteLine(string.Format(msg, valor, ICMS, valorIcms));
            Console.WriteLine(string.Format(msg, valor, ISS, valorIss));
            Console.WriteLine(string.Format(msg, valor, ICCC, valoriccc));

            Console.ReadKey();
        }
    }
}
