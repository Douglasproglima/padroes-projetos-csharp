using System;
using decorator.Impostos.Interface;

namespace decorator.Impostos
{
    public class CalcularImposto
    {
        public double RealizarCalculo(Orcamento orcamento, Imposto imposto)
        {
            return imposto.Calcular(orcamento);
        }
    }
}
