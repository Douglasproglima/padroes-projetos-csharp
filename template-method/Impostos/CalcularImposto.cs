using System;
using template_method.Impostos.Interface;

namespace template_method.Impostos
{
    public class CalcularImposto
    {
        public double RealizarCalculo(Orcamento orcamento, IImposto imposto)
        {
            return imposto.Calcular(orcamento);
        }
    }
}
