using System.Collections.Generic;

namespace decorator.Impostos.Strateges.Filtros
{
    public class FiltroMaiorQue500MilReais : Filtro
    {
        public FiltroMaiorQue500MilReais(Filtro outroFiltro) : base(outroFiltro) {  }

        public override IList<Conta> Filtrar(IList<Conta> contas)
        {
            IList<Conta> contaFiltrada = new List<Conta>();
            foreach (Conta conta in contas)
            { 
                if(conta.Saldo > 500000) 
                    contaFiltrada.Add(conta);
            }

            foreach (Conta conta in contas)
            {
                contaFiltrada.Add(conta);
            }

            return contaFiltrada;
        }
    }
}
