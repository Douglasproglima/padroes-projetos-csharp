using System;
using strategy.Impostos;
using strategy.Impostos.Interface;
using strategy.Impostos.Strateges;
using strategy.Investimento;
using strategy.Investimento.Interface;
using strategy.Investimento.Strateges;

namespace strategy
{
    internal class Program
    {
        private const string ICMS = "ICMS";
        private const string ISS = "ISS";
        private const string ICCC = "ICCC";

        private static void CalcularImpostos()
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

        private const string CONSERVADOR = "Conservador";
        private const string MODERADO = "Moderado";
        private const string ARROJADO = "Arrojado";

        private static void RetornarLogInvestimento(double valor, string perfil, double saldoAtual)
        {
            string msg = @"Valor Investido: {0} | Perfil: {1} | Saldo Atual: {2}";

            Console.WriteLine(string.Format(msg, valor, perfil, saldoAtual));
        }

        public static void CalcularInvestimentos()
        {
            double valorInvestido = 100.55;
            Conta conta = new Conta();
            conta.Depositar(valorInvestido);

            IInvestimento conservador = new Conservador();
            IInvestimento moderado = new Moderado();
            IInvestimento arrojado = new Arrojado();

            RealizadorDeInvestimentos investimentos = new RealizadorDeInvestimentos();

            double rendimentoConservador = investimentos.AplicarInvestimento(conta, conservador);
            RetornarLogInvestimento(valorInvestido, CONSERVADOR, rendimentoConservador);

            double rendimentoModerado = investimentos.AplicarInvestimento(conta, moderado);
            RetornarLogInvestimento(valorInvestido, MODERADO, rendimentoModerado);

            double rendimentoArrojado = investimentos.AplicarInvestimento(conta, arrojado);
            RetornarLogInvestimento(valorInvestido, ARROJADO, rendimentoArrojado);

            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            //CalcularImpostos();
            CalcularInvestimentos();
        }
    }
}
