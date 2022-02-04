using System.Collections.Generic;

namespace state.Impostos.Strateges
{
    public abstract class Filtro
    {
        protected Filtro OutroFiltro { get; private set; }

        public Filtro(Filtro outroFiltro)
        { 
            this.OutroFiltro = outroFiltro;
        }

        public Filtro() { }

        public abstract IList<Conta> Filtrar(IList<Conta> contas);

        protected IList<Conta> Proximo(IList<Conta> contas)
        { 
            if(OutroFiltro != null) return OutroFiltro.Filtrar(contas);
            else return new List<Conta>();
        }

    }
}
