namespace builder
{
    public class ItemNota
    {
        public string Descricao { get; private set; }
        public double Valor { get; private set; }

        public ItemNota(string item, double valor)
        { 
            this.Descricao = item;
            this.Valor = valor;
        }

        public string ShowItem()
        {
            Util util = new Util();

            return @$"Item: {Descricao} | Valor: {util.FormatarValor(Valor)}";
        }
    }
}