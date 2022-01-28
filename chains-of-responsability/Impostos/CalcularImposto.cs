using System;
using chains_of_responsability.Impostos.Interface;

namespace chains_of_responsability.Impostos
{
    public class CalcularImposto
    {
        public double RealizarCalculo(Orcamento orcamento, IImposto imposto)
        {
            return imposto.Calcular(orcamento);
        }
    }
}
