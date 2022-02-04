using System;
using state.Impostos.Interface;

namespace state.Impostos
{
    public class CalcularImposto
    {
        public double RealizarCalculo(Orcamento orcamento, Imposto imposto)
        {
            return imposto.Calcular(orcamento);
        }
    }
}
