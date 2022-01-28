using chains_of_responsability.Impostos;

namespace chains_of_responsability.Descontos
{
    public class CalcularDesconto
    {
        /*
            Problema: muitos IF e baixa coesão na nessa.
            Solução: Aplica o padrão Strategy
         */

        public double Calcular(Orcamento orcamento)
        {
            if (orcamento.Itens.Count > 5)
                return orcamento.Valor * 0.1;
            else if (orcamento.Valor > 500.0)
                return orcamento.Valor * 0.07;

            return 0;
        }
    }
}
