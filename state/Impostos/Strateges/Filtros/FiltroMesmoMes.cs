using System;
using System.Collections.Generic;

namespace state.Impostos.Strateges.Filtros
{
    public class FiltroMesmoMes : Filtro
    {
        private DateTime DataAtual = DateTime.Now;
        public FiltroMesmoMes(Filtro outroFiltro) : base(outroFiltro) { }

        public override IList<Conta> Filtrar(IList<Conta> contas)
        {
            IList<Conta> contaFiltrada = new List<Conta>();
            foreach (Conta conta in contas)
            { 
                if(conta.DataAberturaConta.Month == DataAtual.Month && conta.DataAberturaConta.Year == DataAtual.Year)
                    contaFiltrada.Add(conta);
            }

            foreach (Conta conta in contas)
                contaFiltrada.Add(conta);

            return contaFiltrada;
        }
    }
}
