using observer.Interface;
using System;

namespace observer.Utils
{
    public class NotaFiscalDao : IAcaoAposGerarNF
    {
        public void ExecutarAcao(NotaFiscal nf)
        {
            Console.WriteLine("Simulando insert no BD.");
        }
    }
}
