using observer.Interface;
using System;

namespace observer.Utils
{
    public class EnviarEmail : IAcaoAposGerarNF
    {
        public void ExecutarAcao(NotaFiscal nf)
        {
            Console.WriteLine("Simulando envio do e-mail.");
        }
    }
}
