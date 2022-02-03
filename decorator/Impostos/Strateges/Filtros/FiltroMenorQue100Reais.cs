using System.Collections.Generic;

namespace decorator.Impostos.Strateges.Filtros
{
    public class FiltroMenorQue100Reais : Filtro
    {
        public FiltroMenorQue100Reais(Filtro outroFiltro) : base(outroFiltro) {  }

        public override IList<Conta> Filtrar(IList<Conta> contas)
        {
            IList<Conta> contaFiltrada = new List<Conta>();
            foreach (Conta conta in contas)
            {
                if (conta.Saldo < 100)
                    contaFiltrada.Add(conta);
            }

            foreach (Conta conta in Proximo(contas))
                contaFiltrada.Add(conta);

            return contaFiltrada;
        }
    }
}
