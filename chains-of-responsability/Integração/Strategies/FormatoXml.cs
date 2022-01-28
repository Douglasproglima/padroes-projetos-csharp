using chains_of_responsability.Integração.Enum;
using chains_of_responsability.Integração.Interface;

namespace chains_of_responsability.Integração.Strategies
{
    public class FormatoXml : ITipoFormato
    {
        public ITipoFormato ProximoTipoFormato { get; set; }

        public FormatoXml()
        {
            this.ProximoTipoFormato = null;
        }

        public FormatoXml(ITipoFormato proximoTipoFormato)
        { 
            this.ProximoTipoFormato = proximoTipoFormato;
        }

        public string RetornarTipoFormato(Requisicao requisicao, Conta conta)
        {
            if (requisicao.Formato.Equals(FormatoEnum.XML))
            {
                string xml = @$"<conta><titular>{conta.Titular}</titular></conta>";
                return xml;
            }
            else if (ProximoTipoFormato != null)
                return this.ProximoTipoFormato.RetornarTipoFormato(requisicao, conta);
            else
                throw new System.Exception("Formato de resposta não encontrado!");
        }
    }
}
