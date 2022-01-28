using chains_of_responsability.Impostos;

namespace chains_of_responsability.Descontos.Interface
{
    public interface IDesconto
    {
        double RetornarDesconto(Orcamento orcamento);
        IDesconto ProximoDesconto { get; set; }
    }
}
