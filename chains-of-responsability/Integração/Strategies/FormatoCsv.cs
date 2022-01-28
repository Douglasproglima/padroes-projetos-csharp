using chains_of_responsability.Integração.Enum;
using chains_of_responsability.Integração.Interface;

namespace chains_of_responsability.Integração.Strategies
{
    public class FormatoCsv : ITipoFormato
    {
        public ITipoFormato ProximoTipoFormato { get; private set; }

        public FormatoCsv()
        {
            this.ProximoTipoFormato = null;
        }

        public FormatoCsv(ITipoFormato proximoTipoFormato)
        {
            this.ProximoTipoFormato = proximoTipoFormato;
        }

        public string RetornarTipoFormato(Requisicao requisicao, Conta conta)
        {
            if (requisicao.Formato.Equals(FormatoEnum.CSV))
            {
                string csv = @$"{conta.Titular};";
                return csv;
            }
            else if (ProximoTipoFormato != null)
                return this.ProximoTipoFormato.RetornarTipoFormato(requisicao, conta);
            else
                throw new System.Exception("Formato de resposta não encontrado!");
        }
    }
}
