using chains_of_responsability.Descontos.Interface;
using chains_of_responsability.Impostos;

namespace chains_of_responsability.Descontos.Strateges
{
    public class SemDesconto : IDesconto
    {
        public IDesconto ProximoDesconto { get; set; }

        public double RetornarDesconto(Orcamento orcamento)
        {
            return 0;
        }
    }
}
