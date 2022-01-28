using chains_of_responsability.Descontos.Strateges;
using chains_of_responsability.Impostos;

namespace chains_of_responsability.Descontos
{
    public class CalcularDesconto
    {
        public double Calcular(Orcamento orcamento)
        {
            double desconto = new DescontoPorCincoItens().Calcular(orcamento);
            if(desconto == 0)
                desconto = new DescontoPorMaisDeQuinhetosReais().Calcular(orcamento);
            else if(desconto > 5)
                desconto  = new DescontoPorMaisDeQuinhetosReais().Calcular(orcamento) * 0.05;

            return desconto;
        }
    }
}
