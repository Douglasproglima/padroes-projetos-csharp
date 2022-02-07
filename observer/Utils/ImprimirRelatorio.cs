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
            Util util = new Util();
            Console.WriteLine(
                "Simulando Relatório, Valor da Nota:" + 
                util.FormatarValor(nf.ValorBruto)+ " | Fato de Multiplicação: " + this.Fator + "\n" +
                "Valor Atualizado: " + util.FormatarValor(nf.ValorBruto  * Fator)+"\n\n");
        }
    }
}
