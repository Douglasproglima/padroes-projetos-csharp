using observer.Interface;
using System;

namespace observer.Utils
{
    public class ImprimirRelatorio : IAcaoAposGerarNF
    {
        public double Fator { get; private set; }

        public ImprimirRelatorio(double fator)
        {
            this.Fator = fator;
        }

        public void ExecutarAcao(NotaFiscal nf)
        {
            Console.WriteLine("Simulando Relatório, Valor da Nota:" + nf.ValorBruto+ " | Fato de Multiplicação: " + this.Fator + "\nValor Atualizado: " + nf.ValorBruto  * Fator+"\n\n");
        }
    }
}
