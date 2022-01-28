using chains_of_responsability.Integração.Enum;
using chains_of_responsability.Integração.Interface;

namespace chains_of_responsability.Integração.Strategies
{
    internal class FormatoPorcento : ITipoFormato
    {
        public ITipoFormato ProximoTipoFormato { get; private set; }

        public FormatoPorcento()
        {
            this.ProximoTipoFormato = null;
        }

        public FormatoPorcento(ITipoFormato proximoTipoFormato)
        {
            this.ProximoTipoFormato = proximoTipoFormato;
        }

        public string RetornarTipoFormato(Requisicao requisicao, Conta conta)
        {
            if (requisicao.Formato.Equals(FormatoEnum.CSV))
            {
                string porCento = @$"{conta.Titular}%";
                return porCento;
            }
            else if (ProximoTipoFormato != null)
                return this.ProximoTipoFormato.RetornarTipoFormato(requisicao, conta);
            else
                throw new System.Exception("Formato de resposta não encontrado!");
        }
    }
}
