using System;
using decorator.Impostos.Interface;

namespace decorator.Impostos
{
    public class CalcularImposto
    {
        public double RealizarCalculo(Orcamento orcamento, IImposto imposto)
        {
            return imposto.Calcular(orcamento);
        }
    }
}
