using observer.Interface;
using System;

namespace observer.Utils
{
    public class EnviarSMS : IAcaoAposGerarNF
    {
        public void ExecutarAcao(NotaFiscal nf)
        {
            Console.WriteLine("Simulando envio do SMS.");
        }
    }
}
