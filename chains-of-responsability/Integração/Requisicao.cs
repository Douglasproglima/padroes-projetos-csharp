using chains_of_responsability.Integração.Enum;

namespace chains_of_responsability.Integração
{
    public class Requisicao
    {
        public FormatoEnum Formato { get; set; }
        public Requisicao(FormatoEnum formato)
        { 
            this.Formato = formato;
        }
    }
}
