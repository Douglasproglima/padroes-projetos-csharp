﻿using decorator.Impostos.Interface;

namespace decorator.Impostos.Strateges
{
    public class ICCC : Imposto
    {
        public ICCC(Imposto outroImposto) : base(outroImposto) { }

        public ICCC() : base() { }

        public override double Calcular(Orcamento orcamento)
        {
            double valor = 0;

            if (orcamento.Valor < 1000)
                valor = (orcamento.Valor * 0.05) + OutroImposto.Calcular(orcamento);
            else if (orcamento.Valor >= 1000 && orcamento.Valor <= 3000)
                valor = (orcamento.Valor * 0.07) + OutroImposto.Calcular(orcamento);
            else if(orcamento.Valor > 3000)
                valor = (orcamento.Valor * 0.08) + 30 + OutroImposto.Calcular(orcamento);

            return valor;
        }
    }
}