using observer.Interface;
using observer.Utils;
using System;
using System.Collections.Generic;

namespace observer
{
    internal class Program
    {
        /*
         * Problema Proposto:
         * Além de criar o objeto NF agora será necessário
         * Enviar NF por email
         * Salvar no BD
         * Enviar por SMS
         */
        static void Main(string[] args)
        {
            IList<IAcaoAposGerarNF> acoes = new List<IAcaoAposGerarNF>();
            acoes.Add(new EnviarEmail());
            acoes.Add(new EnviarSMS());
            acoes.Add(new NotaFiscalDao());
            acoes.Add(new ImprimirRelatorio(3));


            NotaFiscalBuilder criarNf = new NotaFiscalBuilder(acoes);
            criarNf.InserirRazaoSocial("Minha Empresa")
                   .InserirCNPJ("45.563.289/0001-95")
                   .InserirItem(new ItemNota("Item 1", 55.68))
                   .InserirItem(new ItemNota("Item 2", 105.01))
                   .InserirItem(new ItemNota("Item 3", 75.65))
                   .InserirItem(new ItemNota("Item 4", 10.34))
                   .InserirObs("Uma observação qualquer")
                   .DataAtual();

            /*
            criarNf.AdicionarAcaoNotaFiscal(new EnviarEmail());
            criarNf.AdicionarAcaoNotaFiscal(new EnviarSMS());
            criarNf.AdicionarAcaoNotaFiscal(new NotaFiscalDao());
            criarNf.AdicionarAcaoNotaFiscal(new ImprimirRelatorio(3));
            */

            NotaFiscal nf = criarNf.CriarNF();


            Console.WriteLine(nf.ShowNotaFiscal());
            Console.ReadKey();
        }
    }
}
