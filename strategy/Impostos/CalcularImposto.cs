using System;
using strategy.Impostos.Interface;

namespace strategy.Impostos
{
    public class CalcularImposto
    {
        public double RealizarCalculo(Orcamento orcamento, IImposto imposto)
        {
            return imposto.Calcular(orcamento);
        }
    }
}
